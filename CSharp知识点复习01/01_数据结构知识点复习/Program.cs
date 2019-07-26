using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_数据结构知识点复习
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lisNumber = new List<int>
            {
                10
            };
            Random r = new Random();
            for (int index = 0; index < 10; index++)
            {
                int number = r.Next(0, 100);
                if (!lisNumber.Contains(number))
                {
                    lisNumber.Add(number);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine();
            for (int index = 0; index < lisNumber.Count; index++)
            {
                Console.WriteLine(index + "\n");
            }
            Console.WriteLine();
            Console.WriteLine("九九乘法表");
            for (int i = 1; i < 10; i++)
            {
                for (int a = i; a < 10; a++)
                {
                    Console.Write(i + " * " + a + " = " + i * a + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
      
            Console.ReadKey();
        }
    }

    
}
