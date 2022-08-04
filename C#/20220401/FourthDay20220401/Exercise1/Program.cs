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
            //#region 1输入姓名，显示职业
            //Console.WriteLine("请输入下列姓名的其中之一并查看职业：\n小光，竹兰，罗翔，张三");
            //string name1 = Console.ReadLine();
            //string job1 = "";
            //bool temp1 = true;
            //switch (name1)
            //{
            //    case "小光":
            //        job1 = "宝可梦训练大师";
            //        break;
            //    case "竹兰":
            //        job1 = "宝可梦联盟神奥地区冠军";
            //        break;
            //    case "罗翔":
            //        job1 = "法学教授";
            //        break;
            //    case "张三":
            //        job1 = "法外狂徒";
            //        break;
            //    default:
            //        Console.WriteLine("您输入的名字不在上述范围内！程序关闭。");
            //        temp1 = false;
            //        break;
            //}
            //if (temp1)
            //{
            //    Console.WriteLine("{0}，{1}。", name1, job1);
            //}
            //Console.ReadKey();
            //#endregion
            #region ***2输入年份、输入月份，输出天数
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
                        Console.WriteLine("输入的月份必须在1~12之间！程序关闭。");
                    }
                }
                catch//与month配对
                {
                    Console.WriteLine("请输入正确的月份。程序关闭。");
                }
            }
            catch//与year配对
            {
                Console.WriteLine("请输入正确的年份。程序关闭。");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
