using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "egoist";
            int HP = 100;
            int level = 34;
            float EXP = 345.3f;
            Console.WriteLine("主角的名字是:{0} 血量:{1}等级:{2}经验值:{3}",name,HP,level,EXP);

            
            Console.ReadKey();
        }
    }
}
