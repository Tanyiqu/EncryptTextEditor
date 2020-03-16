using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace EncryptTextEditor
{
    public static class Utils
    {

        public static string APP_NAME = "EncryptTextEditor";

        //仅保存文本到指定路径
        //返回保存是否成功
        public static bool saveFile(string text, string path)
        {
            //加密此文本
            byte[] arr = Utils.encode(text);
            //尝试保存文件
            try
            {
                BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Create));
                bw.Write(arr);
                bw.Close();
                return true;
            }
            catch (IOException e1)
            {
                Console.WriteLine(e1.Message);
                return false;
            }
        }

        //另存为
        //1.有已经打开的文件，另存为后已经打开的路径不变
        //2.没有打开的文件，另存为后，文件路径改为该路径
        //返回是否保存成功
        public static bool saveAsFile(string text,bool openingFile,ref string filePath)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "另存为";
            sfd.Filter = "加密文本文件|*.ept|账户文件|*.act";
            sfd.ShowDialog();
            string tempPath = sfd.FileName;

            //没有已经打开的文件
            if(!openingFile)
            {
                //将打开的文件路径置为刚刚的路径
                filePath = tempPath;
            }
            //有已经打开的文件 不用管
            
            //如果没有选择路径
            if(tempPath.Equals(""))
            {
                MessageBox.Show("请选择保存路径！", "EncryptTextManager：警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return saveFile(text,tempPath);
        }


        /// <summary>
        /// 字符串加密成字节数组
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] encode(string text)
        {
            byte[] arr = System.Text.Encoding.Default.GetBytes(text);
            byte[] arr2 = new byte[arr.Length];
            byte k = 0x55;
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = (byte)(arr[i] ^ k);
            }
            return arr2;
        }
    }
}
