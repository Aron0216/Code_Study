using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class Program
    {
        /// <summary>
        /// 方法：n天是第几周第几天
        /// </summary>
        /// <param name="day"></param> n天
        public static void DateCalculate1(int day)
        {
            Console.WriteLine("{0}是{1}周第{2}天", day, day / 7, day % 7);
        }
        /// <summary>
        /// 方法：n秒是几天几分钟几小时几秒
        /// </summary>
        /// <param name="second"></param> n秒
        public static void DateCalculate2(int second)
        {
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", second, second / 86400, second / 3600 % 24, second / 60 % 60, second % 60);
        }
        static void Main(string[] args)
        {
            //#region hello world
            //Console.WriteLine("Hello World !");
            //Console.ReadKey();
            //#endregion
            //#region n天是第几周第几天？
            //try
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("请输入天数：");
            //        int day = Convert.ToInt32(Console.ReadLine());
            //        if (day >= 0)
            //        {
            //            DateCalculate1(day);
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入天数必须大于等于0");
            //        }
            //    }
            //    Console.ReadKey();
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的天数，程序退出。");
            //    Console.ReadKey();
            //}
            //#endregion
            //#region n秒是几天几分钟几小时几秒
            //try
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("请输入秒数：");
            //        int day = Convert.ToInt32(Console.ReadLine());
            //        if (day >= 0)
            //        {
            //            DateCalculate2(day);
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入秒数必须大于等于0");
            //        }
            //    }
            //    Console.ReadKey();
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的秒数，程序退出。");
            //    Console.ReadKey();
            //}
            //#endregion
            #region

            #endregion
        }
    }
}
