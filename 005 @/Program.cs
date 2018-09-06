using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005__
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 =@"I'm a good man.
You are bad girl!";
            Console.WriteLine(str1);
            string str2= @"I'm a good man.\n"" You are bad girl!";
            Console.WriteLine(str2);

            string path = "C:\\xxx\\xx\\xxx.doc";
            Console.WriteLine(path);
            string path2 = @"C:\xxx\xx\xxx.doc";
            Console.WriteLine(path2);
            Console.ReadKey();
        }
    }
}
