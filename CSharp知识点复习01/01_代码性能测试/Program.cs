using System;

namespace _01_代码性能测试
{
    class Program
    {
        static void Main(string[] args)
        {
            int longNumber = 100000;
            long startTime, endTime;
            startTime = DateTime.Now.Ticks;
            for (int i = 0; i < longNumber; i++)
            {

            }
            endTime = DateTime.Now.Ticks;
            Console.WriteLine((endTime - startTime).ToString());
            Console.ReadKey();
        }
    }
}
