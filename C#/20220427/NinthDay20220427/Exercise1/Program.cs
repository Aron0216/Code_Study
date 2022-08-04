using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        /// <summary>
        /// 闰年判断法
        /// </summary>
        /// <param name="year"></param>年份
        /// <returns></returns>
        public static bool LeapYear(int year)
        {
            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入年份：");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                if (year >= 0)
                {
                    if (LeapYear(year))
                    {
                        Console.WriteLine("{0}年是闰年！", year);
                    }
                    else
                    {
                        Console.WriteLine("{0}年是平年！", year);
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("年份必须大于0！程序退出！");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("请输入正确的年份！程序退出！");
                Console.ReadKey();
            }
        }
    }
}
