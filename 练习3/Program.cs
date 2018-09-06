using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1=Console.ReadLine(), str2 = Console.ReadLine(), str3 = Console.ReadLine(), str4 = Console.ReadLine();
            //int num1 = Convert.ToInt32(str1), num2 = Convert.ToInt32(str2),num3 = Convert.ToInt32(str3),num4 = Convert.ToInt32(str4 );
            //int res = num1 * num2 * num3 * num4;
            //Console.WriteLine(res);
            //Console.ReadKey();

            //string str1 = Console.ReadLine();
            //int num = Convert.ToInt32(str1);
            //int ge = num % 10;
            //int shi = (num / 10) % 10;
            //int bai = (num / 100) % 10;
            //Console.WriteLine(ge + ":" + shi + ":" + bai);
            //Console.ReadKey();

            //Console.WriteLine("请输入上底");
            //string str1 = Console.ReadLine();
            //double num1 = Convert.ToDouble(str1);
            //Console.WriteLine("请输入下底");
            //string str2 = Console.ReadLine();
            //double num2 = Convert.ToDouble(str2);
            //Console.WriteLine("请输入高");
            //string str3 = Console.ReadLine();
            //double num3 = Convert.ToDouble(str3);
            //Console.WriteLine("梯形的面积是：");
            //double res = (num1 + num2) * num3 / 2;
            //Console.WriteLine(res);
            //Console.ReadKey();

            //Console.WriteLine("请输入圆的半径");
            //string str= Console.ReadLine();
            //double n = Convert.ToDouble(str);
            //double Π = Math.PI;
            //Console.WriteLine("圆的周长是:" + 2 * Π * n + "\n" + "圆的面积是:" + Π*(Math.Pow(n,2)));
            double bit = 124.0*1.024;
            double rate = 38.0 / 1024.0;
            double time = bit / rate;
            double min = time / 60.0;
            double house = time / (60.0 * 60.0);
            Console.WriteLine("所需时间为:" + house + "小时" + "\n" + "也就是" + min + "分钟");
            Console.ReadKey();
        }
    }
}
