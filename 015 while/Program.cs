using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //while(true)//死循环
            //{
            //    Console.WriteLine("www.egoist.com");
            //}
            //int index=1;
            //while(index<=9)
            //{
            //    Console.WriteLine(index);
            //    index ++;
            //}

            //do while循环

            //do
            //{
            //    Console.WriteLine("这里是do while的循环体");
            //} while (true);//这是一个死循环

            int index = 1;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 9);
            //do while循环会首次执行一次循环体,然后进行条件判断
            //while循环会先进行条件判断，然后根据判断结果去判定是否去执行循环体
            Console.ReadKey();
        }
    }
}
