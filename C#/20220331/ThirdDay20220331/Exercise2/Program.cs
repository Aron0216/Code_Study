using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region 1输入密码“88888”
            //Console.WriteLine("请输入密码");
            //String password = Console.ReadLine();
            //if (password == "88888")
            //{
            //    Console.WriteLine("正确！");
            //}
            //else
            //{
            //    Console.WriteLine("错误！");
            //}
            //Console.ReadKey();
            //#endregion
            //#region 2输入用户名admin和密码88888
            //Console.WriteLine("请输入用户名：");
            //String name = Console.ReadLine();
            //if (name == "admin")
            //{
            //    Console.WriteLine("请输入密码：");
            //    String password = Console.ReadLine();
            //    if (password == "88888")
            //    {
            //        Console.WriteLine("密码正确！");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码错误！");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("用户名不存在！");
            //}
            //Console.ReadKey();
            //#endregion
            #region 3十八禁选项
            Console.WriteLine("请输入年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("可以查看。");
            }
            else if (age >= 10)
            {
                Console.WriteLine("是否继续选择观看？（输入yes或no）");
                string choice = Console.ReadLine();
                if (choice == "yes")
                {
                    Console.WriteLine("请查看。");
                }
                else
                {
                    Console.WriteLine("退出，你已放弃查看。");
                }
            }
            else if (age > 0)
            {
                Console.WriteLine("不允许查看。");
            }
            else
            {
                Console.WriteLine("年龄不能为负。");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
