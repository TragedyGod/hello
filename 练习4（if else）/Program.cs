using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习4_if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("您考了多少分？");
            string str = Console.ReadLine();
            double score = Convert.ToDouble(str);
            if (score > 100)
            {
                 Console.WriteLine("您输入的分数大于100");
            } else if (score >= 90)
                {
                    Console.WriteLine("您的等级为优");
                }else if  (score >= 80&&score<90)
                    {
                        Console.WriteLine("您的等级为良");
                    } else if  (score >= 60&&score<80 )
                        {
                            Console.WriteLine("您的等级为中");
                        }else
                        {
                            Console.WriteLine("您的等级为差");
                        }       
            Console.ReadKey();
        }
    }
}
