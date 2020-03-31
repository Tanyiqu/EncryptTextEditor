using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EncryptTextEditor.Forms.Dialogs;
using EncryptTextEditor.Utils;
using EncryptTextEditor.MyExceptions;

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

        //加载
        private void SettingForm_Load(object sender, EventArgs e)
        {
            //加载两个颜色框
            pictureBoxForeColor.BackColor = config.foreColor;
            pictureBoxBackColor.BackColor = config.backColor;
            //加载预览文字
            txtPreview.Font = config.font;
            txtPreview.ForeColor = config.foreColor;
            txtPreview.BackColor = config.backColor;

            int n = 1;
            //加载扩展名
            foreach (Configuration.Extension ext in config.extensions)
            {
                int index = this.tableExts.Rows.Add();
                tableExts.Rows[index].Cells[0].Value = ext.name;
                tableExts.Rows[index].Cells[1].Value = ext.desc;
                tableExts.Rows[index].HeaderCell.Value = n.ToString();//添加行号
                n++;
            }
            
            
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
            Console.WriteLine("点击 确定");
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
                FileUtil.writeConfigXmlNode(new string[] { "style", "foreColor" }, "#" + rgbFore.ToString("X6"));
                FileUtil.writeConfigXmlNode(new string[] { "style", "backColor" }, "#" + rgbBack.ToString("X6"));
            }
            catch (WriteXmlException e1)
            {
                Console.WriteLine("保存颜色时写入Xml失败");
                Console.WriteLine(e1.Message);
            }
            this.Close();
        }

        //添加扩展名
        private void linkAddExt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddExtDialog dialog = new AddExtDialog();
            DialogResult rc = dialog.ShowDialog(this);
            if (rc == DialogResult.OK)
            {
                string name = dialog.name;
                string desc = dialog.desc;
                Console.WriteLine(name + " " + desc);
                //添加到表格中
                int index = this.tableExts.Rows.Add();
                tableExts.Rows[index].Cells[0].Value = name;
                tableExts.Rows[index].Cells[1].Value = desc;
                tableExts.Rows[index].HeaderCell.Value = (index+1).ToString();//添加行号
                tableExts.ClearSelection();
                tableExts.Rows[index].Cells[0].Selected = true;
                //添加到config.xml中
                try
                {
                    FileUtil.addConfigXml_Extensions(name, desc);
                }
                catch (AddXmlException e1)
                {
                    Console.WriteLine("添加扩展名时写入Xml失败");
                    Console.WriteLine(e1.Message);
                }
            }
            dialog.Dispose();
        }

  
    }
}
