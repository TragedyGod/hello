using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013三元运算
{
    class Program
    {
        static void Main(string[] args)
        {
            //int myInteger = 100;
            //string resStr = (myInteger < 10) ? "Less than 10" : "Greater than equal to 10";
            //Console.WriteLine(resStr);

            Console.WriteLine("请输入一个分数：");
            string str = Console.ReadLine();
            int score = Convert.ToInt32(str);
            string resStr = score > 50 ? "这个分数大于50！" : "这个分数小于等于50！";
            Console.WriteLine(resStr);

            Console.ReadKey();

        }
    }
}
