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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabNormal = new System.Windows.Forms.TabPage();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.pictureBoxBackColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxForeColor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConform = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabNormal.SuspendLayout();
            this.groupBoxStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForeColor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(378, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabNormal);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(386, 417);
            this.tabControl.TabIndex = 0;
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
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 437);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 476);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 476);
            this.Name = "SettingForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "首选项";
            this.Load += new System.EventHandler(this.SettingForm_Load);
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

        private System.Windows.Forms.TabPage tabPage2;
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


    }
}