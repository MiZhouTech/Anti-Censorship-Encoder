using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace ConsoleVer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the text:");
                string read = Console.ReadLine();
                if (read == "q") break;

                Console.WriteLine("Enter the key string:");
                string key = Console.ReadLine();

                // Try encode
                byte[] temp = EncoderV1.GetRawCodeFromText(read);
                EncoderV1.AssembleKeywords(key);
                string enc = EncoderV1.ReplaceHexWithKeyText(temp);

                // Try decode


                Console.WriteLine();

            }


        }

        static string LanChange(string str)
        {
            Encoding utf8;
            Encoding gb2312;
            utf8 = Encoding.GetEncoding("UTF-8");
            gb2312 = Encoding.GetEncoding("GB2312");
            byte[] gb = gb2312.GetBytes(str);
            for (int i = 0; i < gb.Length; i++)
            {
                Console.WriteLine(gb[i]);
            }
            Console.WriteLine();
            byte[] gb2 = utf8.GetBytes(str);
            for (int i = 0; i < gb.Length; i++)
            {
                Console.WriteLine(gb2[i]);
            }

            gb = Encoding.Convert(gb2312, utf8, gb);
            Console.WriteLine(gb2312.GetString(gb));
            return utf8.GetString(gb);
        }

        static string ChangeLan(string text)
        {
            byte[] bs = Encoding.GetEncoding("UTF-8").GetBytes(text);
            bs = Encoding.Convert(Encoding.GetEncoding("UTF-8"), Encoding.GetEncoding("GB2312"), bs);
            return Encoding.GetEncoding("GB2312").GetString(bs);
        }

        static void Function()
        {

        }

    }
}
