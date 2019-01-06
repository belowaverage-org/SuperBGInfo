namespace SuperBGInfo
{
    partial class BuildForm
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
            this.editorRTB = new System.Windows.Forms.RichTextBox();
            this.varList = new System.Windows.Forms.ListBox();
            this.prevBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.fontBtn = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // editorRTB
            // 
            this.editorRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorRTB.BackColor = System.Drawing.Color.Black;
            this.editorRTB.DetectUrls = false;
            this.editorRTB.ForeColor = System.Drawing.Color.White;
            this.editorRTB.Location = new System.Drawing.Point(0, 0);
            this.editorRTB.Margin = new System.Windows.Forms.Padding(0);
            this.editorRTB.Name = "editorRTB";
            this.editorRTB.ShowSelectionMargin = true;
            this.editorRTB.Size = new System.Drawing.Size(581, 450);
            this.editorRTB.TabIndex = 0;
            this.editorRTB.Text = "";
            // 
            // varList
            // 
            this.varList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.varList.FormattingEnabled = true;
            this.varList.HorizontalScrollbar = true;
            this.varList.IntegralHeight = false;
            this.varList.ItemHeight = 16;
            this.varList.Items.AddRange(new object[] {
            "<BIOSMode>",
            "<BIOSVersion>",
            "<ComputerMake>",
            "<ComputerModel>",
            "<ComputerName>",
            "<ComputerSKU>",
            "<CPU>",
            "<CPUArchitecture>",
            "<CPUCores>",
            "<CPUUsage>",
            "<CurrentWirelessSSID AdapterName=\"\">",
            "<Date>",
            "<DiskPerformanceUsage>",
            "<DiskSpaceUsage Letter=\"\">",
            "<Domain>",
            "<DomainController>",
            "<DomainNetBios>",
            "<DomainSite>",
            "<IPAddress AdapterName=\"\">",
            "<LoggedOnUsers>",
            "<MACAddress AdapterName=\"\">",
            "<MemoryUsage>",
            "<NetworkAdapterStatus AdapterName=\"\">",
            "<OnlineStatus Host=\"\">",
            "<RegistryValue Path=\"\">",
            "<ServiceStatus ServiceName=\"\">",
            "<Time>",
            "<TotalMemory>",
            "<UpTime>",
            "<UserDomain>",
            "<UserName>",
            "<WindowsBootTime>",
            "<WindowsInstallDate>",
            "<WindowsMajorVersion>",
            "<WindowsMinorVersion>"});
            this.varList.Location = new System.Drawing.Point(584, 33);
            this.varList.Name = "varList";
            this.varList.Size = new System.Drawing.Size(245, 417);
            this.varList.Sorted = true;
            this.varList.TabIndex = 1;
            this.varList.DoubleClick += new System.EventHandler(this.varList_DoubleClick);
            // 
            // prevBtn
            // 
            this.prevBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prevBtn.Location = new System.Drawing.Point(665, 0);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(80, 31);
            this.prevBtn.TabIndex = 2;
            this.prevBtn.Text = "Preview";
            this.prevBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveBtn.Location = new System.Drawing.Point(746, 0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 31);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // fontBtn
            // 
            this.fontBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fontBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fontBtn.Location = new System.Drawing.Point(584, 0);
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(80, 31);
            this.fontBtn.TabIndex = 4;
            this.fontBtn.Text = "Font";
            this.fontBtn.UseVisualStyleBackColor = false;
            this.fontBtn.Click += new System.EventHandler(this.fontBtn_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.AllowScriptChange = false;
            this.fontDialog.AllowVerticalFonts = false;
            this.fontDialog.Color = System.Drawing.Color.White;
            this.fontDialog.FontMustExist = true;
            this.fontDialog.ShowColor = true;
            // 
            // BuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.fontBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.varList);
            this.Controls.Add(this.editorRTB);
            this.Name = "BuildForm";
            this.Text = "SuperBGInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox editorRTB;
        private System.Windows.Forms.ListBox varList;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button fontBtn;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}