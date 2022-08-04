using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Important
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 升序（冒泡排序）
            ///*冒泡排序(将一个数组中的元素从小到大排列)：
            // 1、相邻数字比较，大了就往后移，总共能比（数字个数-1）次；
            // 2、每次比较都能把最大数字排到最后，所以每次至少可以少比一次。*/
            //int[] nums = { 1, 4, 77, 0, 63, 7, 34, 88, 5, 9, 0, 44, 26, 9, 2, 3, 6, 88, 8, 34 };
            ////int temp = 0;
            ////for (int i = 0; i < nums.Length - 1; i++)
            ////{
            ////    for (int j = 0; j < nums.Length - 1 - i; j++)
            ////    {
            ////        if (nums[j] > nums[j + 1])
            ////        {
            ////            temp = nums[j + 1];
            ////            nums[j + 1] = nums[j];
            ////            nums[j] = temp;
            ////        }
            ////    }
            ////}
            ///*等效快捷代码*/
            //Array.Sort(nums);//只能针对数组做升序排列。
            //for (int k = 0; k < nums.Length; k++)
            //{
            //    Console.WriteLine(nums[k]);
            //}
            //Console.ReadKey();
            #endregion
            #region 反转
            //string[] word = { "1", "2", "3", "4", "5" };
            ////string temp = null;
            ////for (int i = 0; i < word.Length / 2; i++)
            ////{
            ////    temp = word[word.Length - i - 1];
            ////    word[word.Length - i - 1] = word[i];
            ////    word[i] = temp;
            ////}
            ///*等效代码*/
            //Array.Reverse(word);
            //for (int j = 0; j < word.Length; j++)
            //{
            //    Console.Write(word[j]);
            //}
            //Console.ReadKey();
            #endregion
            #region 降序(先升序后反转)
            int[] nums = { 1, 4, 77, 0, 63, 7, 34, 88, 5, 9, 0, 44, 26, 9, 2, 3, 6, 88, 8, 34 };
            //int temp1 = 0;
            //int temp2 = 0;
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = 0; j < nums.Length - 1 - i; j++)
            //    {
            //        if (nums[j] > nums[j + 1])
            //        {
            //            temp1 = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp1;
            //        }
            //    }
            //}
            //for (int k = 0; k < nums.Length / 2; k++)
            //{
            //    temp2 = nums[k];
            //    nums[k] = nums[nums.Length - k - 1];
            //    nums[nums.Length - k - 1] = temp2;
            //}
            //for (int l = 0; l < nums.Length; l++)
            //{
            //    Console.WriteLine(nums[l]);
            //}
            //Console.ReadKey();
            ///*等效代码*/
            Array.Sort(nums);
            Array.Reverse(nums);
            for (int k = 0; k < nums.Length; k++)
            {
                Console.WriteLine(nums[k]);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
