using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace EncryptTextEditor
{
    /// <summary>
    /// 配置类，定义所有配置属性
    /// 单例类
    /// </summary>
    public sealed class Configuration
    {
        private static Configuration instance = null;
        private static readonly object padlock = new object();
        private static string XML_PATH_CONFIG = "../../config.xml";

        public int width = 868, height = 593;       //窗口宽高
        public int x = 700, y = 300;                //窗口出现的位置
        public Font font = new Font("微软雅黑", 12);//字体

        private Configuration()
        {
            //从xml文件加载信息
            loadXML();
            //打印加载信息
            printLog();

        }


        private void loadXML()
        {
            //如果次配置文件不存在，就根据默认的数据生成一个xml文件
            XmlDocument xmlConfig = new XmlDocument();
            try
            {
                xmlConfig.Load(XML_PATH_CONFIG);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("加载XML异常：");
                Console.WriteLine("未找到该文件：" + XML_PATH_CONFIG + "\n");
                //根据默认配置生成一个XML文件

                return;
            }
            //获取根节点
            XmlNode node = xmlConfig.SelectSingleNode("config");
            //获取根结点的子结点列表
            XmlNodeList list = node.ChildNodes;
            //遍历
            foreach (XmlNode n in list)
            {
                switch (n.Name)
                {
                    case "app":
                        loadXML_app(n);
                        break;
                }
            }
        }

        //读取xml中的<app>结点
        private void loadXML_app(XmlNode node)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            XmlNodeList list = node.ChildNodes;
            foreach (XmlNode n in list)
            {
                XmlElement elem = (XmlElement)n;
                switch (elem.Name)
                {
                    case "width":
                        this.width = Int32.Parse(elem.InnerText);
                        break;
                    case "height":
                        this.height = Int32.Parse(elem.InnerText);
                        break;
                    case "font":
                        string family = elem.SelectSingleNode("family").InnerText;
                        int size = Int32.Parse(elem.SelectSingleNode("size").InnerText);
                        FontStyle fontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline;
                        if (!Boolean.Parse(elem.SelectSingleNode("bold").InnerText))
                            fontStyle ^= FontStyle.Bold;
                        if (!Boolean.Parse(elem.SelectSingleNode("italic").InnerText))
                            fontStyle ^= FontStyle.Italic;
                        if (!Boolean.Parse(elem.SelectSingleNode("strikeout").InnerText))
                            fontStyle ^= FontStyle.Strikeout;
                        if (!Boolean.Parse(elem.SelectSingleNode("underline").InnerText))
                            fontStyle ^= FontStyle.Underline;
                        this.font = new Font(family, size, fontStyle);
                        break;
                }
            }

            //this.width = Int32.Parse(node.SelectSingleNode("width").InnerText);

            //this.height = Int32.Parse(node.SelectSingleNode("height").InnerText);

            //XmlNode fontNode = node.SelectSingleNode("font");
            //string family = fontNode.SelectSingleNode("family").InnerText;
            //int size = Int32.Parse(fontNode.SelectSingleNode("size").InnerText);

            //FontStyle fontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline;
            //if (!Boolean.Parse(fontNode.SelectSingleNode("bold").InnerText))
            //    fontStyle ^= FontStyle.Bold;
            //if (!Boolean.Parse(fontNode.SelectSingleNode("italic").InnerText))
            //    fontStyle ^= FontStyle.Italic;
            //if (!Boolean.Parse(fontNode.SelectSingleNode("strikeout").InnerText))
            //    fontStyle ^= FontStyle.Strikeout;
            //if (!Boolean.Parse(fontNode.SelectSingleNode("underline").InnerText))
            //    fontStyle ^= FontStyle.Underline;

            //this.font = new Font(family, size, fontStyle);

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        private void printLog()
        {
            string str = "width : " + width + '\n';
            str += ("height : " + height + '\n');
            Console.WriteLine(str);
        }

        //获取实例
        public static Configuration Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Configuration();
                    }
                    return instance;
                }
            }
        }

    }
}
