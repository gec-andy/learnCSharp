using System;

namespace _07_01_设计模式之单例设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.ReadKey();
        }
    }

    public class SingleObject
    {
        private static SingleObject _instance;
        private SingleObject() { }
        public static SingleObject Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingleObject();
                }
                return _instance;
            }
        }
    }
    public class Person
    {
        private static Person _instance;
        public static Person Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Person();
                }
                return _instance;
            }
        }
    }
    public class Student : Person
    {
        public Student()
        {
            Person ins = Person.Instance;
            Person ins1 = Person.Instance;
            Console.WriteLine(object.ReferenceEquals(ins, ins1));
        }
    }
}
