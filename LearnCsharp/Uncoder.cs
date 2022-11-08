using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Tools
{
    internal class Uncoder
    {
        public static string Uncode(string value)
        {
            if (value == null || value == "")
            {
                Console.WriteLine("请输入要解码的字符串\n\a");
                return "false";
            }
            else
            {
                try
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(value);
                    return Convert.ToBase64String(bytes);
                }
                catch (FormatException)
                {
                    return "false";
                }
            }
        }
    }
}
