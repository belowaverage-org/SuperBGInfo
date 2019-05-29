namespace SuperBGInfo
{
    partial class DisplayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DisplayText
            // 
            this.DisplayText.BackColor = System.Drawing.Color.Black;
            this.DisplayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayText.DetectUrls = false;
            this.DisplayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayText.ForeColor = System.Drawing.Color.White;
            this.DisplayText.Location = new System.Drawing.Point(0, 0);
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.ReadOnly = true;
            this.DisplayText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.DisplayText.Size = new System.Drawing.Size(818, 392);
            this.DisplayText.TabIndex = 0;
            this.DisplayText.Text = "Test123";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(818, 392);
            this.ControlBox = false;
            this.Controls.Add(this.DisplayText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SuperBGInfo";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox DisplayText;
    }
}

