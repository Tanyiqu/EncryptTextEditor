using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*****************************************
核心加密解密算法
*****************************************/

namespace EncryptTextEditor.Utils
{
    public static class CoreUtil
    {
        //字符串加密成字节数组
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

        public static string decode(byte[] arr)
        {
            byte[] arr2 = new byte[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = (byte)(arr[i] ^ 0x55);
            }
            string text = System.Text.Encoding.Default.GetString(arr2);
            return text;
        }

    }
}
