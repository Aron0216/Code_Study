using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region 1不断要求用户输入一个数字，打印这个数字的两倍，当用户输入q时程序退出。
            //string input1 = "";
            //double num1 = 0;
            //do
            //{
            //    Console.WriteLine("请输入一个数字，我会输出它的两倍，输入q退出");
            //    try
            //    {
            //        input1 = Console.ReadLine();
            //        if (input1 != "q")
            //        {
            //            num1 = Convert.ToDouble(input1);
            //            num1 += num1;
            //            Console.WriteLine("它的两倍是：" + num1);
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入正确的数字或者输入\"q\"退出");
            //        Console.ReadKey();
            //    }
            //} while (input1 != "q");
            //#endregion
            //#region 2不断要求一个用户输入一个正整数，当用户输入end时显示刚才用户输入的最大值。
            //int num2 = 0;
            //int max2 = 0;
            //string input2 = "";
            //while (input2 != "end")
            //{
            //    Console.WriteLine("请输入一个正整数(输入end得出最大值)：");
            //    try
            //    {
            //        num2 = Convert.ToInt32(input2 = Console.ReadLine());
            //        if (num2 > 0)
            //        {
            //            if (num2 > max2)
            //            {
            //                max2 = num2;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("请输入正整数！");
            //        }
            //    }
            //    catch
            //    {
            //        if (input2 != "end")
            //        {
            //            Console.WriteLine("请输入正整数或者输入\"end\"得出最大值。");
            //        }
            //    }
            //}
            //if (max2 != 0)
            //{
            //    Console.WriteLine("在刚才输入的数字中最大的是：{0}", max2);
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("至少应该输入一个有效正整数，程序退出。");
            //    Console.ReadKey();
            //}
            //#endregion
            //#region 31到100之间除了能被7整除以外的所有整数和。
            //int num3 = 1;
            //int sum3 = 0;
            //while (num3 <= 100)
            //{
            //    if (num3 % 7 != 0)
            //    {
            //        sum3 += num3++;
            //    }
            //    else
            //    {
            //        num3++;
            //        continue;
            //    }
            //}
            //Console.WriteLine(sum3);
            //Console.ReadKey();
            //#endregion
            #region 4找出100以内所有的素数（while）
            int num4 = 2;
            int num5 = 2;
            while (num4 <= 100)
            {
                if (num5 < num4)
                {
                    if (num4 % num5 == 0)
                    {
                        num4++;
                        num5 = 2;
                        continue;
                    }
                    else
                    {
                        num5++;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine(num4);
                    num4++;
                    num5 = 2;
                }
            }
            Console.ReadKey();
            #endregion
        }
    }
}
