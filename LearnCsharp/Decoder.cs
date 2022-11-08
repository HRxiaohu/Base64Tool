using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Tools
{
    internal class Decoder
    {
        public static string Decode(string value)
        {
            if (value == null || value == "")
            {
                Console.WriteLine("请输入要解码的字符串：\a");
                Console.WriteLine("---\n");
                return "false";
            }
            else
            {
                try
                {
                    byte[] bytes = Convert.FromBase64String(value);
                    return Encoding.UTF8.GetString(bytes);
                }
                catch (FormatException)
                {
                    return "false";
                }
            }
        }
    }
}
