﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EncryptTextEditor
{
    static class Program
    {
        public static string APP_NAME = "EncryptTextEditor";
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(args));
        }
    }
}
