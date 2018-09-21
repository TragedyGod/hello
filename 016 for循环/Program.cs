using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index=1; index<=9;index++)//初始化条件和循环的判断条件都不写的话，就是一个死循环
            {
                Console.WriteLine(index);
            }
            Console.ReadKey();
        }
    }
}
