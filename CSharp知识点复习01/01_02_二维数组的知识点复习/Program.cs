using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_02_二维数组的知识点复习
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 2;
            int col = 3;
            int[,] numbers = new int[row, col];
            numbers[0, 0] = 10;
            numbers[0, 1] = 20;
            numbers[0, 2] = 30;

            numbers[1, 0] = 59;
            numbers[1, 1] = 66;
            numbers[1, 2] = 88;

            int maxNumber = numbers[0, 1];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] > maxNumber) {
                        maxNumber = numbers[i, j];
                    }
                }
            }
            Console.WriteLine(maxNumber);
            Console.ReadKey();
        }
    }
}
