using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    //public enum Season
    //{
    //    春,
    //    夏,
    //    秋,
    //    冬
    //}
    //public enum State
    //{
    //    OnLine = 1,
    //    OffLine,
    //    Busy,
    //    Leave
    //}
    //public struct MyColor
    //{
    //    public int _red;
    //    public int _green;
    //    public int _blue;
    //}
    public struct Person
    {
        public string _name;
        public Gender _gender;
        public int _age;
    }
    public enum Gender
    {
        男,
        女
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*枚举试验*/
            //Season season = Season.夏;
            //Console.WriteLine(season);
            //Console.ReadKey();
            /*提示用户选择当前状态，选好以后打印到控制台*/
            //Console.WriteLine("请选择当前状态（输入数字回车选择）：\n1.OnLine\n2.OffLine\n3.Busy\n4.Leave");
            //try
            //{
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    if ((input > 0) && (input < 5))
            //    {
            //        State state = (State)input;
            //        Console.WriteLine("您当前的状态是{0}。", state);
            //        Console.ReadKey();
            //    }
            //    else
            //    {
            //        Console.WriteLine("只能输入1-4！程序退出。");
            //        Console.ReadKey();
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的数字！程序退出。");
            //    Console.ReadKey();
            //}
            /*用MyColor结构调一个红色*/
            //MyColor myColor;
            //myColor._red = 255;
            //myColor._green = 0;
            //myColor._blue = 0;
            /*用结构与枚举列出一个人的名字、年龄、性别*/
            Person person;
            person._name = "陈爱东";
            person._age = 22;
            person._gender = Gender.男;
            Console.WriteLine("姓名：{0}\t性别：{1}\t年龄：{2}", person._name, person._gender, person._age);
            Console.ReadKey();
        }
    }
}
