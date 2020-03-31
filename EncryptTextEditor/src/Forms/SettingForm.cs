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
        MainForm mainForm = MainForm.getInstance();

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
            this.Close();
        }

        //确定
        private void btnConform_Click(object sender, EventArgs e)
        {
            //应用改动 并 保存到配置文件
            //应用改动是将属性直接写到Config的实例中，然后调用Main的sync同步
            //不需要写入到文件中，再读取

            //应用
            config.foreColor = pictureBoxForeColor.BackColor;
            config.backColor = pictureBoxBackColor.BackColor;
            mainForm.sync();
            //保存到Config.xml
            //保存颜色
            int rgbFore = config.foreColor.ToArgb() & 0xFFFFFF;
            int rgbBack = config.backColor.ToArgb() & 0xFFFFFF;
            try
            {
                FileUtil.writeConfigXml(new string[] { "style", "foreColor" }, "#" + rgbFore.ToString("X6"));
                FileUtil.writeConfigXml(new string[] { "style", "backColor" }, "#" + rgbBack.ToString("X6"));
            }
            catch (EncryptTextEditor.MyExceptions.WriteXmlException e1)
            {
                Console.WriteLine("保存颜色时写入Xml失败");
            }
            this.Close();
        }
    }
}
