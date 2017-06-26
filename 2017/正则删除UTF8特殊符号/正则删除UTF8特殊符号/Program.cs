using System;
using System.Text.RegularExpressions;

namespace 正则删除UTF8特殊符号
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "测•试�字符";
            Console.WriteLine(content);

            var regex = new Regex(@"[^\u4E00-\u9FA5\u3000-\u303F\uFF00-\uFFEF\u0000-\u007F\u201c-\u201d]", RegexOptions.Multiline | RegexOptions.ExplicitCapture);
            content = regex.Replace(content, "");
            //content=content.Replace("�", "").Replace("•", "");

            Console.WriteLine(content);
            Console.ReadKey();
        }
    }
}
