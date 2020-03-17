namespace EncryptTextEditor
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemOpenInExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.textArea = new System.Windows.Forms.TextBox();
            this.menuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDefaultFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDefaultTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuFormat,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(852, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemOpen,
            this.menuItemSave,
            this.menuItemSaveAs,
            this.toolStripSeparator1,
            this.menuItemOpenInExplorer,
            this.toolStripSeparator2,
            this.menuItemExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(58, 21);
            this.menuFile.Text = "文件(F)";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemNew.Size = new System.Drawing.Size(206, 22);
            this.menuItemNew.Text = "新建(N)";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemOpen.Size = new System.Drawing.Size(206, 22);
            this.menuItemOpen.Text = "打开(O)";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSave.Size = new System.Drawing.Size(206, 22);
            this.menuItemSave.Text = "保存(S)";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.Name = "menuItemSaveAs";
            this.menuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuItemSaveAs.Size = new System.Drawing.Size(206, 22);
            this.menuItemSaveAs.Text = "另存为(A)";
            this.menuItemSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // menuItemOpenInExplorer
            // 
            this.menuItemOpenInExplorer.Name = "menuItemOpenInExplorer";
            this.menuItemOpenInExplorer.Size = new System.Drawing.Size(206, 22);
            this.menuItemOpenInExplorer.Text = "打开文件位置";
            this.menuItemOpenInExplorer.Click += new System.EventHandler(this.menuItemOpenInExplorer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(206, 22);
            this.menuItemExit.Text = "退出(X)";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(61, 21);
            this.menuHelp.Text = "帮助(H)";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(152, 22);
            this.menuItemAbout.Text = "关于(A)";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelStatus,
            this.statusLabelCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(852, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabelStatus
            // 
            this.statusLabelStatus.Name = "statusLabelStatus";
            this.statusLabelStatus.Size = new System.Drawing.Size(32, 17);
            this.statusLabelStatus.Text = "就绪";
            // 
            // statusLabelCount
            // 
            this.statusLabelCount.Name = "statusLabelCount";
            this.statusLabelCount.Size = new System.Drawing.Size(65, 17);
            this.statusLabelCount.Text = "0/512字符";
            // 
            // textArea
            // 
            this.textArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textArea.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textArea.Location = new System.Drawing.Point(0, 25);
            this.textArea.Margin = new System.Windows.Forms.Padding(0);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textArea.Size = new System.Drawing.Size(852, 507);
            this.textArea.TabIndex = 2;
            this.textArea.WordWrap = false;
            this.textArea.TextChanged += new System.EventHandler(this.textArea_TextChanged);
            // 
            // menuFormat
            // 
            this.menuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFont,
            this.menuItemTheme,
            this.toolStripSeparator3,
            this.menuItemDefault});
            this.menuFormat.Name = "menuFormat";
            this.menuFormat.Size = new System.Drawing.Size(62, 21);
            this.menuFormat.Text = "格式(O)";
            // 
            // menuItemFont
            // 
            this.menuItemFont.Name = "menuItemFont";
            this.menuItemFont.Size = new System.Drawing.Size(152, 22);
            this.menuItemFont.Text = "字体(F)";
            this.menuItemFont.Click += new System.EventHandler(this.menuItemFont_Click);
            // 
            // menuItemTheme
            // 
            this.menuItemTheme.Name = "menuItemTheme";
            this.menuItemTheme.Size = new System.Drawing.Size(152, 22);
            this.menuItemTheme.Text = "主题(T)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // menuItemDefault
            // 
            this.menuItemDefault.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDefaultFont,
            this.menuItemDefaultTheme});
            this.menuItemDefault.Name = "menuItemDefault";
            this.menuItemDefault.Size = new System.Drawing.Size(152, 22);
            this.menuItemDefault.Text = "恢复默认";
            // 
            // menuItemDefaultFont
            // 
            this.menuItemDefaultFont.Name = "menuItemDefaultFont";
            this.menuItemDefaultFont.Size = new System.Drawing.Size(152, 22);
            this.menuItemDefaultFont.Text = "默认字体";
            this.menuItemDefaultFont.Click += new System.EventHandler(this.menuItemDefaultFont_Click);
            // 
            // menuItemDefaultTheme
            // 
            this.menuItemDefaultTheme.Name = "menuItemDefaultTheme";
            this.menuItemDefaultTheme.Size = new System.Drawing.Size(152, 22);
            this.menuItemDefaultTheme.Text = "默认主题";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 554);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "无标题 - EncryptTextEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelCount;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenInExplorer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFormat;
        private System.Windows.Forms.ToolStripMenuItem menuItemFont;
        private System.Windows.Forms.ToolStripMenuItem menuItemTheme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItemDefault;
        private System.Windows.Forms.ToolStripMenuItem menuItemDefaultFont;
        private System.Windows.Forms.ToolStripMenuItem menuItemDefaultTheme;
    }
}

