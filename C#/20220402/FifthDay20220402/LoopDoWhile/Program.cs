using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region 1不断要求用户输入学生姓名，输入q结束
            //string name = "";
            //do
            //{
            //    Console.WriteLine("请输入学生姓名（输入q结束程序）：");
            //    name = Console.ReadLine();
            //} while (name != "q");
            //Console.WriteLine("结束");
            //Console.ReadKey();
            //#endregion
            //#region 2输入一个数，输出它的二倍，按q退出。
            //double num = 0;
            //string temp2 = "";
            //do
            //{
            //    Console.WriteLine("请输入一个数字：");
            //    temp2 = Console.ReadLine();
            //    if (temp2 != "q")
            //    {
            //        try
            //        {
            //            num = Convert.ToDouble(temp2);
            //            num *= 2;
            //            Console.WriteLine("它的二倍是{0}", num);
            //        }
            //        catch 
            //        {
            //            Console.WriteLine("请输入一个数字！");
            //            break;
            //        }
            //    }
            //} while (temp2 != "q");
            //Console.WriteLine("结束");
            //Console.ReadKey();
            //#endregion
            #region 3输入数字，直到输入end,输出刚才输入的最大的一个数
            string temp3 = "";
            bool b = true;
            double max = 0;
            double num3;
            do
            {
                Console.WriteLine("请输入一个数字：");
                temp3 = Console.ReadLine();
                if (temp3 != "end")
                {
                    try
                    {
                        num3 = Convert.ToDouble(temp3);
                        if (num3 > max)
                        {
                            max = num3;
                        }
                    }
                    catch
                    {
                        b = false;
                        break;
                    }
                }
            } while (temp3 != "end");
            if (b)
            {
                Console.WriteLine("刚才输入的数字中，最大值为{0}。", max);
            }
            else
            {
                Console.WriteLine("请输入正确数字！程序关闭。");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
