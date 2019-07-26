using System;

namespace _03_Lamba表达式复习
{
    public delegate int Addtional(int leftNumber, int rightNumber);
    class Program
    {
        static void Main(string[] args)
        {
            //Action<int> a = (b) => { Console.WriteLine(b); };
            //a(10);
            //Func<int, int, int> test = delegate (int a, int b) { return a + b; };
            //int result = test(10, 5);
            //Console.WriteLine(result);
            int firstNumber = 5;
            int secondNumber = 10;
            int result = Addtional((int a, int b) => a + b, firstNumber, secondNumber);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static int Addtional(Addtional aa, int leftNumber, int rightNumber)
        {
            return aa(leftNumber, rightNumber);
        }
    }
}
