using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*输出100以内质数*/
            //bool b = true;
            //int t = 1;
            //for (int i1 = 2; i1 < 101; i1++)
            //{
            //    for (int i2 = 2; i2 < i1; i2++)
            //    {
            //        if (i1 % i2 == 0)
            //        {
            //            i2 = 2;
            //            b = false;
            //            break;
            //        }
            //    }
            //    if (b && (t % 5 != 0))
            //    {
            //        Console.Write(i1 + "\t");
            //        t++;
            //    }
            //    else if (b && (t % 5 == 0))
            //    {
            //        Console.WriteLine(i1 + "\t");
            //        t++;
            //    }
            //    b = true;
            //}
            //Console.ReadKey();
            /*输入姓名，不是cad就全是流氓（三元表达式）*/
            //Console.WriteLine("请输入姓名：");
            //string name = Console.ReadLine();
            //string outcome = name == "cad" ? "你是帅哥！" : "你是流氓！";
            //Console.WriteLine(outcome);
            //Console.ReadKey();
            /*随机生成职业*/
            Random random = new Random();
            while (true)
            {
                Console.WriteLine("请输入姓名：");
                string name = Console.ReadLine();
                int career = random.Next(1, 6);
                switch (career)
                {
                    case 1:
                        Console.WriteLine("{0}，你的职业是战士！", name);
                        break;
                    case 2:
                        Console.WriteLine("{0}，你的职业是法师！", name);
                        break;
                    case 3:
                        Console.WriteLine("{0}，你的职业是刺客！", name);
                        break;
                    case 4:
                        Console.WriteLine("{0}，你的职业是牧师！", name);
                        break;
                    default:
                        Console.WriteLine("{0}，你的职业是守卫！", name);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
