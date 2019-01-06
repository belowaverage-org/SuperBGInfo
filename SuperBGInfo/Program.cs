using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBGInfo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static string[] Arguments = null;

        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Arguments = args;
            if (args.Length > 0 && args[0] == "securedesktop")
            {
                Process sDesktopProcess = BelowAverage.SecureDesktop.StartProcess(Application.ExecutablePath + " top");
                ChildProcessTracker.AddProcess(sDesktopProcess);
                sDesktopProcess.WaitForExit();
            }
            else
            {
                //Application.Run(new DisplayForm());
                Application.Run(new BuildForm());
            }
        }
    }
}
