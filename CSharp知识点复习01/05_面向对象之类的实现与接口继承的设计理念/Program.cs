using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_面向对象之类的实现与接口继承的设计理念
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    #region 面向对象之图形抽象编程
    public interface IShapeable
    {
        Position Position { get; }
        Size Size { get; }
        void ReSize(int weight, int height);
        void ShowShapeInfo();
        void Move(Position newPosition);
    }
    public abstract class Shape : IShapeable
    {
        private Position _position;
        private Size _size;
        public Position Position => this._position;

        public Size Size => this._size;
        protected Shape(Size size, Position position) { }
        public void Move(Position newPosition)
        {
            this.Position.X = newPosition.X;
            this.Position.Y = newPosition.Y;
            this.Position.Z = newPosition.Z;
        }

        public void ReSize(int weight, int height)
        {
            this.Size.Height = height;
            this.Size.Weight = weight;
        }

        public void ShowShapeInfo()
        {
            StringBuilder sb = new StringBuilder();
            if (Position != null && Size != null)
            {
                sb.Append($"位置信息：{Position.X}, {Position.Y}, {Position.Z}\\r\\n");
                sb.Append($"尺寸信息：{Size.Height}, {Size.Weight}\\r\\n");
            }
        }
    }
    public sealed class RectAngle : Shape
    {
        public RectAngle(Size size, Position position) : base(size, position) { }

    }
    public sealed class Circle : Shape
    {
        public Circle(Size size, Position position) : base(size, position)
        {
        }
    }


    public class Position
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
    public class Size
    {
        public float Height { get; set; }
        public float Weight { get; set; }
    }
    #endregion

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public void ShowPersonInfo()
        {
            Console.WriteLine("这个人叫{0},今年{1}岁了,是个{2}生", Name, Age, Gender);
        }
        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }
        public virtual void SayHello() { }
        public void Hello()
        {
            Console.WriteLine("这是父类的打招呼~");
        }
    }

    public class Sttudent : Person
    {
        public Sttudent(string name, int age, string gender) : base(name, age, gender)
        {
        }
    }

    public class Teacher : Person
    {
        public Teacher(string name, int age, string gender) : base(name, age, gender)
        {
        }
    }
    public class Driver : Person
    {
        public Driver(string name, int age, string gender) : base(name, age, gender)
        {
        }
        public int DriverTime { get; set; }
        public override void SayHello()
        {
            Console.WriteLine("我叫{0},我的年龄是{1}岁,我是{2}人,我的驾龄是{3}年", Name, Age, Gender, DriverTime);
        }
    }
    public class Reporter : Person
    {
        public Reporter(string name, int age, string gender, string like) : base(name, age, gender)
        {
            this.Like = like;
        }
        public string Like
        {
            get; set;
        }
        public override void SayHello()
        {
            Console.WriteLine("我是{0},我的爱好是{1},我的年龄是{2}岁,我是一个{3}狗仔", Name, Like, Age, Gender);
        }
    }
}
