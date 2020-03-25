using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EncryptTextEditor.Forms;

namespace EncryptTextEditor
{
    static class Program
    {
        public static string APP_NAME = "EncryptTextEditor";            //程序名
        public static string START_PATH = Application.StartupPath;      //exe文件的路径，用于结对定位data文件路径
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //打印可执行文件的路径
            Console.WriteLine("可执行文件路径：" + START_PATH);

            Application.Run(new MainForm(args));
        }
    }
}
