using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003变量类型
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 34;
            int score = 6000;
            long count = 1000000300;
            Console.WriteLine("byte:{0} int:{1} long:{2}", myByte, score, count);

            float myFloat = 12.5f;
            double myDouble = 12.6;
            Console.WriteLine("float:{0} double:{1}", myFloat, myDouble);

            char myChar ='a';
            string myString = "a";
            string myString2 = "a";
            bool myBool = true;
            Console.WriteLine("char:{0} string1:{1} string2:{2} bool:{3}",myChar,myString,myString2,myBool);

            Console.ReadKey();
        }
    }
}
