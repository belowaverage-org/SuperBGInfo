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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.buttonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editorRTB
            // 
            this.editorRTB.BackColor = System.Drawing.Color.Black;
            this.editorRTB.DetectUrls = false;
            this.editorRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorRTB.ForeColor = System.Drawing.Color.White;
            this.editorRTB.Location = new System.Drawing.Point(0, 0);
            this.editorRTB.Margin = new System.Windows.Forms.Padding(0);
            this.editorRTB.Name = "editorRTB";
            this.editorRTB.ShowSelectionMargin = true;
            this.editorRTB.Size = new System.Drawing.Size(331, 308);
            this.editorRTB.TabIndex = 0;
            this.editorRTB.Text = "";
            this.editorRTB.WordWrap = false;
            // 
            // varList
            // 
            this.varList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.varList.FormattingEnabled = true;
            this.varList.HorizontalScrollbar = true;
            this.varList.IntegralHeight = false;
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
            this.varList.Location = new System.Drawing.Point(0, 35);
            this.varList.Margin = new System.Windows.Forms.Padding(2);
            this.varList.Name = "varList";
            this.varList.Size = new System.Drawing.Size(190, 273);
            this.varList.Sorted = true;
            this.varList.TabIndex = 1;
            this.varList.DoubleClick += new System.EventHandler(this.varList_DoubleClick);
            // 
            // prevBtn
            // 
            this.prevBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prevBtn.Location = new System.Drawing.Point(63, 3);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(60, 29);
            this.prevBtn.TabIndex = 2;
            this.prevBtn.Text = "Preview";
            this.prevBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveBtn.Location = new System.Drawing.Point(126, 3);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(61, 29);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // fontBtn
            // 
            this.fontBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fontBtn.Location = new System.Drawing.Point(0, 3);
            this.fontBtn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(60, 29);
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
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.editorRTB);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.buttonLayoutPanel);
            this.splitContainer.Panel2.Controls.Add(this.varList);
            this.splitContainer.Size = new System.Drawing.Size(525, 308);
            this.splitContainer.SplitterDistance = 331;
            this.splitContainer.TabIndex = 6;
            // 
            // buttonLayoutPanel
            // 
            this.buttonLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLayoutPanel.ColumnCount = 3;
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonLayoutPanel.Controls.Add(this.fontBtn, 0, 0);
            this.buttonLayoutPanel.Controls.Add(this.saveBtn, 2, 0);
            this.buttonLayoutPanel.Controls.Add(this.prevBtn, 1, 0);
            this.buttonLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLayoutPanel.Name = "buttonLayoutPanel";
            this.buttonLayoutPanel.RowCount = 1;
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonLayoutPanel.Size = new System.Drawing.Size(190, 35);
            this.buttonLayoutPanel.TabIndex = 2;
            // 
            // BuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 308);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BuildForm";
            this.Text = "SuperBGInfo";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.buttonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox editorRTB;
        private System.Windows.Forms.ListBox varList;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button fontBtn;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel buttonLayoutPanel;
    }
}