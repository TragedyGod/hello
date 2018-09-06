using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(); //用来接收用户输入的字符串
            //string str =Console.ReadLine();
            //Console.WriteLine(str);

            //string str = "123"; 
            //int num=Convert.ToInt32(str); //强制类型转换
            //num++;
            //Console.WriteLine(num);

            //string str = Console.ReadLine();
            //int num = Convert.ToInt32(str);
            //Console.WriteLine(num);

            string str = Console.ReadLine();
            double num = Convert.ToDouble(str);
            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
