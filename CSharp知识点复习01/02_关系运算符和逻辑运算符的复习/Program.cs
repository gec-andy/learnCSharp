using System;

namespace _02_关系运算符和逻辑运算符的复习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 运算符测试
            //从控制台接收用户输入的三个数字,并进行比较大小
            //int firstNumber = Convert.ToInt32(Console.ReadLine()),
            //    secondNumber = Convert.ToInt32(Console.ReadLine()),
            //    thirdNumber = Convert.ToInt32(Console.ReadLine());

            //int maxNumber = firstNumber;//把第一个数作为比较的基础数
            //if (CheckMaxNumber(maxNumber, secondNumber))//判断第一个和第二个谁是最大的
            //{
            //    //第一个打, 再与第三个数进行比较
            //    if (!CheckMaxNumber(maxNumber, thirdNumber))
            //        maxNumber = thirdNumber;
            //}
            //else
            //{
            //    maxNumber = secondNumber;
            //    if (!CheckMaxNumber(maxNumber, thirdNumber))
            //        maxNumber = thirdNumber;
            //}
            //Console.WriteLine("最大数为" + maxNumber);


            ////判断用户输入的年份数据是不是闰年
            //int year = Convert.ToInt32(Console.ReadLine());
            ////如果可以除尽 400 代表就是闰年, 或者对4取余可以除尽且对100取余除不尽则表示是闰年
            //if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            //    Console.WriteLine($"{year} 是闰年~");
            //else
            //    Console.WriteLine($"{year} 不是闰年~"); 
            #endregion

            #region 判断用户输入的年份是不是闰年
            //int year = Convert.ToInt32(Console.ReadLine());
            //if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            //{
            //    Console.WriteLine($"{year}年是闰年~");
            //}
            //else
            //{
            //    Console.WriteLine($"{year}年不是闰年~");
            //}
            #endregion

            #region 校验用户登录
            //string strUserName = Console.ReadLine(), strPwd = Console.ReadLine();
            //if (strUserName == "admin")
            //{
            //    if (strPwd == "8888")
            //    {
            //        Console.WriteLine("登陆成功~");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码有误,程序退出~");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("账户不存在~");
            //}
            #endregion
            Console.ReadKey();
        }
        /// <summary>
        /// 检查判断左边还是右边的数据参数的大小
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool CheckMaxNumber(int x, int y) => x > y;
    }
}
