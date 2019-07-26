using System;

namespace _02_01_模拟计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //string inputStr = Console.ReadLine();
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int result = Compute(inputStr, number1, number2);
            //Console.WriteLine(result);

            //使用工厂模式进行封装之后的处理
            int result = Factory.Calculate(new Increment(), 10, 20);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        /// <summary>
        /// 面向过程的处理方式
        /// </summary>
        /// <param name="inputStr"></param>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        private static int Compute(string inputStr, int number1, int number2)
        {
            switch (inputStr)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
            }
            return -1;
        }
    }
    public static class Factory
    {
        public static int Calculate(Compute compute, int leftNumber, int rightNumber)
        {
            return compute.Calculate(leftNumber, rightNumber);
        }
    }
    public abstract class Compute
    {
        public abstract int Calculate(int leftNumber, int rightNumber);
    }
    public class Increment : Compute
    {
        public override int Calculate(int leftNumber, int rightNumber)
        {
            return leftNumber + rightNumber;
        }
    }
    public class Decrement : Compute
    {
        public override int Calculate(int leftNumber, int rightNumber)
        {
            return leftNumber - rightNumber;
        }
    }
    public class Muitl : Compute
    {
        public override int Calculate(int leftNumber, int rightNumber)
        {
            return leftNumber * rightNumber;
        }
    }
    public class Divide : Compute
    {
        public override int Calculate(int leftNumber, int rightNumber)
        {
            return leftNumber / rightNumber;
        }
    }
}
