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
            /*输入班级人数，依次输入学员成绩，计算班级学员的平均成绩和总成绩。*/
            #region Exercise1
            Console.WriteLine("请输入班级人数：");
            try
            {
                int totalClassmates = Convert.ToInt32(Console.ReadLine());
                int num = 1;
                double score = 0;
                double totalScore = 0;
                double average = 0;
                bool temp1 = true;
                while (num <= totalClassmates)
                {
                    Console.WriteLine("请输入{0}号学员的成绩：", num);
                    try
                    {
                        score = Convert.ToDouble(Console.ReadLine());
                        totalScore += score;
                        num++;
                    }
                    catch
                    {
                        temp1 = false;
                        break;
                    }
                }
                if (temp1)
                {
                    average = totalScore / --num;
                    Console.WriteLine("平均成绩为{0}，总成绩为{1}。", average, totalScore);
                }
                else
                {
                    Console.WriteLine("请输入正确的成绩！程序退出。");
                }
            }
            catch
            {
                Console.WriteLine("请输入正确的人数！程序退出。");
            }
            Console.ReadKey();
            #endregion
            /*老师问学生：“这道题你会做了吗？”（y表示会、n表示不会）学生回答不会老师会继续问同样的问题。*/
            #region 1）直到学生会为止才可以放学；
            string answer1 = "n";
            while (answer1 == "n")
            {
                Console.WriteLine("老师：\"这道题你会做了吗？\"（输入y表示会了，输入n表示不会）");
                answer1 = Console.ReadLine();
                if ((answer1 == "n") || (answer1 == "y"))
                {

                }
                else
                {
                    answer1 = "n";
                    Console.WriteLine("老师：\"只能回答y或者n！\"");
                }
            }
            Console.WriteLine("放学！");
            Console.ReadKey();
            #endregion
            #region 2）如果10遍还是不会，都要放学。
            int time1 = 0;
            while (time1 <= 9)
            {
                Console.WriteLine("老师：\"这道题你会做了吗？\"（输入y表示会了，输入n表示不会）");
                string answer2 = Console.ReadLine();
                if ((answer2 == "n") || (answer2 == "y"))
                {
                    if (answer2 == "n")
                    {

                    }
                    else
                    {
                        break;
                    }
                    time1++;
                }
                else
                {
                    Console.WriteLine("老师：\"只能回答y或者n！\"");
                }
            }
            if (time1 == 10)
            {
                Console.WriteLine("已经讲了{0}遍了，今天先放学吧！", time1);
            }
            else
            {
                Console.WriteLine("放学！");
            }
            Console.ReadKey();
            #endregion
            /*2006年培养学员80000人，每年增长25%，请问按此增长速度到哪一年培训人数将达到20万人？*/
            #region Exercise3
            double people = 80000;
            int year = 2006;
            while (people < 200000)
            {
                people = (int)(people * 1.25);
                year++;
            }
            Console.WriteLine("在{0}将会有{1}位学员。", year, people);
            Console.ReadKey();
            #endregion
            /*提示输入用户名和密码，要求用户名等于aron密码等于000216,只要用户名或密码错误就重新输入，但最多只能输出3次。*/
            #region Exercise4
            string userName = "";
            string password = "";
            int temp4 = 3;
            while (((userName != "aron") || (password != "000216")) && (temp4 >= 1))
            {
                Console.WriteLine("请输入用户名：");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                password = Console.ReadLine();
                temp4--;
                if ((userName == "aron") && (password == "000216"))
                { }
                else if (temp4 == 0)
                { }
                else
                {
                    Console.WriteLine("用户名或密码错误！你还有{0}次机会。", temp4);
                }
            }
            if ((userName == "aron") && (password == "000216"))
            {
                Console.WriteLine("登录成功！");
            }
            else
            {
                Console.WriteLine("抱歉，你已没有机会！程序退出。");
            }
            Console.ReadKey();
            #endregion
            /*A输入用户名，要求用户名不能为空，只要为空，要求A重新输入，直到不为空为止。B再输入用户名，如果与A相同则要求重新输入。*/
            #region Exercise5
            string AName = "";
            while (AName == "")
            {
                Console.WriteLine("请A输入用户名：");
                AName = Console.ReadLine();
                if (AName == "")
                {
                    Console.WriteLine("用户名不可为空，请重新输入！");
                    Console.ReadKey();
                }
            }
            string BName = AName;
            while (BName == AName)
            {
                Console.WriteLine("请B输入用户名：");
                BName = Console.ReadLine();
                if (BName == AName)
                {
                    Console.WriteLine("用户名已被使用，请重新输入！");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("A的用户名为{0},B的用户名为{1}。", AName, BName);
            Console.ReadKey();
            #endregion
        }
    }
}
