using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace EncryptTextEditor.Utils
{
    /// <summary>
    /// 配置类，定义所有配置属性
    /// 单例类
    /// </summary>
    public sealed class Configuration
    {
        private static Configuration instance = null;
        private static readonly object padlock = new object();
        public static string XML_PATH_CONFIG = Program.START_PATH + "/../../data/config.xml";

        bool firstStart = true;     //程序首次启动 在首次启动的正常关闭后，保存为false

        public int width = 868, height = 593;       //窗口宽高 默认在窗口点击关闭后保存
        public int x = 700, y = 300;                //窗口出现的位置 默认在窗口点击关闭后保存
        public Font font = new Font("微软雅黑", 12);//字体 在选择字体点击确认后保存 在点击恢复默认字体时保存

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
                    case "setting":
                        loadXML_setting(n);
                        break;
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
                switch (n.Name)
                {
                    case "firstStart":
                        this.firstStart = Boolean.Parse(n.InnerText);
                        break;
                }
            }
            sw.Stop();
            Console.WriteLine("\n加载app耗时:" + sw.Elapsed);
        }

        //读取xml中的<setting>结点
        private void loadXML_setting(XmlNode node)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            XmlNodeList list = node.ChildNodes;
            foreach (XmlNode n in list)
            {
                //如果是注释就跳过
                if (n.NodeType != XmlNodeType.Element)
                    continue;
                XmlElement elem = (XmlElement)n;
                switch (elem.Name)
                {
                    case "width":
                        this.width = Int32.Parse(elem.InnerText);
                        break;
                    case "height":
                        this.height = Int32.Parse(elem.InnerText);
                        break;
                    case "x":
                        this.x = Int32.Parse(elem.InnerText);
                        break;
                    case "y":
                        this.y = Int32.Parse(elem.InnerText);
                        break;
                    case "font":
                        string family = elem.SelectSingleNode("name").InnerText;
                        int size = Int32.Parse(elem.SelectSingleNode("size").InnerText);
                        if (Boolean.Parse(elem.SelectSingleNode("regular").InnerText))
                        {
                            this.font = new Font(family, size, FontStyle.Regular);
                            break;
                        }
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
            sw.Stop();
            Console.WriteLine("加载setting耗时:" + sw.Elapsed);
        }

        private void printLog()
        {
            string str = "";
            str = "首次启动 : " + firstStart + '\n';
            Console.WriteLine("\n加载的app：\n" + str);

            str = "width : " + width + '\n';
            str += ("height : " + height + '\n');
            str += ("x : " + x + '\n');
            str += ("y : " + y + '\n');
            str += ("font : " + font.ToString() + '\n');
            Console.WriteLine("\n加载的setting：\n" + str);
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
