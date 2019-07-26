using System;

namespace _01_数据类型的知识点复习
{
    public enum GameState
    {
        GameReset,
        GameStart,
        GameEnd,
        GameSuccess,
        GameFailed
    }
    public enum EmployeeType
    {
        Manager,
        Grunt,
        Contractor,
        VicePresident
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 基本的数据类型
            //int number = 10;//整数数据类型
            //float fNumber = 5.0f;//单精度浮点小数类型
            //double dNumber = 2.0f;//双精度浮点小数类型
            //decimal deNumber = 2;//数字货币数据类型

            //string str = "hello world";//一连串字符数据类型
            //char c = ',';//单字符数据类型

            //byte buffer = 22;//字节数据类型
            //short s = 2;//短整形 

            //声明创建基本的数据类型
            //int number = 3;
            //Console.WriteLine(number.ToString());
            //const int maxNumber = 100;
            //Console.WriteLine(maxNumber.ToString());
            //float width = 800, height = 600;
            //float newWidth = 500, newHeight;
            //newHeight = newWidth / (width / height);
            //Console.WriteLine(width + " " + height);
            //Console.WriteLine(newWidth + " " + newHeight);

            #region 算数溢出检查
            //checked
            //{
            //    long number = 10000000000000;
            //    try
            //    {
            //        int num = (int)number;
            //        if (num >= int.MaxValue)
            //            num = int.MaxValue;
            //        Console.WriteLine(num);
            //    }
            //    catch (Exception exception)
            //    {
            //        Console.WriteLine(exception.Message);
            //    }
            //}

            //int firstNumber = 100000000;
            //int secondNumber = 10000000;
            //int result = checked(firstNumber * secondNumber);
            //Console.WriteLine(result);
            //int firstNumber1 = 10000;
            //int secondNUmber = 11111111;
            //int result1 = unchecked(firstNumber1 * secondNUmber);
            #endregion

            #endregion

            #region 自定义数据类型
            //MySturct myStruct = new MySturct(10);
            //MyClass myClass = new MyClass(5);
            //Console.WriteLine(myStruct.Number);
            //Console.WriteLine(myClass.Number);
            //int testNumber = 3;
            //test1(ref testNumber);
            //Console.WriteLine(testNumber);
            //test2(out testNumber);
            //Console.WriteLine(testNumber);
            //string str = "hello world";
            //test3(ref str);
            //Console.WriteLine(str);

            //MyClass myClass1 = new MyClass(5);
            //MyClass myClass2 = new MyClass(3);
            //MyClass myClass3;
            //MyClass myClass4;
            //myClass4 = myClass1;
            //myClass3 = myClass1;
            //Console.WriteLine(myClass2.Number);
            ////以下三个对象都隶属于一个对象，其他的只不过是拷贝那个对象所对应的引用（在堆中存储的对象引用）
            //Console.WriteLine(myClass1.Number);
            //Console.WriteLine(myClass3.Number);
            //Console.WriteLine(myClass4.Number); 
            #endregion

            #region 枚举类型的使用
            ////声明创建游戏状态
            //GameState state = GameState.GameReset;
            ////判断游戏状态
            //switch (state)
            //{
            //    case GameState.GameReset:
            //        Console.WriteLine("重置游戏~");
            //        break;
            //    case GameState.GameStart:
            //        Console.WriteLine("游戏开始~");
            //        break;
            //    case GameState.GameEnd:
            //        Console.WriteLine("游戏结束~");
            //        break;
            //    case GameState.GameSuccess:
            //        Console.WriteLine("游戏成功~");
            //        break;
            //    case GameState.GameFailed:
            //        Console.WriteLine("游戏失败~");
            //        break;
            //}
            #endregion

            #region 结构体的应用
            //Point point = new Point();
            //point.Increment();
            //point.Increment();
            //point.Increment();
            //point.Increment();
            //point.Increment();
            //point.Increment();
            //point.Increment();
            //point.Increment();

            //point.Decrement();
            //point.Decrement();
            //point.Decrement();

            //point.Display();
            #endregion

            #region 值类型与引用类型内存分配的情况
            MyClass myClass = new MyClass(10);
            MySturct myStruct = new MySturct(10);
            Console.WriteLine(myClass.Number);
            Console.WriteLine(myStruct.Number);
            MyClass myClass1 = myClass;
            MySturct myStruct1 = myStruct;
            myClass1.Number = 20;
            myStruct1.Number = 40;

            Console.WriteLine(myClass.Number);
            Console.WriteLine(myClass1.Number);

            Console.WriteLine(myStruct.Number);
            Console.WriteLine(myStruct1.Number);
            #endregion
            Console.ReadKey();
        }

        static void test1(ref int number)
        {
            number = 5;
        }
        static void test2(out int number)
        {
            number = 10;
        }
        static void test3(ref string str)
        {
            str = "这是在函数中修改过的字符串~";
        }
    }


    public struct MySturct
    {
        public int Number;
        /// <summary>
        /// 结构体中所声明的字段或者变量,必须在构造函数中进行赋值操作,否则会报错。
        /// </summary>
        /// <param name="number"></param>
        public MySturct(int number)
        {
            this.Number = number;
        }
    }
    public class MyClass
    {
        public int Number;
        public MyClass(int number)
        {
            this.Number = number;
        }
    }



}
