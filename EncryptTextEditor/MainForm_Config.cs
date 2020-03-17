using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*****************************************
把加载配置的部分单独写进一个文件里面
*****************************************/

namespace EncryptTextEditor
{
    public partial class MainForm : Form
    {
        private void loadConf()
        {
            Console.WriteLine("加载配置");

            //窗口大小
            this.Size = new Size(config.width, config.height);
            //窗口位置
            this.Location = new Point(config.x, config.y);



        }
    }
}
