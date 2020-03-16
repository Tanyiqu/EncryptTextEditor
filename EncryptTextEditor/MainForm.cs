using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EncryptTextEditor
{
    public partial class MainForm : Form
    {
        string[] args;          //参数
        string filePath;        //打开的文件路径
        bool modified = false;  //文本是否被改动过
        bool openingFile = false;   //是否正在打开文件
        int wordCount = 0;      //文本区域的字数
        int warning = 512;      //字符数超过限制后的提醒
        bool saveFlag = false;  //保存情况

        public MainForm(string[] args)
        {
            InitializeComponent();
            this.args = args;
        }

        //加载窗口，并判断是否有携带参数
        private void MainForm_Load(object sender, EventArgs e)
        {
            //判断参数
            if (args.Length == 0)
            {
                Console.WriteLine("没有携带参数");
                //正常显示
                openingFile = false;
                filePath = null;

            }
            else if (args.Length == 1)
            {
                Console.WriteLine("携带1个参数");
                filePath = args[0];
                openingFile = true;
                Console.WriteLine("打开文件：[" + filePath + "]");
                
                //改变标题
                this.Text = Path.GetFileName(filePath) + " - " + Utils.APP_NAME;
                //打开文件

            }
            else
            {
                Console.WriteLine("携带多个参数");
                //发出警告
                MessageBox.Show("请不要在一个窗口中打开多个文件！", "EncryptTextEditor：错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //强制关闭程序
                System.Environment.Exit(0);
            }
        }

        //保存（Ctrl+S）
        private void menuItemSave_Click(object sender, EventArgs e)
        {
            //如果有已经打开的文件，就保存到该文件中
            //如果没有打开的文件，就另存为
            //保存
            if(openingFile)
            {
                Console.WriteLine("保存");
                saveFlag = Utils.saveFile(textArea.Text,filePath);
                if(!saveFlag)//保存失败
                {
                    MessageBox.Show("文件保存错误！请尽快备份内容！\n", "EncryptTextManager：错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            //另存为
            else
            {
                Console.WriteLine("另存为");
                //当前肯定没有打开文件，所以为false
                saveFlag = Utils.saveAsFile(textArea.Text, false, ref filePath);

                if(!saveFlag)//保存失败
                {
                    MessageBox.Show("未保存成功！请尽快备份内容！\n", "EncryptTextManager：警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //保存成功
                openingFile = true;
                this.Text = Path.GetFileName(filePath) + " - " + Utils.APP_NAME;
            }

            //执行到这里肯定保存成功了
            //如果标题有“*”就去掉它
            if(this.Text[0] == '*')
            {
                this.Text = this.Text.Substring(1, this.Text.Length-1);
            }
            ////已经改动置为false
            //modified = false;
            statusLabelStatus.Text = "已保存";
        }

        //文本区域文本改动
        private void textArea_TextChanged(object sender, EventArgs e)
        {
            //如果文本有改动，就记录下来，并且窗口标题加“*”
            if (modified) ;
            else
            {
                modified = true;
                this.Text = "*" + this.Text;
                statusLabelStatus.Text = "未保存";
            }

            //统计字数
            this.wordCount = textArea.Text.Length;
            statusLabelCount.Text = wordCount + "/" + warning + "字符";

            //字符数过多的提醒
            if (wordCount > warning)
            {
                MessageBox.Show("字符数已超过" + warning + "！\n文字过多可能影响保存效率！", "EncryptTextManager：警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                warning *= 2;
                statusLabelCount.Text = wordCount + "/" + warning + "字符";
            }
        }

        //另存为（Ctrl + Shift + S）
        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            saveFlag = Utils.saveAsFile(textArea.Text, openingFile, ref filePath);
            if (!saveFlag)//保存失败
            {
                MessageBox.Show("未保存成功！请尽快备份内容！\n", "EncryptTextManager：警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //保存完成，此时一定有已经打开的文件
            openingFile = true;
            //修改标题名
            this.Text = Path.GetFileName(filePath) + " - " + Utils.APP_NAME;

            statusLabelStatus.Text = "已保存";
        }

    }
}
