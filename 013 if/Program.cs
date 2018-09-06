using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool var = true;
            //if (var)
            //    Console.WriteLine(".......");
            //Console.WriteLine("if");
            //Console.ReadKey();

            //Console.WriteLine("请输入一个分数：");
            //string str = Console.ReadLine();
            //double score = Convert.ToDouble(str);
            //if (score > 50)
            //    Console.WriteLine("这个分数大于50！");
            //if(score<=50)
            //    Console.WriteLine("这个分数小于等于50！");
            //Console.ReadKey();

            Console.WriteLine("请输入一个分数：");
            string str = Console.ReadLine();
            int score = Convert.ToInt32(str);
            if (score > 50)
            {
                score++;
                Console.WriteLine("这个分数大于50！");
            }
            else
            {
                score--;
                Console.WriteLine("这个分数小于等于50！");
            }

            Console.ReadKey();
        }
    }
}
