using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace BelowAverage
{
    class SecureDesktop
    {
        public const int TOKEN_DUPLICATE = 0x0002;
        public const int TOKEN_IMPERSONATE = 0x0004;
        public const int TOKEN_QUERY = 0x0008;
        public const string SE_DEBUG_NAME = "SeDebugPrivilege";
        public const int SE_PRIVILEGE_ENABLED = 0x0002;

        public enum TOKEN_INFORMATION_CLASS : int
        {
            TokenUser = 1,
            TokenGroups,
            TokenPrivileges,
            TokenOwner,
            TokenPrimaryGroup,
            TokenDefaultDacl,
            TokenSource,
            TokenType,
            TokenImpersonationLevel,
            TokenStatistics,
            TokenRestrictedSids,
            TokenSessionId,
            TokenGroupsAndPrivileges,
            TokenSessionReference,
            TokenSandBoxInert,
            TokenAuditPolicy,
            TokenOrigin,
            MaxTokenInfoClass
        }

        [Flags]
        enum CreateProcessFlags : uint
        {
            CREATE_NEW_CONSOLE = 0x00000010,
            INHERIT_CALLER_PRIORITY = 0x00020000,
        }

        public struct TOKEN_PRIVILEGES
        {
            public int PrivilegeCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public LUID_AND_ATTRIBUTES[] Privileges;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SECURITY_ATTRIBUTES
        {
            public int nLength;
            public IntPtr lpSecurityDescriptor;
            public int bInheritHandle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct STARTUPINFO
        {
            public int cb;
            public String lpReserved;
            public String lpDesktop;
            public String lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;
            public uint dwYSize;
            public uint dwXCountChars;
            public uint dwYCountChars;
            public uint dwFillAttribute;
            public uint dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public uint dwProcessId;
            public uint dwThreadId;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct LUID
        {
            public int LowPart;
            public int HighPart;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct PROCESSENTRY32
        {
            public uint dwSize;
            public uint cntUsage;
            public uint th32ProcessID;
            public IntPtr th32DefaultHeapID;
            public uint th32ModuleID;
            public uint cntThreads;
            public uint th32ParentProcessID;
            public int pcPriClassBase;
            public uint dwFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szExeFile;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct LUID_AND_ATTRIBUTES
        {
            public LUID Luid;
            public UInt32 Attributes;
        }
        
        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool LookupPrivilegeValue(IntPtr lpSystemName, string lpname, [MarshalAs(UnmanagedType.Struct)] ref LUID lpLuid);

        [DllImport(
            "advapi32.dll",
            EntryPoint = "CreateProcessAsUser",
            SetLastError = true,
            CharSet = CharSet.Ansi,
            CallingConvention = CallingConvention.StdCall
        )]
        public extern static bool CreateProcessAsUser(
            IntPtr hToken,
            String lpApplicationName,
            String lpCommandLine,
            ref SECURITY_ATTRIBUTES lpProcessAttributes,
            ref SECURITY_ATTRIBUTES lpThreadAttributes,
            bool bInheritHandle,
            int dwCreationFlags,
            IntPtr lpEnvironment,
            String lpCurrentDirectory,
            ref STARTUPINFO lpStartupInfo,
            out PROCESS_INFORMATION lpProcessInformation
        );

        [DllImport("advapi32.dll", EntryPoint = "DuplicateTokenEx")]
        public extern static bool DuplicateTokenEx(
            IntPtr ExistingTokenHandle,
            uint dwDesiredAccess,
            ref SECURITY_ATTRIBUTES lpThreadAttributes,
            int TokenType,
            int ImpersonationLevel,
            ref IntPtr DuplicateTokenHandle
        );

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool OpenProcessToken(IntPtr ProcessHandle, UInt32 DesiredAccess, out IntPtr TokenHandle);

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool AdjustTokenPrivileges(
            IntPtr TokenHandle,
            bool DisableAllPrivileges,
            ref TOKEN_PRIVILEGES NewState,
            int BufferLength,
            IntPtr PreviousState,
            IntPtr ReturnLength
        );

        public static Process StartProcess(String CommandLine)
        {
            //Get winlogon.exe process object.
            Process winLogon = null;
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.Contains("winlogon"))
                {
                    winLogon = p;
                    break;
                }
            }
            //Get the token from the winlogon.exe process.
            IntPtr userToken = IntPtr.Zero;
            OpenProcessToken(winLogon.Handle, TOKEN_QUERY | TOKEN_IMPERSONATE | TOKEN_DUPLICATE, out userToken);
            //Create a new token.
            IntPtr newToken = IntPtr.Zero;
            SECURITY_ATTRIBUTES tokenAttributes = new SECURITY_ATTRIBUTES();
            tokenAttributes.nLength = Marshal.SizeOf(tokenAttributes);
            SECURITY_ATTRIBUTES threadAttributes = new SECURITY_ATTRIBUTES();
            threadAttributes.nLength = Marshal.SizeOf(threadAttributes);
            //Copy the winlogon token to the new token.
            DuplicateTokenEx(userToken, 0x10000000, ref tokenAttributes, 2, 2, ref newToken);
            TOKEN_PRIVILEGES tokPrivs = new TOKEN_PRIVILEGES();
            tokPrivs.PrivilegeCount = 1;
            LUID seDebugNameValue = new LUID();
            LookupPrivilegeValue(IntPtr.Zero, SE_DEBUG_NAME, ref seDebugNameValue);
            tokPrivs.Privileges = new LUID_AND_ATTRIBUTES[1];
            tokPrivs.Privileges[0].Luid = seDebugNameValue;
            tokPrivs.Privileges[0].Attributes = SE_PRIVILEGE_ENABLED;
            //Escalate the new token's privileges.
            AdjustTokenPrivileges(newToken, false, ref tokPrivs, 0, IntPtr.Zero, IntPtr.Zero);
            PROCESS_INFORMATION pi = new PROCESS_INFORMATION();
            STARTUPINFO si = new STARTUPINFO();
            si.cb = Marshal.SizeOf(si);
            si.lpDesktop = @"winsta0\winlogon";
            //Start the process using the new token.
            CreateProcessAsUser(
                newToken,
                null,
                CommandLine,
                ref tokenAttributes,
                ref threadAttributes,
                true,
                (int)CreateProcessFlags.CREATE_NEW_CONSOLE | (int)CreateProcessFlags.INHERIT_CALLER_PRIORITY,
                IntPtr.Zero,
                null,
                ref si,
                out pi
            );
            return Process.GetProcessById((int)pi.dwProcessId);
        }
    }
}