using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        /// <summary>
        /// 两数取最大值
        /// </summary>
        /// <param name="a"></param>数a
        /// <param name="b"></param>数b
        /// <returns></returns>
        public static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
        /// <summary>
        /// 正常游玩状态
        /// </summary>
        public static void PlayGame()
        {
            Console.WriteLine("Walking,jumping,walking!");
            Console.WriteLine("Walking,jumping,walking!");
            Console.WriteLine("Walking,jumping,walking!");
            Console.WriteLine("Walking,jumping,walking!");
            Console.WriteLine("Invincible mode!");
        }
        /// <summary>
        /// 无敌状态
        /// </summary>
        public static void Invincible()
        {
            Console.WriteLine("Music~~~!");
            Console.WriteLine("Immune damage!");
            Console.WriteLine("Strengthen attack!");
        }
        static void Main(string[] args)
        {
            //int num1 = 100;
            //int num2 = 10;
            //Console.WriteLine(Program.GetMax(num1, num2));
            Program.PlayGame();
            Program.Invincible();
            Console.ReadKey();
        }
    }
}
