using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using EncryptTextEditor.MyExceptions;
using EncryptTextEditor.Utils;

namespace EncryptTextEditor.Utils
{
    public static class FileUtil
    {
        //仅保存文本到指定路径
        //返回保存是否成功
        public static bool saveFile(string text, string path)
        {
            //加密此文本
            byte[] arr = CoreUtil.encode(text);
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
            //sfd.Filter = "加密文本文件|*.ept|账户文件|*.act";
            sfd.Filter = Configuration.Instance.getDialogFilter();
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
        public static void writeConfigXmlNode(string[] nodes,string value) 
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
                throw new WriteXmlException("加载XML异常");
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
                throw new WriteXmlException("选择结点异常 \n" + e.Message);
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
                throw new WriteXmlException("保存XML异常");
            }
        }


        //添加xml文件的extensions结点
        public static void addConfigXml_Extensions(string name, string desc)
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
                throw new AddXmlException("加载XML异常");
            }
            //找到根节点
            XmlNode extensions = null;
            try
            {
                extensions = xmlConfig.SelectSingleNode("config");
                extensions = extensions.SelectSingleNode("extensions");
            }
            catch (XmlException e)
            {
                throw new AddXmlException("选择结点异常 \n" + e.Message);
            }
            
            //name --> extension
            //desc --> extension
            //extension --> extensions
            try
            {
                XmlElement extension = xmlConfig.CreateElement("extension");
                XmlElement Name = xmlConfig.CreateElement("name");
                Name.InnerText = name;
                XmlElement Desc = xmlConfig.CreateElement("desc");
                Desc.InnerText = desc;
                extension.AppendChild(Name);
                extension.AppendChild(Desc);
                extensions.AppendChild(extension);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new AddXmlException("添加XML结点异常");
            }

            //保存
            try
            {
                xmlConfig.Save(Configuration.XML_PATH_CONFIG);
            }
            catch (XmlException e)
            {
                Console.WriteLine(e.Message);
                throw new AddXmlException("保存XML异常");
            }
        }

    }
}
