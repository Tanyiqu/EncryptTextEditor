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
        bool modified = false;  //文本是否被改动过，在关闭窗口时用到
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
                MessageBox.Show("字符数已超过" + warning + "！\n文字过多可能影响保存效率！", Utils.APP_NAME + "：警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                warning *= 2;
                statusLabelCount.Text = wordCount + "/" + warning + "字符";
            }
        }

        //新建（Ctrl + N）
        private void menuItemNew_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ctrl + N");
            //1.有改动（未保存）
            //2.没有改动（已保存 或 新打开的窗口）

            if (modified)//有改动
            {
                //保存或另存为后，再新建
                DialogResult result = MessageBox.Show("你想保存更改吗？", Utils.APP_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                //是：保存或另存为后新建
                if (result == DialogResult.Yes)
                {
                    Console.WriteLine("是");
                    //保存成功正常关闭
                    menuItemSave_Click(null, null);
                    //如果未保存成功，暂时取消新建
                    if (!saveFlag)//此处不做提示信息，因为menuItemSave_Click中已经做了提示
                    {
                        return;
                    }
                }
                //否：不保存，新建
                else if (result == DialogResult.No)
                {
                    Console.WriteLine("否");
                }
                //取消：不保存，取消新建
                else
                {
                    Console.WriteLine("取消");
                    return;
                }
            }
            //没有改动就直接新建，覆盖当前窗口
            openingFile = false;
            filePath = null;
            warning = 512;
            wordCount = 0;

            this.textArea.Clear();
            this.Text = "无标题 - " + Utils.APP_NAME;
            this.statusLabelStatus.Text = "就绪";
            this.statusLabelCount.Text = "0/512字符";

            modified = false;
        }

        //保存（Ctrl + S）
        private void menuItemSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ctrl + S");
            //如果有已经打开的文件，就保存到该文件中
            //如果没有打开的文件，就另存为
            //保存
            if (openingFile)
            {
                Console.WriteLine("保存");
                saveFlag = Utils.saveFile(textArea.Text, filePath);
                if (!saveFlag)//保存失败
                {
                    MessageBox.Show("文件保存错误！请尽快备份内容！\n", Utils.APP_NAME + "：错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            //另存为
            else
            {
                Console.WriteLine("另存为");
                //当前肯定没有打开文件，所以为false
                saveFlag = Utils.saveAsFile(textArea.Text, false, ref filePath);

                if (!saveFlag)//保存失败
                {
                    MessageBox.Show("未保存成功！请尽快备份内容！\n", Utils.APP_NAME + "：警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //保存成功
                openingFile = true;
                this.Text = Path.GetFileName(filePath) + " - " + Utils.APP_NAME;
            }

            //执行到这里肯定保存成功了
            //如果标题有“*”就去掉它
            if (this.Text[0] == '*')
            {
                this.Text = this.Text.Substring(1, this.Text.Length - 1);
            }
            ////已经改动置为false
            modified = false;
            statusLabelStatus.Text = "已保存";
        }

        //另存为（Ctrl + Shift + S）
        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ctrl + Shift + S");
            saveFlag = Utils.saveAsFile(textArea.Text, openingFile, ref filePath);
            if (!saveFlag)//保存失败
            {
                MessageBox.Show("未保存成功！请尽快备份内容！\n", Utils.APP_NAME + "：警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //保存完成，此时一定有已经打开的文件
            openingFile = true;
            //修改标题名
            this.Text = Path.GetFileName(filePath) + " - " + Utils.APP_NAME;
            modified = false;
            statusLabelStatus.Text = "已保存";
        }

        //点击关闭（X）
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            //调用close关闭，关闭时的保存操作在closing中实现
            this.Close();
        }

        //即将关闭
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //如果没有改动，直接关闭
            if (!modified)
            {
                Console.WriteLine("无改动，直接关闭！");
                return;
            }
            //有改动，分3种情况
            Console.WriteLine("有改动");

            DialogResult result = MessageBox.Show("你想保存更改吗？", Utils.APP_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            //是：保存或另存为后关闭
            if (result == DialogResult.Yes)
            {
                Console.WriteLine("是");
                //保存成功正常关闭
                menuItemSave_Click(null, null);
                //保存正常
                if (saveFlag)
                {
                    return;
                }
                //保存失败暂时不关闭
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
            //否：不保存，关闭
            else if (result == DialogResult.No)
            {
                Console.WriteLine("否");
                return;
            }
            //取消：不保存，取消关闭
            else
            {
                Console.WriteLine("取消");
                e.Cancel = true;
            }
        }


    }
}
