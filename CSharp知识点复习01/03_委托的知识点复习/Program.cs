using System;
using System.Collections.Generic;
using System.Threading;

namespace _03_委托的知识点复习
{
    public delegate void RandomDelegate(int minNumber, int maxNumber);
    public delegate void UnitDelegate();

    public delegate int BinaryOb(int x, int y);
    class Program
    {
        private static event Action<string> PlayMusicEvent;
        private static void OnPlayMusic(string musicName)
        {
            Console.WriteLine("开始播放音乐：" + musicName);
            Console.WriteLine("映山红那个花开的");
            Console.WriteLine("....................");
            Console.WriteLine("....................");
            Console.WriteLine(".......映山红那个花开的..");
            Console.WriteLine("....................");
            Console.WriteLine("......映山红那个花开的........");
        }
        private static void OnStopMusic(string musicName)
        {
            Console.WriteLine("停止播放音乐：" + musicName);
        }
        /*
            猫和老鼠{
                猫咪靠近老鼠洞附近,一窝老鼠感到很是不安,开始慌乱的跑起来,房子主人被吵醒
            }
            老鹰与小鸡{
                老鹰从天上飞下来,小鸡被吓得逃窜,狗看见小鸡逃窜,开始叫了起来
            }
             */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 匿名函数的使用
            //RandomDelegate rDelegate = (min, max) =>
            //{
            //    Console.WriteLine(new Random().Next(min, max));
            //};
            //rDelegate(10, 20);
            //rDelegate += (min, max) => Console.WriteLine(new Random().Next(min, max));
            //rDelegate(3, 6);

            //rDelegate += delegate (int min, int max)
            //{
            //    Console.WriteLine(new Random().Next(min, max));
            //};
            #endregion

            #region 观察者模式之猫和老鼠
            ////构建一个猫的实例对象
            //Cat cat = new Cat()
            //{
            //    Name = "汤姆"
            //};
            ////使用 for 循环来构建一些要进行模拟实验的老鼠对象
            //for (int i = 0; i < 10; i++)
            //{
            //    //创建老鼠对象并将猫这个实例对象作为参数传递给每只老鼠的构造函数中进行存储
            //    Mouse mouse = new Mouse(cat)
            //    {
            //        Name = i + "老鼠~"//每个老鼠的名字使用当前 for 循环所遍历到索引值进行命名操作。
            //    };
            //    //向构建好的委托对象进行多播委托的赋值操作。
            //    cat.test += mouse.Go;
            //}
            ////在进行多播委托的过程中,如果委托类型包含返回值,则只会取得最后一次的结果,至于前边的结果,委托对象则不会进行采用。
            //cat.test += () => { Console.WriteLine("这是最后使用Lamba表达式所添加的委托对象~"); };
            //Person person = new Person();
            //cat.test += person.Break;
            ////在构建好委托类型的实例对象后,进行调用委托对象所指向的所有方法体,则就是触发一系列相关的操作。
            ////也就是通过委托实例对象来间接的调用一些方法。
            //cat.Scream();
            ////Person person = new Person();
            ////person.Break(); 
            #endregion

            #region Framework 中的两种委托类型的使用

            #region Example 1
            ///*
            //     在.NET 的框架中提供了两种基本的委托类型
            //     1.Action 不带返回值, 可以有参数, 也可以没有参数
            //     2.Func 带返回值 泛型的类型参数最后一个为委托类型的返回值
            //  */
            //// Action 委托类型的应用
            //Action action = () =>
            //{
            //    Console.WriteLine("Action 委托类型的运用");
            //};
            //action();
            //// Func 委托类型的应用
            //Func<int, int, int> func = delegate (int a, int b) { return a + b; };
            //int result = func(10, 4);
            //Console.WriteLine(result);  
            #endregion

            #region Example 2
            //Action<int, string, string, int> myAction = (x, y, z, w) =>
            //{
            //    Console.WriteLine($"{x} {y} {z} {w}");
            //};
            //myAction(10, "hello", "world", 10);

            //Func<int, int, int> myFunc = (leftNumber, rightNumber) => leftNumber + rightNumber;
            //int result = myFunc(10, 5);
            //Console.WriteLine(result);

            //Func<string, string, string> myFunc1 = (s, s1) => s + s1;
            //Console.WriteLine(myFunc1("hello", "world~"));
            #endregion

            #endregion

            #region 委托的使用
            //ClaaassWitthDelegate test = new ClaaassWitthDelegate();
            //FirstSubscribeer first = new FirstSubscribeer();
            //first.Subscribe(test);
            //test.Run();
            #endregion

            #region 多播委托的使用

            #endregion

            #region Example 1
            //BinaryOb binaary = (a, b) => a + b;
            //if (binaary != null)
            //{
            //    int result = binaary(10, 20);
            //    Console.WriteLine(result);
            //    binaary += (x, y) => x + y;
            //    result = binaary.Invoke(3, 5);
            //    Console.WriteLine(result);
            //    Delegate[] des = binaary.GetInvocationList();
            //    foreach (Delegate de in des)
            //    {
            //        Console.WriteLine($"函数名称：{de.Method.Name}");
            //    }
            //}
            #endregion

            #region Example 2 模拟小汽车相关的事件
            //Car car = new Car("小轿车", 20, 100);
            //car.AboutToBlow += (sender, message) => Console.WriteLine(message.Message);
            //car.ExplodedEvent += (sender, message) => Console.WriteLine(message.Message);
            //for (int i = 0; i < 101; i++)
            //{
            //    Thread.Sleep(1500);
            //    car.Accelerate(i);
            //    Thread.Sleep(500);
            //}
            #endregion

            #region Example 3
            //Thread thread = new Thread(() => { Console.WriteLine("开始干活哦~"); });
            //thread.Start();

            //Thread.Sleep(1000);
            //List<int> myInts = new List<int>() { 1, 2, 34, 56, 789, 99, 55, 5, 22222 };

            //int myint = myInts.RemoveAll(num => num > 100);
            //Console.WriteLine(myint);
            //Console.WriteLine("~~~~");
            //foreach (int item in myInts)
            //    Console.WriteLine(item);

            // SayHi("张三", ChineseSayHi);
            #endregion

            #region Example 4
            //Console.WriteLine("按下开始播放音乐的按钮");
            //Console.WriteLine("开始播放音乐");
            //Program.PlayMusicEvent += Program.OnPlayMusic;
            //Program.PlayMusicEvent("映山红");
            //Thread.Sleep(3000);
            //Program.PlayMusicEvent -= Program.OnPlayMusic;
            //Console.WriteLine("5");
            //Console.WriteLine("4");
            //Console.WriteLine("3");
            //Console.WriteLine("2");
            //Console.WriteLine("1");
            //Console.WriteLine("按下停止播放音乐按钮");
            //Program.PlayMusicEvent += Program.OnStopMusic;
            //Program.PlayMusicEvent("映山红");
            #endregion
            Console.ReadKey();
        }

        private static void SayHi(string name, Action<string> acttion)
        {
            acttion(name);
        }
        private static void ChineseSayHi(string name)
        {
            Console.WriteLine("中国人对" + name + "说你好");
        }
        private static void JapenesSayHi(string name)
        {
            Console.WriteLine("日本人对" + name + "说你好");
        }
    }
    #region 模拟观察者模式 之 猫和老鼠的案例
    /*
猫和老鼠的委托方式实现
*/
    /// <summary>
    /// 声明构建好一个动物类型的抽象基类
    /// </summary>
    public abstract class Aninmal
    {
        /// <summary>
        /// 抽象出的共性属性
        /// </summary>
        public string Name { get; set; }
    }
    /// <summary>
    /// 一个模拟老鼠的类型
    /// </summary>
    public class Mouse : Aninmal
    {
        /// <summary>
        /// 存储包含委托对象的实例对象
        /// </summary>
        public Cat cat;
        /// <summary>
        /// 构造函数需要传递一个猫类型的实例对象, 来进行存储包含委托对象的实例对象
        /// </summary>
        /// <param name="cat"></param>
        public Mouse(Cat cat)
        {
            this.cat = cat;
        }
        /// <summary>
        /// 留给猫触发委托事件后, 所进行的注册方法调用
        /// </summary>
        public void Go()
        {
            Console.WriteLine(string.Format("{0}开始尖叫，{1} 开始逃跑~", cat.Name, this.Name));
        }
    }
    /// <summary>
    /// 委托是一种类型,而且是一种引用类型,第一步就是声明所要使用的委托类型。
    /// </summary>
    public delegate void Test();
    /// <summary>
    /// 一个模拟猫的类型
    /// </summary>
    public class Cat : Aninmal
    {
        /// <summary>
        /// 第二步构建委托类型的对象,可以不给进行赋值操作,但是使用之前必须给进行初始化才能使用,否则则抛出空引用异常。
        /// </summary>
        public event Test test;
        /// <summary>
        /// 内部的猫尖叫的方式
        /// </summary>
        public void Scream()
        {
            Console.WriteLine(string.Format("{0}喊了一嗓子~", this.Name));
            test?.Invoke();
        }
    }

    #endregion

    #region 模拟汽车的委托案例
    public delegate void CarEngineHandler(object sender, CarEventArgs args);
    public class CarEventArgs : EventArgs
    {
        public string Message { get; set; }
        public CarEventArgs(string message)
        {
            this.Message = message;
        }
    }
    public class Car
    {
        public event EventHandler<CarEventArgs> ExplodedEvent;
        public event EventHandler<CarEventArgs> AboutToBlow;

        public event CarEngineHandler handler;

        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        private bool isDead = false;
        public Car()
        {
            this.MaxSpeed = 100;
        }
        public Car(string petName, int currentSpeed, int maxSpeed)
        {
            this.PetName = petName;
            this.CurrentSpeed = currentSpeed;
            this.MaxSpeed = maxSpeed;
        }
        /// <summary>
        /// 加速
        /// </summary>
        /// <param name="delta"></param>
        public void Accelerate(int delta)
        {
            if (this.isDead)
            {
                this.ExplodedEvent?.Invoke(this, new CarEventArgs($"{this.PetName} 已经不能使用了,因为 {this.PetName} 已经爆炸了~"));
                this.handler?.Invoke(this, new CarEventArgs($"{this.PetName} 已经不能使用了,因为 {this.PetName} 已经爆炸了~"));
            }
            else
            {
                this.CurrentSpeed += delta;
                if ((this.MaxSpeed - this.CurrentSpeed) == 2 && this.AboutToBlow != null)
                    this.AboutToBlow(this, new CarEventArgs(string.Format("抱歉,汽车引擎速度正在下降,{0}快不能使用了......", this.PetName)));
                else
                {
                    if (this.CurrentSpeed > this.MaxSpeed)
                    {
                        this.CurrentSpeed = 0;
                        this.isDead = false;
                    }
                    else
                        this.AboutToBlow(this, new CarEventArgs(string.Format("{0}   正在以{1}km/s的速度向前行驶。", this.PetName, this.CurrentSpeed)));
                }
            }
        }
        /// <summary>
        /// 汽车状态改变
        /// </summary>
        /// <param name="stateMessage"></param>
        public void OnCarStateChanged(string stateMessage)
        {
            Console.WriteLine(stateMessage);
        }
        /// <summary>
        /// 注册汽车引擎事件
        /// </summary>
        /// <param name="handler"></param>
        public void RegisterWithCarEngine(CarEngineHandler handler)
        {
            if (handler != null)
                this.handler = handler;
        }
    }
    #endregion
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender
        {
            get; set;
        }
        public void Break()
        {
            Console.WriteLine("打断,叫醒~");
        }
        public void GetUp()
        {
            Console.WriteLine("起床~");
        }
    }

    public class ClassWitthDelegate
    {
        public delegate int DelegateThatReurnInt();
        public event DelegateThatReurnInt events;
        private static void ResultReturned(IAsyncResult result)
        {
            DelegateThatReurnInt test = (DelegateThatReurnInt)result.AsyncState;
            int r = test();
            Console.WriteLine(r);
        }
        public void Run()
        {
            while (true)
            {
                Thread.Sleep(500);
                if (this.events == null)
                    continue;
                foreach (Delegate @delegate in this.events.GetInvocationList())
                {
                    DelegateThatReurnInt temp = (DelegateThatReurnInt)@delegate;
                    temp.BeginInvoke(new AsyncCallback(ClassWitthDelegate.ResultReturned), temp);
                }
            }
        }
    }
    public sealed class FirstSubscribeer
    {
        private int _myCounter = 0;
        public void Subscribe(ClassWitthDelegate test)
        {
            test.events += new ClassWitthDelegate.DelegateThatReurnInt(() => { Thread.Sleep(4000); return ++this._myCounter; });
        }
    }
}
