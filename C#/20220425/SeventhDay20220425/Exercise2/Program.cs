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
            /*数组试验1*/
            //int[] num = new int[10];
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = i + 1;
            //    Console.WriteLine(num[i]);
            //}
            //Console.ReadKey();
            /*数组试验2*/
            //int[] num = new int[3] { 1, 2, 3 };//int[] num = { 1, 2, 3 };
            //Console.WriteLine(num[0] + "\t" + num[1] + "\t" + num[2]);
            //Console.ReadKey();
            /*从一个整数数组中取出最大整数，最小整数，总和，平均值*/
            //int[] num = new int[10] { 1, 2, 3, 20, 5, 6, 7, 8, 9, 0 };
            //int max = num[0];//int max = int.MinValue;//原理：int中最大值和最小值字段
            //int min = num[0];//int min = int.MaxValue;
            //int sum = 0;
            //double average;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum += num[i];
            //}
            //average = sum / num.Length;
            //for (int j = 0; j < num.Length; j++)
            //{
            //    if (num[j] > max)
            //    {
            //        max = num[j];
            //    }
            //}
            //for (int k = 0; k < num.Length; k++)
            //{
            //    if (num[k] < min)
            //    {
            //        min = num[k];
            //    }
            //}
            //min = num[9];
            //Console.WriteLine("这10个数的总和为{0}，平均值为{1}，最大值为{2}，最小值为{3}。", sum, average, max, min);
            //Console.ReadKey();
            /*计算一个整数数组所有元素的和*/
            //int[] num = new int[10];
            //int sum = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = i + 1;
            //    sum += num[i];
            //}
            //Console.WriteLine("该数组的和为{0}。", sum);
            //Console.ReadKey();
            /*写一个字符串数组*/
            //string[] name = { "陈爱东", "陈颖", "袁谊芳", "袁振荣", "黄静娟" };
            //string temp = null;
            //for (int i = 0; i < name.Length - 1; i++)
            //{
            //    temp += name[i] + "|";
            //}
            //Console.WriteLine(temp + name[name.Length - 1]);
            //Console.ReadKey();
            /*对一个整数数组的每一个元素，是正数则值加1，负数则值减1，0则保持不变*/
            //int[] num = { -1, 0, 1 };
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] < 0)
            //    {
            //        num[i] -= 1;
            //    }
            //    else if (num[i] > 0)
            //    {
            //        num[i] += 1;
            //    }
            //}
            //Console.WriteLine("数组的三元素分别为{0}，{1}，{2}", num[0], num[1], num[2]);
            //Console.ReadKey();
            /*把12345变成54321*/
            string[] word = { "1", "2", "3", "4", "5" };
            //string temp = null;
            //for (int i = 0; i < word.Length / 2; i++)
            //{
            //    temp = word[word.Length - i - 1];
            //    word[word.Length - i - 1] = word[i];
            //    word[i] = temp;
            //}
            /*等效代码*/
            Array.Reverse(word);
            for (int j = 0; j < word.Length; j++)
            {
                Console.Write(word[j]);
            }
            Console.ReadKey();
            
        }
    }
}
