﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using EncryptTextEditor.MyExceptions;

namespace EncryptTextEditor
{
    public static partial class Utils
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

        //读取文件，返回读到的字节数组
        public static byte[] readFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] arr = new byte[fs.Length];
            fs.Read(arr, 0, (int)fs.Length);
            fs.Close();
            return arr;
        }

        //修改并保存xml文件的某个node的值
        //修改此程序的config.xml
        //返回是否修改成功，不成功包括 一系列异常，里面抛出异常都认为它不成功
        //可以支持修改<config>里的三级子结点，不包括<config>结点
        public static void writeConfigXml(string[] nodes,string value) 
        {
            XmlDocument xmlConfig = new XmlDocument();
            //加载xml文件
            try
            {
                xmlConfig.Load(Configuration.XML_PATH_CONFIG);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new WriteConfigXmlException("加载XML异常");
            }

            //因为config.xml的根节点是固定的，所以直接获取它
            //获取根节点
            XmlNode node = null;
            try
            {
                node = xmlConfig.SelectSingleNode("config");
                int n = nodes.Length;//有n级结点
                for (int i = 0; i < n; i++)
                {
                    node = node.SelectSingleNode(nodes[i]);
                }

            }
            catch (XmlException e)
            {
                throw new WriteConfigXmlException("选择结点异常 \n" + e.Message);
            }
            //此时的node为要修改的那个结点

            //XmlElement elem = (XmlElement)node;
            node.InnerText = value;

            try
            {
                xmlConfig.Save(Configuration.XML_PATH_CONFIG);
            }
            catch (XmlException e)
            {
                Console.WriteLine(e.Message);
                throw new WriteConfigXmlException("保存XML异常");
            }

        }

    }
}
