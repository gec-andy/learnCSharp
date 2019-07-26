using System;

namespace _04_算法之冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 4541, 14, 112, 241, 142, 132, 54, 156, 6, 3, 49, 1 };
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
        }
    }
}
