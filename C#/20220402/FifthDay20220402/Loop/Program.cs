using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region 1打印100遍“下次考试我一定细心！”
            //int temp1 = 0;
            //while (temp1<100)
            //{
            //    Console.WriteLine("下次考试我一定细心！");
            //    temp1++;
            //}
            //Console.ReadKey();
            //#endregion
            //#region 求1到100之间所有整数的和。
            //int temp2 = 1;
            //int sum1 = 0;
            //while (temp2 <= 100)
            //{
            //    sum1 += temp2;
            //    temp2++;
            //}
            //Console.WriteLine(sum1);
            //Console.ReadKey();
            //#endregion
            #region 求1到100之间所有偶数的和。
            int temp3 = 1;
            int sum2 = 0;
            while (temp3 <= 100)
            {
                if (temp3 % 2 == 0)//基数：temp3%2!=0
                {
                    sum2 += temp3;
                }
                temp3++;
            }
            Console.WriteLine(sum2);
            Console.ReadKey();
            #endregion
        }
    }
}
