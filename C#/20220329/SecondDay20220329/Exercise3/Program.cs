using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*圆的面积与周长*/
            #region 圆的面积周长
            int r = 5;
            Console.WriteLine("圆的面积是{0}，周长是{1}。", 3.14 * r * r, 2 * 3.14 * r);
            Console.ReadKey();
            #endregion
            /*买2件T恤和3条裤子，打8.8折*/
            #region T恤和裤子
            double priceTshirt = 35;
            double priceTrousers = 120;
            double payment = 3 * priceTshirt + 2 * priceTrousers;
            Console.WriteLine("小明买了三件T恤两条裤子，应付{0}元。", payment);
            Console.ReadKey();
            payment = payment * 0.88;
            int totalPrice = (int)payment;
            Console.WriteLine("如果打8.8折，应付{0}元", totalPrice);
            Console.ReadKey();
            #endregion
            /*两int变量运算还是int，只要有double类型都转成都变成double。*/
            #region 验证
            int n1 = 10;
            int n2 = 3;
            /*错误演示：double d = n1 / n2;//还是整数，只不过赋给一个double类型的变量*/
            double d = n1 * 1.0 / n2;//*1.0这一步改变了int的类型
            Console.WriteLine(d);
            int n3 = 10;
            double n4 = 3;
            double x = n3 / n4;//运算过程中隐式转换为double
            Console.WriteLine(x);
            Console.WriteLine("{0:0.00}", x);//小数点后保留两位的写法
            Console.ReadKey();
            #endregion
        }
    }
}
