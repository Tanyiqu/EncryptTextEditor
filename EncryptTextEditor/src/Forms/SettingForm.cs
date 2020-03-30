using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EncryptTextEditor.Utils;

namespace EncryptTextEditor.Forms
{
    public partial class SettingForm : Form
    {

        Configuration config = Configuration.Instance;

        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            //加载两个颜色框
            pictureBoxForeColor.BackColor = config.foreColor;
            pictureBoxBackColor.BackColor = config.backColor;
            //加载预览文字
            txtPreview.Font = config.font;
            txtPreview.ForeColor = config.foreColor;
            txtPreview.BackColor = config.backColor;            
        }

        //设置字体颜色
        private void pictureBoxForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = config.foreColor;
            cd.ShowDialog();
            //刷新预览
            pictureBoxForeColor.BackColor = cd.Color;
            txtPreview.ForeColor = cd.Color;

            Console.WriteLine(cd.Color);
        }

        //设置背景颜色
        private void pictureBoxBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = config.backColor;
            cd.ShowDialog();
            //刷新预览
            pictureBoxBackColor.BackColor = cd.Color;
            txtPreview.BackColor = cd.Color;

            Console.WriteLine(cd.Color);
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("点击 取消");
        }
    }
}
