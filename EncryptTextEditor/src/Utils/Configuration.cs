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
        //内部类，表示扩展名
        public class Extension 
        {
            public string name;
            public string desc;
            public Extension(string name, string desc)
            {
                this.name = name;   //扩展名
                this.desc = desc;   //描述
            }
        }

        private static Configuration instance = null;
        private static readonly object padlock = new object();
        public static string XML_PATH_CONFIG = Program.START_PATH + "/../../data/config.xml";

        bool firstStart = true;     //程序首次启动 在首次启动的正常关闭后，保存为false
        public int width = 868, height = 593;       //窗口宽高 默认在窗口点击关闭后保存
        public int x = 700, y = 300;                //窗口出现的位置 默认在窗口点击关闭后保存
        public Font font = new Font("微软雅黑", 12);//字体 在选择字体点击确认后保存 在点击恢复默认字体时保存
        public Color foreColor,backColor;

        List<Extension> extensions = new List<Extension>(); //应用程序关联的扩展名

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
                    case "style":
                        loadXML_style(n);
                        break;
                    case "extensions":
                        loadXML_extensions(n);
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
                    case "width":
                        this.width = Int32.Parse(n.InnerText);
                        break;
                    case "height":
                        this.height = Int32.Parse(n.InnerText);
                        break;
                    case "x":
                        this.x = Int32.Parse(n.InnerText);
                        break;
                    case "y":
                        this.y = Int32.Parse(n.InnerText);
                        break;
                }
            }
            sw.Stop();
            Console.WriteLine("\n加载app耗时:" + sw.Elapsed);
        }

        //读取xml中的<setting>结点
        private void loadXML_style(XmlNode node)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            XmlNodeList list = node.ChildNodes;
            foreach (XmlNode n in list)
            {
                //如果是注释就跳过
                if (n.NodeType != XmlNodeType.Element)
                    continue;
                //XmlElement elem = (XmlElement)n;
                switch (n.Name)
                {
                    case "font":
                        string family = n.SelectSingleNode("name").InnerText;
                        int size = Int32.Parse(n.SelectSingleNode("size").InnerText);
                        if (Boolean.Parse(n.SelectSingleNode("regular").InnerText))
                        {
                            this.font = new Font(family, size, FontStyle.Regular);
                            break;
                        }
                        FontStyle fontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline;
                        if (!Boolean.Parse(n.SelectSingleNode("bold").InnerText))
                            fontStyle ^= FontStyle.Bold;
                        if (!Boolean.Parse(n.SelectSingleNode("italic").InnerText))
                            fontStyle ^= FontStyle.Italic;
                        if (!Boolean.Parse(n.SelectSingleNode("strikeout").InnerText))
                            fontStyle ^= FontStyle.Strikeout;
                        if (!Boolean.Parse(n.SelectSingleNode("underline").InnerText))
                            fontStyle ^= FontStyle.Underline;
                        this.font = new Font(family, size, fontStyle);
                        break;
                    case "foreColor":
                        this.foreColor = ColorTranslator.FromHtml(n.InnerText);
                        break;
                    case "backColor":
                        this.backColor = ColorTranslator.FromHtml(n.InnerText);
                        break;
                }
            }
            sw.Stop();
            Console.WriteLine("加载setting耗时:" + sw.Elapsed);
        }

        //读取xml中的<extensions>结点
        private void loadXML_extensions(XmlNode node)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            XmlNodeList list = node.ChildNodes;
            foreach (XmlNode n in list)
            {
                if (n.Name.Equals("extension"))
                {
                    Extension ext = new Extension(n.SelectSingleNode("name").InnerText, n.SelectSingleNode("desc").InnerText);
                    extensions.Add(ext);
                }
                else
                {
                    continue;
                }
            }
            sw.Stop();
            Console.WriteLine("加载extensions耗时:" + sw.Elapsed);
        }

        private void printLog()
        {
            string str = "";
            str = "首次启动 : " + firstStart + '\n';
            str += ("width : " + width + '\n');
            str += ("height : " + height + '\n');
            str += ("x : " + x + '\n');
            str += ("y : " + y + '\n');
            Console.WriteLine("\n加载的app：\n" + str);

            
            
            str = ("font : " + font.ToString() + '\n');
            Console.WriteLine("\n加载的style：\n" + str);

            str = "";
            foreach (Extension ext in extensions)
            {
                str += (ext.desc + '：' + ext.name + '\n');
            }
            Console.WriteLine("\n加载的extensions：\n" + str);

        }

        //
        public string getDialogFilter()
        {
            string str = "";
            char separate = '|';
            foreach (Extension ext in extensions)
            {
                str += ext.desc;
                str += separate;
                str += ext.name;
                str += separate;
            }
            return str.TrimEnd(separate); ;

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
