using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //int index = 1;
            //while (true)
            //{

            //    index++;
            //    if (index == 5)
            //    {
            //        continue;
            //    }
            //    if (index==10)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(index);//当index=5时，continue会自动跳过本次循环进行条件判断
            //}
            int sum=0;
            while (true)
            {
                //string str = Console.ReadLine();
                //int num = Convert.ToInt32(str);
                int num = Convert.ToInt32
                    (Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                if (num % 2 == 1)
                {
                    continue;
                }
                sum += num;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
