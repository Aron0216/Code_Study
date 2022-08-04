using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 跪键盘大于60分钟晚饭不用做
            Console.WriteLine("你今晚跪键盘几分钟呀？");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("跪{0}分钟，请问老婆大人我还需要做饭吗？", min);
            Console.ReadKey();
            if (min <= 60)
            {
                Console.WriteLine("要！");
            }
            if (min > 60)
            {
                Console.WriteLine("不用啦！Darling~我来做饭饭吧！");
            }
            Console.ReadKey();
            #endregion
            #region 是否到达法定结婚年龄(23)？(粗略)
            C
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 23)
            {
                Console.WriteLine("您已到达法定结婚年龄！");
            }
            if (age <= 23)
            {
                Console.WriteLine("您未到达法定结婚年龄！");
            }
            Console.ReadKey();
            #endregion
            #region 成绩奖励零花钱
            /*以下条件二者满足其一即可奖励100元：1)语文大于90且音乐大于80；2）语文等于100且音乐大于70.*/
            Console.WriteLine("你语文考了几分？");
            double Chinese = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("你音乐考了几分？");
            double Music = Convert.ToDouble(Console.ReadLine());
            if (((Chinese > 90) && (Music > 80)) || ((Chinese == 100) && (Music > 70)))
            {
                Console.WriteLine("你真棒！奖励100元！");
            }
            if ((((Chinese > 90) && (Music > 80)) || ((Chinese == 100) && (Music > 70))) == false)
            {
                Console.WriteLine("下次再接再厉！");
            }
            Console.ReadKey();
            #endregion
            #region 用户名、密码输入（admin、mypass）
            Console.WriteLine("Please input the UserName:");
            string userName = Console.ReadLine();
            if (userName == "admin")
            {
                Console.WriteLine("Please input the Password:");
                string password = Console.ReadLine();
                if (password == "mypass")
                {
                    Console.WriteLine("Enter!");
                }
                if (password != "mypass")
                {
                    Console.WriteLine("Wrong password!");
                }
            }
            if (userName != "admin")
            {
                Console.WriteLine("The username doesn't exist!");
            }
            Console.ReadKey();
            #endregion
            #region if-elseif-else
            Console.WriteLine("请输入成绩：");
            double score = Convert.ToDouble(Console.ReadLine());
            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("等地A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("等地B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("等地C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("等地D");
            }
            else
            {
                Console.WriteLine("等地E");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
