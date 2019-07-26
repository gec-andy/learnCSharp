using System;

namespace _05_数据类型的值类型与引用类型的函数传值
{
    class Program
    {
        static void Main(string[] args)
        {
            //无论是值传递还引用传递 其实解决的都是变量的作用域问题, 也即是研究对象的从出生到死亡的过程。
            //int number = 10;
            //Console.WriteLine(number);//10
            //ValueFunction(number);
            //Console.WriteLine(number);//10
            //Console.WriteLine("~~`");
            //ValueFunctionByRef(ref number);
            //Console.WriteLine(number);
            //Console.WriteLine("~~``·");
            //Console.WriteLine("通过值传递的方式传递引用类型");
            //Person p = new Person() { Age = 3 };
            //Console.WriteLine(p.Age);
            //ReferenceFunction(p);
            //Console.WriteLine(p.Age);
            //Console.WriteLine("_____");
            //Person person1 = new Person() { Age = 2 };
            //Console.WriteLine(person1.Age);
            //ReferenceFunctionByRef(ref person1);
            //Console.WriteLine(person1.Age);
            Console.ReadKey();
        }
        //通过值传递的方式传递值类型
        /// <summary>
        /// 从栈中拷贝一份传递过来的数据,无论在函数中修改还是重新赋值,都不会影响到外边的数据。
        /// </summary>
        /// <param name="number"></param>
        private static void ValueFunction(int number)
        {
            number = 20;
        }
        //通过引用传递的方式传递值类型
        /// <summary>
        /// 从栈中拷贝一份传递过来的数据所对应的地址,在函数中修改或者是重新赋值,通过ref 参数修饰符的修饰作用,则会影响到外边的数据。
        /// </summary>
        /// <param name="number"></param>
        private static void ValueFunctionByRef(ref int number)
        {
            number = 20;
        }
        //通过值传递的方式传递引用类型
        private static void ReferenceFunction(Person person)
        {
            person.Age = 10;
            person = new Person()
            {
                Age = 2
            };
            Console.WriteLine("函数里边的" + person.Age);
        }
        //通过引用传递的方式传递值类型
        private static void ReferenceFunctionByRef(ref Person person)
        {
            person.Age = 5;
            Console.WriteLine(person.Age);
            person = new Person() { Age = 20 };
            Console.WriteLine(person.Age);
        }
    }
    public class Person
    {
        private int _age;
        public int Age { get { return this._age; } set { this._age = value; } }
    }
}
