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

        public DisplayForm()
        {
            InitializeComponent();
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
        }
    }
}
