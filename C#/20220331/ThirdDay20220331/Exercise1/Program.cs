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
            //#region 46天是第几周第几天？
            //int totalDays = 46;
            //int week = totalDays / 7;
            //int day = totalDays % 7;
            //Console.WriteLine("第{0}周，第{1}天", week, day);
            //Console.ReadKey();
            //#endregion
            //#region 107653秒是几天几小时几分钟几秒？
            //int totalTime = 107653;//总时间
            //int min1 = totalTime / 60;//总分钟
            //int sec = totalTime % 60;//秒
            //int hour1 = min1 / 60;//总小时
            //int min2 = min1 % 60;//分
            //int day1 = hour1 / 24;//天
            //int hour2 = hour1 % 24;//时
            //Console.WriteLine("{0}天{1}小时{2}分钟{3}秒", day1, hour2, min2, sec);
            //Console.ReadKey();
            //#endregion
            //#region 成绩输入，计算总分均值（convert练习）。
            //Console.WriteLine("请输入姓名");
            //String name = Console.ReadLine();
            //Console.WriteLine("请输入语文成绩");
            //double Cscore = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("请输入数学成绩");
            //double Mscore = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("请输入英语成绩");
            //double Escore = Convert.ToDouble(Console.ReadLine());
            //double totalScore = Cscore + Mscore + Escore;
            //double average = totalScore / 3;
            //Console.WriteLine("{0}，你的总成绩为{1:0.00}，平均成绩为{2:0.00}。", name, totalScore, average);
            //Console.ReadKey();
            //#endregion
            #region 输入成绩判断：1）语数成绩都大于90；2）语数有一门大于90。（逻辑运算符）
            Console.WriteLine("请输入语文成绩：");
            double Chinese = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入数学成绩：");
            double Math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("语数成绩都大于90吗？" + ((Chinese > 90) && (Math > 90)));
            Console.WriteLine("语数成绩有一门大于90吗？" + ((Chinese > 90) || (Math > 90)));
            Console.ReadKey();
            #endregion
        }
    }
}