using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 判断是否为闰年，是显示True，否显示False
/// </summary>
namespace LeapYearJudgement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*闰年判断法：
             （1）年份能够被400整除；
            （2）年份能被4整除但不能被100整除。*/
            Console.WriteLine("请输入年份");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}是闰年吗？{1}", year, (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)));
            Console.ReadKey();
        }
    }
}
