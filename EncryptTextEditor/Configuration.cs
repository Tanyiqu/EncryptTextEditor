using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public int width, height;   //窗口宽高
        public int x, y;            //窗口出现的位置


        private Configuration()
        {
            //从xml文件加载信息

            //假设以下代码是读取的xml文件
            width = 868;
            height = 593;
            x = 700;
            y = 300;

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
