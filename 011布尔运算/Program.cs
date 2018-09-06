using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011布尔运算
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 34;
            //int num2 = 67;
            //bool res1 = num1 == num2;//false
            //bool res2 = num1 != num2;//true
            //bool res3 = num1 < num2;//true
            //bool res4 = num1 > num2;//false
            //bool res5 = num1 <= num2;//true
            //bool res6 = num1 >= num2;//false
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            //Console.WriteLine(res3);
            //Console.WriteLine(res4);
            //Console.WriteLine(res5);
            //Console.WriteLine(res6);

            bool var1 = true;
            bool var2 = false;
            //bool res = !var1;
            //bool res1 = var1 & var2;
            //bool res2 = var1 | var2;
            //bool res3 = var1 ^ var2;
            //Console.WriteLine(res);
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            //Console.WriteLine(res3);

            //&& ||
            bool res = var1 && var2;
            bool res2 = var1 || var2;

            Console.ReadKey();
        }
    }
}
