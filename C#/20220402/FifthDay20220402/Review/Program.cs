using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*输入年份、月份，输出当月天数*/
            int year = 0;
            int month = 0;
            Console.WriteLine("请输入年份：");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份：");
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    if ((month >= 1) && (month <= 12))
                    {
                        int day = 0;
                        switch (month)
                        {
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                day = 30;
                                break;
                            case 2:
                                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default:
                                day = 31;
                                break;
                        }
                        Console.WriteLine("{0}年{1}月有{2}天。", year, month, day);
                    }
                    else
                    {
                        Console.WriteLine("月份只能输入1~12之间的数字！程序退出。");
                    }
                }
                catch//month
                {
                    Console.WriteLine("请输入正确的月份！程序退出。");
                }
            }
            catch//year
            {
                Console.WriteLine("请输入正确的年份！程序退出。");
            }
            Console.ReadKey();
        }
    }
}
