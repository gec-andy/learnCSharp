using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_递归知识点复习
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                int tempNumber = Add(Add(i));
            }
            Console.ReadKey();
        }
        static int Add(int i)
        {
            if (i < 10)
            {
                Console.WriteLine(i.ToString());
                i++;
            }
            return i;
        }
    }
}
