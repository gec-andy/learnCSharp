using System;

namespace _02_流程控制之if分支结构
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 取余
            //int num = 128;
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"{num} 是偶数~");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} 不是偶数~");
            //}
            #endregion

            #region 判断用户设定的年份数据是否是闰年
            //int year = 2008;
            //if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            //{
            //    Console.WriteLine($"{year} 是闰年~");
            //}
            //else
            //{
            //    Console.WriteLine($"{year} 不是闰年~");
            //}
            #endregion

            #region 猜数字小游戏
            //int inputNumber = 0, successCount = 0, failedCount = 0;
            //int totalTimes = 0;
            //Random r = new Random();
            //int index = 0;
            //int[] numArray1 = new int[3], numArray2 = new int[3];
            //do
            //{
            //    //失败次数达到3次以上, 直接退出程序
            //    if (failedCount == 3)
            //    {
            //        break;
            //    }
            //    //没有则继续猜
            //    //接收用户的输入
            //    inputNumber = Convert.ToInt32(Console.ReadLine());
            //    int tempNumber = r.Next(1, 4);
            //    if (inputNumber == tempNumber)
            //        successCount++;
            //    else
            //        failedCount++;
            //    numArray1[index] = inputNumber;
            //    numArray2[index] = tempNumber;
            //    index++;
            //    totalTimes++;
            //    if (totalTimes >= 3)
            //    {
            //        break;
            //    }
            //} while (true);
            //Console.WriteLine($"猜测成功次数：{successCount}, 猜测失败次数：{failedCount}");
            //Console.WriteLine("用户输入的数字");
            //for (int i = 0; i < numArray1.Length; i++)
            //{
            //    Console.WriteLine(numArray1[i]);
            //}
            //Console.WriteLine("系统随机生成的数字");
            //for (int i = 0; i < numArray2.Length; i++)
            //{
            //    Console.WriteLine(numArray2[i]);
            //}
            #endregion

            Console.ReadKey();
        }
    }
}
