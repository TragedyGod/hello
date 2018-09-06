using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1=45;

            //num1++;

            //++num1

            //int res = num1 ++;//45

            //int res = ++num1;//46 ++放在前面会先进行自增，然后在进行运算，反之

            //Console.WriteLine(res+":"+num1);

            int num1 = 45;
            int res = num1--;
            int res2 = --num1;
            Console.WriteLine(res + ":" + res2);
            Console.ReadKey();
        }
    }
}
