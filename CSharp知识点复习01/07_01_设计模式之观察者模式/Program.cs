using System;

namespace _07_01_设计模式之观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //有两个类：一个是猫(猫有来到屋子里面的方法) 一个是老鼠(老鼠有看到猫跑了的方法) 
            Cat cat = new Cat("华哥花", "灰");
            Mouse mouse = new Mouse("解决", "黑", cat);
            cat.Comming();
            // mouse.LookCatToRun();
            Console.ReadKey();
        }
    }
    public abstract class Animal
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
        public delegate void CatShoutDelegate();
        public event CatShoutDelegate CatDelegateEvent;
        public Cat(string name, string color) : base(name, color)
        {
        }

        public void Comming()
        {
            Console.WriteLine(this.Name + "是" + this.Color + "的一只猫跑过来了");
            this.CatDelegateEvent?.Invoke();
        }
    }
    public class Mouse : Animal
    {
        public Mouse(string name, string color, Cat cat) : base(name, color)
        {
            cat.CatDelegateEvent += () =>
            {
                Console.WriteLine("一个叫" + Name + "," + Color + "色的老鼠" + "看见猫来了，吓跑了");
            };
        }
    }
}
