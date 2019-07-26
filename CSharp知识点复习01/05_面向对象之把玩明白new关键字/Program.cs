using System;

namespace _05_面向对象之把玩明白new关键字
{
    class Program
    {
        static void Main(string[] args)
        {
            //New 关键字三种用途
            //1. 构建对象

            Person person = new Person() { Name = "张三", Gender = "男", Age = 20 };
            //2. 子类隐藏基类内容
            //3. 声明构建自定义泛型类时的类型替换先决条件
        }
    }
    /// <summary>
    /// 声明自己的泛型类 where 为限制条件, 这个限制条件使用 new 关键字表示T 如果要进行替换类型,则必须使用带有构造函数的数据类型才能进行替换使用
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyGenricClass<T> where T : new()
    {
        public MyGenricClass(T t) { }
        public T test { get; set; }
        public T GetItem()
        {
            return new T();
        }
    }
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"姓名：{Name}，性别：{Gender}，年龄：{Age}");
        }
    }

    public class Number
    {
        public static int number = 123;
        public void DiscoverInfo() { Console.WriteLine("这是数字的基类~"); }
        public void ShowNumber() { Console.WriteLine($"父类：{number}"); }
    }
    public class INTNumber : Number
    {
        new public virtual void DiscoverInfo() { Console.WriteLine("这是子类隐藏了父类的函数~"); }
        new public virtual void ShowNumber() { Console.WriteLine($"子类：{number}"); }

    }
}
