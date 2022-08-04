using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 发年终奖
            int salary = 5000;
            Console.WriteLine("请输入工作等地（A，B，C，D，E）：");
            string level = Console.ReadLine();
            bool temp = true;
            switch (level)
            {
                case "A":
                    salary += 500;
                    break;
                case "B":
                    salary += 200;
                    break;
                case "C":
                    break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
                default:
                    Console.WriteLine("你输入了错误等地，程序退出。");
                    temp = false;
                    break;
            }
            if (temp)
            {
                Console.WriteLine("你的年终奖为{0}。", salary);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
