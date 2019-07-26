using System;

namespace CSharp知识点复习01
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number1 = 10;
            //int[] array = { 1, 1, 2, 3, 4, 5 };
            //int[] array1 = new int[4];
            //Random r = new Random();
            //for (int i = 0; i < 4; i++)
            //{
            //    int temp = r.Next(0, 10);
            //    array1[i] = temp;
            //}
            //if (array1.Length > 0)
            //{
            //    Console.WriteLine("数组的元素个数大于0");
            //    for (int i = 0; i < array1.Length; i++)
            //    {
            //        Console.WriteLine(array1[i] + "\r\n");
            //    }
            //}
            //Console.WriteLine("dawdaw");
            //Console.WriteLine("");
            //Console.WriteLine(number1);

            Person p1 = new Person();
            p1.Name = "张三";
            p1.Sex = "男";
            p1.Age = 10;
            Person p2 = new Person()
            {
                Name = "李四",
                Sex = "男",
                Age = 50
            };
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine("\r\n");
            p1.Talking(p2);

            Console.ReadKey();
        }
    }

    public class Person
    {
        private string _name;
        private string _sex;
        private int _age;
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public string Sex
        {
            get
            {
                return this._sex;
            }
            set
            {
                this._sex = value;
            }
        }
        public int Age
        {
            get
            {
                return this._age;
            }
            set { this._age = value; }
        }

        public Person() { }
        public Person(string name, string sex) { }
        public Person(string name, string sex, int age) { }
        public void Talking(Person target)
        {
            Console.WriteLine("你当前正在和 " + target.Name + " 对话~");
        }
        public override string ToString()
        {
            return this.Name + " " + this.Sex + " " + this.Age.ToString();
        }
    }
}
