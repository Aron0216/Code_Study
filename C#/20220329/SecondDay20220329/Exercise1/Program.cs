using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    /// <summary>
    /// 酒店登记表
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 酒店登记表的主函数
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 主函数的内容
            char lastName = '陈';//定义姓
            String firstName = "爱东";//定义名
            int age = 22;//定义岁数
            String eMail = "aron216@163.com";//邮箱
            String address = "上海市南塘浜路18弄6号702室";//地址
            decimal income = 5000m;//定义收入
            Console.WriteLine("我叫" + lastName + firstName + "，我住在" + address + "，我今年" + age + "岁了，我的邮箱是" + eMail + "，我的工资有" + income + "。");//打印
            Console.WriteLine("我叫{0}{1}，我住在{2}，我今年{3}岁了，我的邮箱是{4}，我的工资有{5}。",lastName,firstName,address,age,eMail,income);//占位符打印
            Console.ReadKey();//等待一个按键
            #endregion
        }
    }
}
