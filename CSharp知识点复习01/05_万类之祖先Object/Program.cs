using System;
using System.Reflection;

namespace _05_万类之祖先Object
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var loc = new MyLocation()
            //{
            //    X = 10,
            //    Y = 20
            //};
            //Console.WriteLine(loc.ToString());
            //var type = typeof(MyLocation);
            //var members = type.GetMembers();
            //foreach (MemberInfo item in members)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var testType = new MyTest();
            //MyTest.GetString("这是最后执行的函数调用~");


            //Employee employee = new Employee();
            //CheckCast(employee);

            Console.ReadKey();
        }

        private static void CheckCast(object o)
        {
            var employee = o as Employee;
            if (employee == null)
            {
                Console.WriteLine("转换失败~");
            }
            else
            {
                Console.WriteLine("转换成功");
            }
        }
    }

    public class A { }
    public class B : A { }
    public class Employee { }
    public class Manager : Employee { }

    public class MyLocation
    {
        private int x;
        private int y;
        public int X { get { return this.x; } set { this.x = value; } }
        public int Y { get { return this.y; } set { this.y = value; } }
        public override string ToString()
        {
            return this.x + " " + this.y;
        }
    }

    public interface IObjectTestable
    {
        void Test();
    }
    public class MyTest : IObjectTestable
    {
        public static string _fieldStaticString = GetString("初始化静态的字段");
        public string _fieldInstanceString = GetString("初始化实例的字段");
        static MyTest()
        {
            _fieldStaticString = GetString("初始化静态构造函数");
        }
        public MyTest()
        {
            this._fieldInstanceString = GetString("初始化实例构造函数");
        }
        public void Test()
        {
            Console.WriteLine("test~");
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public static string GetString(string message)
        {
            Console.WriteLine(message);
            return message;
        }
    }
}
