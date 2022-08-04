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
            /*自我介绍*/
            #region 自我介绍
            String name = "陈爱东";
            int age = 22;
            String gender = "男";
            String telephoneNumber = "+8618602196216";
            String address = "上海市黄浦区南塘浜路18弄6号702室";
            /*两个自我介绍*/
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，我的电话是{3}。", name, age, gender, telephoneNumber);
            Console.WriteLine("我家在{0}，今年{1}岁了，我的姓名是{2}。", address, age, name);
            Console.ReadKey();
            #endregion
            /*定义两个变量分别赋值为10和5，写程序交换两个变量的值。*/
            int num1 = 10;
            int num2 = 5;
            /*错误方法：Console.WriteLine("Number1 is {1} , number2 is {0}.", num1, num2);
            Console.ReadKey();*/
            #region 正确方法1：使用第三方变量
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Number1 is {0} , number2 is {1}.", num1, num2);
            Console.ReadKey();
            #endregion
            #region 正确方法2：不使用第三方变量(x1=y-x;y1=y-x1;x2=x1+y1)
            num1 = 10;
            num2 = 5;
            num1 = num2 - num1;
            num2 = num2 - num1;
            num1 = num1 + num2;
            Console.WriteLine("Number1 is {0} , number2 is {1}.", num1, num2);
            Console.ReadKey();
            #endregion
            /*互动程序*/
            #region 你最喜爱的水果是什么？
            Console.WriteLine("What's your favourite fruit?(Please input then press ENTER.)");
            String str = Console.ReadLine();
            Console.WriteLine("Coincidently,I like eating {0} too!", str);
            Console.ReadKey();
            #endregion
            #region 信息输入程序
            Console.WriteLine("Please input your name:\n(Please input then press ENTER.)");
            String name1=Console.ReadLine();
            Console.WriteLine("Please input your gender:\n(Please input then press ENTER.)");
            String gender1 = Console.ReadLine();
            Console.WriteLine("Please input your age:\n(Please input then press ENTER.)");
            String age1 = Console.ReadLine();
            Console.WriteLine("Hello , {0} ! You are a {1} who is {2} years old !", name1,gender1,age1);
            Console.ReadKey();
            #endregion
        }
    }
}
