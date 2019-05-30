using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SuperBGInfo
{
    public partial class DisplayForm : Form
    {
        const int GWL_EXSTYLE = -20;
        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TRANSPARENT = 0x20;
        const int WS_EX_TOOLWINDOW = 0x80;

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public Timer topTimer = new Timer();

        public int originalStyle = 0;

        private string templateRtf = "";
        public string TemplateRtf
        {
            get
            {
                return templateRtf;
            }
            set
            {
                templateRtf = value;
                DisplayRedraw();
            }
        }

        public DisplayForm()
        {
            InitializeComponent();
        }

        public void DisplayRedraw()
        {
            string rtf = TemplateRtf;
            string[] variables = ReadVariables(rtf);

            foreach(string variable in variables)
            {
                if(variable == "UserName")
                {
                    rtf = rtf.Replace("<UserName>", Environment.UserName);
                }
            }

            DisplayText.Rtf = rtf;
        }

        private string[] ReadVariables(string str)
        {
            List<string> variables = new List<string>();
            bool read = false;
            string buffer = "";
            foreach (char character in str)
            {
                if (character == '<')
                {
                    read = true;
                    continue;
                }
                if (character == '>')
                {
                    variables.Add(buffer);
                    buffer = "";
                    read = false;
                    continue;
                }
                if (read)
                {
                    buffer += character;
                }
            }
            return variables.ToArray();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            originalStyle = GetWindowLong(Handle, GWL_EXSTYLE);
            originalStyle = originalStyle | WS_EX_LAYERED | WS_EX_TRANSPARENT;
            SetWindowLong(Handle, GWL_EXSTYLE, originalStyle | WS_EX_TOOLWINDOW);
            foreach (string arg in Program.Arguments)
            {
                if (arg == "top")
                {
                    TopMost = true;
                    continue;
                }
                if (arg == "showform")
                {
                    SetWindowLong(Handle, GWL_EXSTYLE, originalStyle);
                    continue;
                }
            }
            if(TopMost)
            {
                topTimer.Interval = 1000;
                topTimer.Tick += TopTimer_Tick;
                topTimer.Start();
            }
            
        }
        private void TopTimer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
