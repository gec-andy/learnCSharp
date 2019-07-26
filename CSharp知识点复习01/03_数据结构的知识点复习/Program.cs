using System;
using System.Collections.Generic;

namespace _03_数据结构的知识点复习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数组的使用
            //int[] arr = { 3, 6, 9, 0, 3, 2, 5, 6, 7, 8 };
            //int sum = 0, max = arr[0], min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (max < arr[i])
            //    {
            //        max = arr[i];
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (min > arr[i])
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"最大值：{max} 最小值：{min} 和：{sum}");

            // MultiRankArrraay();

            //string[] months = new string[] {
            //    "一月","二月","三月","四月","五月","六月",
            //    "七月","八月","九月","十月","十一月","十二月"
            //};
            //foreach (var month in months)
            //{
            //    Console.WriteLine(month);
            //}

            #region 使用数组模拟搭配三明治
            //Random r = new Random();
            //string[] meats = new string[] { "红烧肉", "牛肉", "猪头肉" };
            //string[] miscells = new string[] { "红油", "黄油", "芝麻酱" };
            //string[] breads = new string[] { "切片", "曲奇" };
            //string strMeatRandom = meats[r.Next(0, meats.Length)];
            //string strMiscellRandom = miscells[r.Next(0, miscells.Length)];
            //string strrBreadRandom = breads[r.Next(0, breads.Length)];
            //Console.WriteLine($"三明治配方：{strMeatRandom},{strMiscellRandom},{strrBreadRandom}");
            #endregion

            #endregion

            #region ArrayList 的使用
            //var array = new ArrayList() { 1, 3, 3, 4, 5 };
            //array.Add("hello world~");
            //array.Add("你好, 世界~");
            //array.RemoveAt(0);
            //Console.WriteLine(array.Count);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Dictionary
            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(0, "零");
            //dict.Add(1, "一");
            //foreach (KeyValuePair<int, string> item in dict)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}
            #endregion

            #region Example 1_将两个集合中重复的数据合并到一个新的集合中去
            //List<string> strList1 = new List<string>() { "a", "b", "c", "d", "e" };
            //List<string> strList2 = new List<string>() { "d", "e", "f", "g", "h" };
            //foreach (string str in strList2)
            //{
            //    if (!strList1.Contains(str))
            //        strList1.Add(str);
            //}
            //foreach (string str in strList1)
            //{
            //    Console.WriteLine(str);
            //}
            #endregion

            #region Example_2_随机生成十个数字（0-100）且不能够重复
            //Random r = new Random();
            //List<int> list = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    int temp = r.Next(0, 100);
            //    if (!list.Contains(temp))
            //    {
            //        list.Add(temp);
            //    }
            //    else
            //    {
            //        i++;
            //    }
            //}
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Example_3_将一个集合中的奇数和偶数分别放到另一个集合中
            List<int> myInts = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> jis = new List<int>();
            List<int> ous = new List<int>();
            foreach (var item in myInts)
            {
                if (item % 2 == 0)
                    ous.Add(item);
                else
                    jis.Add(item);
            }
            jis.AddRange(ous);
            foreach (int item in jis)
                Console.Write(item);
            #endregion
            Console.ReadKey();
        }
        private static void MultiRankArrraay()
        {
            int[,] array = new int[5, 5];//构建一个5*5的二维数组
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                // array[i, i] = r.Next(0, 100);
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = i * j;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }
        private static void SimpleArray()
        {
            int[] array = new int[3] { 1, 2, 3 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void Sort(int[] array)
        {

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public Person()
        {

        }
        public Person(string firstName, string lastName, int age, string emailAddress, string homeAddress)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.EmailAddress = emailAddress;
            this.HomeAddress = homeAddress;
        }
        public int CompareTo(object obj)
        {
            Person person = obj as Person;
            int resultValue = -1;
            if (person != null)
            {
                if ((this.FirstName != null && this.LastName != null))
                {
                    resultValue = string.Compare(this.FirstName, person.FirstName, true);
                    resultValue = string.Compare(this.LastName, person.LastName, true);
                }
            }
            return resultValue;
        }
    }
}
