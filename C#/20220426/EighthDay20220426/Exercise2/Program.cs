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
            Random random = new Random();
            int[] nums = new int[10];
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(0, 101);
            }
            for (int j = 0; j < nums.Length - 1; j++)
            {
                for (int k = 0; k < nums.Length - 1 - j; k++)
                {
                    if (nums[k] > nums[k + 1])
                    {
                        temp = nums[k];
                        nums[k] = nums[k + 1];
                        nums[k + 1] = temp;
                    }
                }
            }
            for (int l = 0; l < nums.Length / 2; l++)
            {
                temp = nums[l];
                nums[l] = nums[nums.Length - 1 - l];
                nums[nums.Length - 1 - l] = temp;
            }
            for (int m = 0; m < nums.Length - 1; m++)
            {
                Console.Write(nums[m] + "|");
            }
            Console.WriteLine(nums[nums.Length - 1]);
            Console.ReadKey();
        }
    }
}
