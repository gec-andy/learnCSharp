using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_05_面向对象之类的继承复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //直接使用对象的继承关系进行构建对象
            #region 直接使用对象的继承关系进行构建对象
            //Animal bird = new Bird()
            //{

            //};
            //bird.ShowType();
            //bird.Eat();
            //Console.WriteLine("~~~`·~·~~``~");
            //Bird chicken = new Chicken();
            //chicken.ShowType();
            //chicken.ShowColor();
            #endregion

            #region 使用对象的适配器模式来进行组合对象
            //BirdAdapter adapter = new BirdAdapter(new Chicken());
            //adapter.ShowType();
            //adapter.ToTweet();

            #endregion
            Console.ReadKey();
        }
    }
    public abstract class Animal
    {
        public Animal() { }
        public void Eat()
        {
            Console.WriteLine("所有动物都可以吃~");
        }
        public abstract void ShowType();
    }
    public class Bird : Animal
    {
        private string animalTypeName = "Bird";
        private string fealtherColor;
        public Bird()
        {

        }
        public virtual void ShowColor()
        {
            Console.WriteLine(this.fealtherColor);
        }
        public override void ShowType()
        {
            Console.WriteLine(this.animalTypeName);
        }
    }
    public class Chicken : Bird
    {
        public override void ShowType()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
    public class Eagle : Bird, IFlyable
    {
        public Eagle()
        {

        }

        public void Fly()
        {
            Console.WriteLine(this.GetType().Name + "  可以飞.....");
        }

        public override void ShowType()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
    public class BirdAdapter : ITweetable
    {
        private Bird _bird;
        public BirdAdapter(Bird bird)
        {
            this._bird = bird;
        }
        public void ShowType()
        {
            this._bird.ShowType();
        }

        public void ToTweet()
        {
            Console.WriteLine("所有的鸟儿都会叫~");
        }
    }
    public interface IFlyable
    {
        void Fly();
    }
    public interface ITweetable { void ToTweet(); }
}
