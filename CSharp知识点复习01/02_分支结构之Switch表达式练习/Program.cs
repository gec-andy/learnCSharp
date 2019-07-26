using System;

namespace _02_分支结构之Switch表达式练习
{
    /// <summary>
    /// 声明一个自定义的枚举类型用来表示一周的日程
    /// </summary>
    public enum WeekDay
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            //根据用户所输入的数字来进行判断获取用户想要得到的数据
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 0:
                    Console.WriteLine("星期日");
                    break;
                case 1:
                    Console.WriteLine("星期一");
                    break;
                case 2:
                    Console.WriteLine("星期二");
                    break;
                case 3:
                    Console.WriteLine("星期三");
                    break;
                case 4:
                    Console.WriteLine("星期四");
                    break;
                case 5:
                    Console.WriteLine("星期五");
                    break;
                case 6:
                    Console.WriteLine("星期六");
                    break;

            }
            Console.ReadKey();
            //根据用户输入的数据,去对应的数据值,并显示输出到控制台上
            string dayName = Enum.GetName(typeof(WeekDay), day);
            WeekDay weekDay = WeekDay.Sunday;
            Enum.TryParse(dayName, out weekDay);
            switch (weekDay)
            {
                case WeekDay.Sunday:
                    Console.WriteLine("星期日");
                    break;
                case WeekDay.Monday:
                    Console.WriteLine("星期一");
                    break;
                case WeekDay.Tuesday:
                    Console.WriteLine("星期二");
                    break;
                case WeekDay.Wednesday:
                    Console.WriteLine("星期三");
                    break;
                case WeekDay.Thursday:
                    Console.WriteLine("星期四");
                    break;
                case WeekDay.Friday:
                    Console.WriteLine("星期五");
                    break;
                case WeekDay.Saturday:
                    Console.WriteLine("星期六");
                    break;
            }
            Console.ReadKey();
        }
    }
}
