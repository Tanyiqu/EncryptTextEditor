namespace EncryptTextEditor.Forms
{
    partial class SettingForm
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
            this.tabAdvance = new System.Windows.Forms.TabPage();
            this.groupBoxExtensions = new System.Windows.Forms.GroupBox();
            this.linkAddExt = new System.Windows.Forms.LinkLabel();
            this.tableExts = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNormal = new System.Windows.Forms.TabPage();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.pictureBoxBackColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxForeColor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConform = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabAdvance.SuspendLayout();
            this.groupBoxExtensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableExts)).BeginInit();
            this.tabNormal.SuspendLayout();
            this.groupBoxStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForeColor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdvance
            // 
            this.tabAdvance.Controls.Add(this.groupBoxExtensions);
            this.tabAdvance.Location = new System.Drawing.Point(4, 22);
            this.tabAdvance.Name = "tabAdvance";
            this.tabAdvance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvance.Size = new System.Drawing.Size(378, 391);
            this.tabAdvance.TabIndex = 1;
            this.tabAdvance.Text = "高级";
            this.tabAdvance.UseVisualStyleBackColor = true;
            // 
            // groupBoxExtensions
            // 
            this.groupBoxExtensions.Controls.Add(this.linkAddExt);
            this.groupBoxExtensions.Controls.Add(this.tableExts);
            this.groupBoxExtensions.Location = new System.Drawing.Point(6, 6);
            this.groupBoxExtensions.Name = "groupBoxExtensions";
            this.groupBoxExtensions.Size = new System.Drawing.Size(366, 141);
            this.groupBoxExtensions.TabIndex = 0;
            this.groupBoxExtensions.TabStop = false;
            this.groupBoxExtensions.Text = "扩展名";
            // 
            // linkAddExt
            // 
            this.linkAddExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkAddExt.AutoSize = true;
            this.linkAddExt.Location = new System.Drawing.Point(325, 120);
            this.linkAddExt.Name = "linkAddExt";
            this.linkAddExt.Size = new System.Drawing.Size(35, 12);
            this.linkAddExt.TabIndex = 0;
            this.linkAddExt.TabStop = true;
            this.linkAddExt.Text = "添加+";
            this.linkAddExt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddExt_LinkClicked);
            // 
            // tableExts
            // 
            this.tableExts.AllowUserToAddRows = false;
            this.tableExts.AllowUserToDeleteRows = false;
            this.tableExts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableExts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableExts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableExts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableExts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.desc});
            this.tableExts.Location = new System.Drawing.Point(6, 20);
            this.tableExts.Name = "tableExts";
            this.tableExts.ReadOnly = true;
            this.tableExts.RowTemplate.Height = 23;
            this.tableExts.Size = new System.Drawing.Size(354, 97);
            this.tableExts.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "扩展名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // desc
            // 
            this.desc.HeaderText = "描述";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabNormal
            // 
            this.tabNormal.Controls.Add(this.groupBoxStyle);
            this.tabNormal.Controls.Add(this.groupBox1);
            this.tabNormal.Controls.Add(this.btnReset);
            this.tabNormal.Controls.Add(this.btnCancel);
            this.tabNormal.Controls.Add(this.btnConform);
            this.tabNormal.Location = new System.Drawing.Point(4, 22);
            this.tabNormal.Name = "tabNormal";
            this.tabNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabNormal.Size = new System.Drawing.Size(378, 391);
            this.tabNormal.TabIndex = 0;
            this.tabNormal.Text = "常规";
            this.tabNormal.UseVisualStyleBackColor = true;
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.Controls.Add(this.txtPreview);
            this.groupBoxStyle.Controls.Add(this.pictureBoxBackColor);
            this.groupBoxStyle.Controls.Add(this.pictureBoxForeColor);
            this.groupBoxStyle.Controls.Add(this.label2);
            this.groupBoxStyle.Controls.Add(this.label3);
            this.groupBoxStyle.Controls.Add(this.label1);
            this.groupBoxStyle.Location = new System.Drawing.Point(12, 6);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(355, 85);
            this.groupBoxStyle.TabIndex = 2;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "主题样式";
            // 
            // txtPreview
            // 
            this.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreview.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPreview.Location = new System.Drawing.Point(163, 20);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(177, 50);
            this.txtPreview.TabIndex = 3;
            this.txtPreview.Text = "加密文本编辑器";
            // 
            // pictureBoxBackColor
            // 
            this.pictureBoxBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBackColor.Location = new System.Drawing.Point(76, 48);
            this.pictureBoxBackColor.Name = "pictureBoxBackColor";
            this.pictureBoxBackColor.Size = new System.Drawing.Size(21, 22);
            this.pictureBoxBackColor.TabIndex = 2;
            this.pictureBoxBackColor.TabStop = false;
            this.pictureBoxBackColor.Click += new System.EventHandler(this.pictureBoxBackColor_Click);
            // 
            // pictureBoxForeColor
            // 
            this.pictureBoxForeColor.BackColor = System.Drawing.Color.Black;
            this.pictureBoxForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxForeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxForeColor.Location = new System.Drawing.Point(76, 20);
            this.pictureBoxForeColor.Name = "pictureBoxForeColor";
            this.pictureBoxForeColor.Size = new System.Drawing.Size(21, 22);
            this.pictureBoxForeColor.TabIndex = 2;
            this.pictureBoxForeColor.TabStop = false;
            this.pictureBoxForeColor.Click += new System.EventHandler(this.pictureBoxForeColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "背景颜色：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "预览：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "字体颜色：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "警告框";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(12, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(168, 16);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "字数过多时显示警告对话框";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "另存为取消时显示警告对话框";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(130, 357);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "恢复默认";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(211, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConform
            // 
            this.btnConform.Location = new System.Drawing.Point(292, 357);
            this.btnConform.Name = "btnConform";
            this.btnConform.Size = new System.Drawing.Size(75, 23);
            this.btnConform.TabIndex = 1;
            this.btnConform.Text = "确定";
            this.btnConform.UseVisualStyleBackColor = true;
            this.btnConform.Click += new System.EventHandler(this.btnConform_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabNormal);
            this.tabControl.Controls.Add(this.tabAdvance);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(386, 417);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(378, 391);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "关于";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 437);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 476);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 476);
            this.Name = "SettingForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "首选项";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.tabAdvance.ResumeLayout(false);
            this.groupBoxExtensions.ResumeLayout(false);
            this.groupBoxExtensions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableExts)).EndInit();
            this.tabNormal.ResumeLayout(false);
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForeColor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAdvance;
        private System.Windows.Forms.TabPage tabNormal;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConform;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBackColor;
        private System.Windows.Forms.PictureBox pictureBoxForeColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBoxExtensions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.LinkLabel linkAddExt;
        private System.Windows.Forms.DataGridView tableExts;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;


    }
}