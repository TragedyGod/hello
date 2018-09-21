﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_练习4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你要查看的题号（1-13）：");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Training_1();
                    break;
                case 2:
                    Training_2();
                    break;
                case 3:
                    Training_3();
                    break;
                case 4:
                    Training_4();
                    break;
                case 5:
                    Training_5();
                    break;
                case 6:
                    Training_6();
                    break;
                case 7:
                    Training_7();
                    break;
                case 8:
                    Training_8();
                    break;
                case 9:
                    Training_9();
                    break;
                case 10:
                    Training_10();
                    break;
                case 11:
                    Training_11();
                    break;
                case 12:
                    Training_12();
                    break;
                case 13:
                    Training_13();
                    break;
                default:
                    Console.WriteLine("输错了！");
                    break;
            }
            Console.ReadKey();
        }
        static void Training_1()
        {
            int num1=0, num2=0, num3=0 ,num4=0; 
            Console.WriteLine("请输入第一个数字");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第四个数字");
            num4 = Convert.ToInt32(Console.ReadLine());
            int maxNum = num1, minNum=num1;
            if (num2 > maxNum)
            {
                  maxNum= num2;
            }
            if (num2 < minNum)
            {
                 minNum= num2;
            }
            if (num3 > maxNum)
            {
                maxNum = num3;
            }
            if (num3 < minNum)
            {
                minNum = num3;
            }
            if (num4 > maxNum)
            {
                maxNum = num4;
            }
            if (num4 < minNum)
            {
                minNum = num4;
            }
            Console.WriteLine("最大的数是:"+maxNum +'\n'+ "最小的数是:"+minNum);
        }
        static void Training_2()
        {
            Console.WriteLine("请输入第一个整数");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第一个整数");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入0-3之间的一个数，其中0代表加，1代表减，2代表乘，3代表除");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("运算结果为:"+'\n'+num1+"+"+num2+"="+(num1+num2));
                    break;
                case 1:
                    Console.WriteLine("运算结果为:" + '\n' + num1 + "-" + num2 + "=" + (num1 - num2));
                    break;
                case 2:
                    Console.WriteLine("运算结果为:" + '\n' + num1 + "*" + num2 + "=" + (num1 * num2));
                    break;
                case 3:
                    Console.WriteLine("运算结果为:" + '\n' + num1 + "/" + num2 + "=" + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("你输入的数字有误");
                    break;
            }
        }
        static void Training_3()
        {
            int  num=0,i=0,num1=0,num2;
            for (; i<=1000; i++)
            {
                if (i % 7 == 0)
                {
                    
                    Console.WriteLine(i);
                    if (i % 5 == 0)
                    {
                        num2 = num;
                        num1 = i;
                        num = num2 + num1;
                        
                    }
                    
                }
                Console.WriteLine(num);
            }
            
        }
        static void Training_4()
        {
            
            for(double i=0; i<=100; i++)
            {
                Console.WriteLine("平方为："+i * i);
                Console.WriteLine("平方根为：" + System.Math.Sqrt(i));
            }
        }
        static void Training_5()
        {
            int a = 1, b = 1, c = 1;
            for(int i=3; i<=20; i++)
            {
                a = b;
                b = b + c;
                c = a;
                Console.WriteLine(b);
            }
        }
        static void Training_6()
        {
            int num = 1;
            for (int i=0; i<=100; i++)
            {
                
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                    num++;
                }
            }
            Console.WriteLine(num);
        }
        static void Training_7()
        {
            for(int i = 0;i<=1000; i++)
            {
                bool isFind=true;
                for(int j=0; j <= 1000; j++)
                {
                    if (i % j == 0)
                    {
                        isFind = false;
                        break;
                    }
                }
                if (isFind)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Training_8()
        {
            int i = 0;
            int j = 0, num=1;
            for (; i <= 9; i++)
            {
                for (; j <= 9; j++)
                {
                    num = j * i;
                    Console.Write(num);
                    
                }
                Console.WriteLine();
            }
        }
        static void Training_9()
        {
            int point1 = 0, point2 = 0, point3 = 0, point4 = 0, point5 = 0, point6 = 0;
            Random ran = new Random();//随机变量
            for (int i=1;i<=100;i++)
            {
                int point = ran.Next(1, 7);
                switch (point)
                {
                    case 1:
                        {
                            point1++;
                            break;
                        }
                    case 2:
                        {
                            point2++;
                            break;
                        }
                    case 3:
                        {
                            point3++;
                            break;
                        }
                    case 4:
                        {
                            point4++;
                            break;
                        }
                    case 5:
                        {
                            point5++;
                            break;
                        }
                    case 6:
                        {
                            point6++;
                            break;
                        }
                    default:
                        {
                            Console.Write("null");
                            break;
                        }
                }
                Console.WriteLine("点数1出现的次数为："+point1);
                Console.WriteLine("点数2出现的次数为："+point2);
                Console.WriteLine("点数3出现的次数为："+point3);
                Console.WriteLine("点数4出现的次数为："+point4);
                Console.WriteLine("点数5出现的次数为："+point5);
                Console.WriteLine("点数6出现的次数为："+point6);

            }

        }
        static void Training_10()
        {

            Console.WriteLine("1：为for语句实现"+'\n'+ "2：为while语句实现" + '\n' + "3：为do-while语句实现" + '\n' );
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        goto num1;
                        break;
                    }
                case 2: { goto num2; break; }
                case 3: { goto num3; break; }
                default:
                    {
                        return;
                    }
            }
            num1:
            {
                for(int i=0; i<=5; i++)
                {
                    Console.WriteLine("1-5的的平方值为："+i * i);
                }
            }
            num2:
            {
                int i = 1;
                while (i == 6)
                {
                    Console.WriteLine("1-5的的平方值为：" + i * i);
                    i++;
                }
            }
            num3:
            {
                int i = 1;
                do
                {
                    Console.WriteLine("1-5的的平方值为：" + i * i);
                    i++;
                } while(i==5);
            }
        }
        static void Training_11()
        {
            int captial = 0, lower = 0, num = 0, other = 0;
            Console.WriteLine("请输入含有5个大写字母的字符串：");
            string str = Console.ReadLine();
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    captial++;
                }
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    lower++;
                }
                else if (str[i] >= '1' && str[i] <= '9')
                {
                    num++;
                }
                else { other++; }
            }
            if (captial >= 1)
            {
                Console.WriteLine("您输入的字符串里5个字符并非全是大写字母");
                Console.WriteLine("其中" + "\n小写字母有：" + lower + "个" + "\n数字有：" + num + "个"+"\n其他字符有："+other+"个");
            }
        }
        static void Training_12()
        {
           num: Console.WriteLine("输入任意一个数n");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1)
            {
                Console.WriteLine("您输入的是一个大于0的正整数"+','+"输出1-n的所有整数：");
                for(int i=0; i <= num; i++)
                {
                    Console.WriteLine(i);
                }
            }else if (num == 0)
            {
                goto num;
            }else if (num < 0)
            {
                return;
            }
        }
        static void Training_13()
        {
            int[] num ;
            num = new int[1000];
            int i=0, k=0, j=0;
            //创建一个循环，遍历1到1000的数
            for (j = 0; j <= 1000; j++)
            {

            }
            //判断一个数是否有除了1和他本身之外的因数
            for(i = 0; i <= 1000; i++)
            {

            }
            //判断一个数是否是完数
            for(k=0;k<=1000; k++)
            {
                num[k] = i;
            }
        }
    }
}
