using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_委托知识点复习
{
    public delegate int TestDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate test = new TestDelegate((int a, int b) => { return a + b; });
            int result = test(10, 5);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
