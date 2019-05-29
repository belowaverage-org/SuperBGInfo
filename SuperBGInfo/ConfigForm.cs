using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBGInfo
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void LayoutImg_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(imgLayout.BackColor);
            Bitmap layout = Properties.Resources.layout;
            layout.MakeTransparent(Color.White);
            e.Graphics.DrawImage(layout, 0, 0, layout.Width, layout.Height);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
