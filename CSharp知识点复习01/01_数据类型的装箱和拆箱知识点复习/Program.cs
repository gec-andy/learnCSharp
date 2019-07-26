using System;

namespace _01_数据类型的装箱和拆箱知识点复习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 实例一
            long startTime, endTime;
            const int check_number = 10000;
            int num1 = 0, num2 = 200, num3 = 500;
            startTime = DateTime.Now.Ticks;
            for (int i = 0; i < check_number; i++)
            {
                num1 += num2 + num3;
            }
            endTime = DateTime.Now.Ticks;
            Console.WriteLine(endTime - startTime);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
            startTime = 0;
            endTime = 0;
            object sum = 0, oNumber1 = 500, oNumber2 = 200;
            startTime = DateTime.Now.Ticks;
            for (int i = 0; i < check_number; i++)
            {
                sum = (int)((int)oNumber1 + (int)oNumber2);
            }
            endTime = DateTime.Now.Ticks;
            Console.WriteLine(endTime - startTime);
            #endregion

            Console.ReadKey();
        }
    }
}
