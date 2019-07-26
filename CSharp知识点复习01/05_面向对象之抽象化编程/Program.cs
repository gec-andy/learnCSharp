using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_面向对象之抽象化编程
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    #region 模拟动物世界
    public interface IActionable
    {
        void Move();
    }
    public abstract class Animal
    {
        private string _name;
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public abstract void Show();
        public void MakeVoice()
        {
            Console.WriteLine($"{this.Name} 可以制造声音~");
        }
    }

    public class Dog : Animal, IActionable
    {
        public void Move()
        {
            Console.WriteLine($"{this.Name} 在移动~");
        }

        public override void Show()
        {
            Console.WriteLine($"{this.Name} 在装逼~");
        }
    }
    #endregion
}
