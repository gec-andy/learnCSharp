using System;

namespace _07_02_观察者设计模式之猫捉老鼠
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Animal(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }
    }
    public class Cat : Animal
    {
        public Cat(string name, string color) : base(name, color)
        {
        }

        public event Action CatComingEvent;

        public void CatComing()
        {
            Console.WriteLine($"{this.Color} 颜色的猫过来了~");
            this.CatComingEvent?.Invoke();
        }
    }
    public class Mouse : Animal
    {
        public Mouse(string name, string color) : base(name, color)
        {
        }
        public Mouse(string name, string color, Cat cat) : base(name, color)
        {
            cat.CatComingEvent += this.RunAway;
        }
        public void RunAway()
        {
            Console.WriteLine("" + this, Color + "的老鼠" + this.Name + "说：猫来了，大家快跑！");
        }
    }
}
