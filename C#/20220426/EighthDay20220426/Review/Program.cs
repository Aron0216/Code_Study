using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 9, 6, 8, 3, 1, 4, 2, 5, 7, 0 };
            /*1冒泡排序法*/
            //int temp1 = 0;
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
            //for (int k = 0; k < nums.Length; k++)
            //{
            //    Console.Write(nums[k] + "\t");
            //}
            //Console.ReadKey();
            /*2反转*/
            //int temp2 = 0;
            //for (int l = 0; l < nums.Length / 2; l++)
            //{
            //    temp2 = nums[l];
            //    nums[l] = nums[nums.Length - 1 - l];
            //    nums[nums.Length - 1 - l] = temp2;
            //}
            //for (int k = 0; k < nums.Length; k++)
            //{
            //    Console.Write(nums[k] + "\t");
            //}
            //Console.ReadKey();
            /*3升序*/
            int temp1 = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        temp1 = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp1;
                    }
                }
            }
            for (int l = 0; l < nums.Length / 2; l++)
            {
                temp1 = nums[l];
                nums[l] = nums[nums.Length - 1 - l];
                nums[nums.Length - 1 - l] = temp1;
            }
            string temp2 = "|";
            for (int k = 0; k < nums.Length - 1; k++)
            {
                Console.Write(nums[k] + temp2);
            }
            Console.WriteLine(nums[nums.Length - 1]); ;
            Console.ReadKey();
        }
    }
}
