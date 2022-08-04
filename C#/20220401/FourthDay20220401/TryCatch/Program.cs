using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 输入一个数字进行运算输出
            double num = 0;
            bool temp = true;//确认变量
            Console.WriteLine("请输入数字:");
            try
            {
                num = Convert.ToDouble(Console.ReadLine());//输入后无语法错误，给num赋值
            }
            catch
            {
                temp = false;
                Console.WriteLine("请输入正确的数字！");
            }
            if (temp)//确保执行if时没有输入语法错误
            {
                Console.WriteLine("{0}*2={1}", num, num * 2);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
