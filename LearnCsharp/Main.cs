using static Base64Tools.Uncoder;
using static Base64Tools.Decoder;
using System.Text;

namespace Base64Tools
{
    class Tools
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine(" ____                  __   _  _   _____                     _\r\n| __ )  __ _ ___  ___ / /_ | || | | ____|_ __   ___ ___   __| | ___ _ __\r\n|  _ \\ / _` / __|/ _ | '_ \\| || |_|  _| | '_ \\ / __/ _ \\ / _` |/ _ | '__|\r\n| |_) | (_| \\__ |  __| (_) |__   _| |___| | | | (_| (_) | (_| |  __| |\r\n|____/ \\__,_|___/\\___|\\___/   |_| |_____|_| |_|\\___\\___/ \\__,_|\\___|_|\n");
            Console.WriteLine("----------------------------------------------------------------");
        start:
            Console.WriteLine("您是想进行解码还是编码呢？请输入 解码/编码");
            string answer = Console.ReadLine();
            if (answer == "解码")
            {
            decoder:
                Console.WriteLine("请输入要解码的Base64字符串");
                string base64 = Console.ReadLine();
                string base64Return = Decode(base64);
                if (base64Return == "false")
                {
                    Console.WriteLine("请输入正确的Base64字符串\a");
                    Console.WriteLine("---\a");
                    goto decoder;
                }
                else
                {
                    Console.WriteLine("原文为:"+base64Return+"\n\a");
                    Console.WriteLine("解码完毕");
                    Console.WriteLine("---\n");
                }
            }
            else if (answer == "编码")
            {
            uncoder:
                Console.WriteLine("请输入要编码的Base64字符串:");
                string base64 = Console.ReadLine();
                string base64Return = Uncode(base64);
                if (base64Return == "false")
                {
                    Console.WriteLine("请输入正确的Base64字符串\a");
                    Console.WriteLine("---\n");
                    goto uncoder;
                }
                else
                {
                    Console.WriteLine("原文为:"+base64Return +"\n\a");
                    Console.WriteLine("编码完毕");
                    Console.WriteLine("---\n");
                }
            }
            else
            {
                Console.WriteLine("请输入正确的选项\n\a");
                goto start;
            }
        }       
    }
}