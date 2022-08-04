using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*输入5人平均年龄，如有错误立马停止报错*/
            //int age = 0;
            //int sum = 0;
            //string input1 = "";
            //bool b1 = true;
            //bool b2 = true;
            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的年龄：", i);
            //    input1 = Console.ReadLine();
            //    b1 = int.TryParse(input1, out age);
            //    if ((b1) && (age > 0) && (age <= 100))
            //    {
            //        sum += age;
            //    }
            //    else
            //    {
            //        Console.WriteLine("请输入正确的年龄（不可大于100）！");
            //        b2 = false;
            //        break;
            //    }
            //}
            //if (b2)
            //{
            //    Console.WriteLine("5人的平均年龄为{0}。", sum /= 5);
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("ERROR");
            //    Console.ReadKey();
            //}
            /*while中用break实现要求用户一直输入用户名和密码，只要不是cad和000216就提示一直输入，如果正确显示登录成功。*/
            //bool b2 = true;
            //string name2 = "";
            //string password2 = "";
            //while (b2)
            //{
            //    Console.WriteLine("请输入用户名：");
            //    name2 = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    password2 = Console.ReadLine();
            //    if ((name2 != "cad") && (password2 != "000216"))
            //    {
            //        Console.WriteLine("用户名或密码错误，请按回车重新输入！");
            //        Console.ReadKey();
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("登陆成功！");
            //Console.ReadKey();
            /*1到100一个个数字加，加到一个数大于20时输出这个数，重新从零开始加。*/
            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                sum += i;
                if (sum >= 20)
                {
                    Console.WriteLine("到{0}时，总和为{1}", i, sum);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
