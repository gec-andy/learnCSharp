using System;
using System.Collections;
using System.IO;
using System.Text;
namespace _05_面向对象之类
{
    class Program
    {
        static void Main(string[] args)
        {

            //CHuman human = new CHuman();
            //human.name = "张三";
            //human.age = 14;
            //human.DisplayInfo();

            //CDictionary dict = new CDictionary();
            //dict[0] = "这是第一个~";
            //dict[1] = "这是第二个~";
            //Console.WriteLine(dict[0]);
            //Console.WriteLine(dict[1]);

            Console.ReadKey();
        }

    }


    public struct CDictionaryItem
    {
        private string key, description;
    }
    public class CDictionary
    {
        private CDictionaryItem item;
        private ArrayList array = new ArrayList();
        public object this[int index]
        {
            get
            {
                return this.array[index];
            }
            set
            {
                this.array.Add(value);
                this.array[index] = value;
            }
        }
    }

    public class CHuman
    {
        public string name;
        public int age;
        public CHuman() : this(string.Empty, 18)
        {

        }
        public CHuman(string name) : this(name, 18) { }
        public CHuman(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{this.name}， {this.age}");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Person()
        {

        }
        public Person(string name, int age, string address)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }
    }

    public interface ITellPhoneable
    {
        void Call();
        void Close();
    }
    public abstract class TellPhone : ITellPhoneable
    {
        public string LogoTheme { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        public void Call()
        {
            Console.WriteLine($"{LogoTheme} 品牌的 {Name} 正在使用 电话号码 {Number} 进行打电话");
        }

        public void Close()
        {
            Console.WriteLine($"{Name}  正在关机...............");
        }
    }
    public class MbilePhone : TellPhone { }
}
