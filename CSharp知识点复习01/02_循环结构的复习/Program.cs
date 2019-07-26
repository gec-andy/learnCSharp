using System;

namespace _02_循环结构的复习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 求100以内所有整数的和
            //1 -> 100(101)
            //int sum = 0;
            //for (int i = 1; i < 101; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion
            //Console.ReadKey();
            #region 输出100以内为偶数的数字
            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            // Console.ReadKey();
            #region 求出1000以内百分位和十分位以及个分位累加为7的数字
            //int totalNumber = 1000;
            //for (int i = 0; i < totalNumber; i++)
            //{
            //    int hunder = i / 100;
            //    // 对10取余就是取出十分位 对100取余就是取出百分位
            //    int ten = i % 10;
            //    int single = (i / 100) % 10;
            //    if ((hunder + ten + single) == 7)
            //        Console.WriteLine(i);
            //}
            #endregion
            #region 接收用户的输入,如果输入的数字小于0 程序结束运行
            //Console.WriteLine("请输入一个数字:");
            //int inputNumber = Convert.ToInt32(Console.ReadLine());
            //while (true)
            //{
            //    if (inputNumber < 0)
            //        break;
            //    else
            //    {
            //        Console.WriteLine("请输入一个数字:");
            //        inputNumber = Convert.ToInt32(Console.ReadLine());
            //        continue;
            //    }
            //}
            //Console.WriteLine("您输入的数字小于0,程序结束~");
            #endregion
            #region 求出100以内可以整除3的数字
            //int totalNumber = 100;
            //for (int i = 0; i < totalNumber; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 求出100以内不能被7整除的数字
            //int totalNumber = 100;
            //for (int i = 0; i < totalNumber; i++)
            //{
            //    if (i % 7 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 求出1-100之间奇数累加的和
            int totalNumber = 100;
            int sum = 0;
            for (int i = 1; i < totalNumber + 1; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            #endregion
            Console.ReadKey();
        }
    }
}
