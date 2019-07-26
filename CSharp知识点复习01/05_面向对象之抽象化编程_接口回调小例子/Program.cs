using System;

namespace _05_面向对象之抽象化编程_接口回调小例子
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClassWithCallback myClass = new MyClassWithCallback();
            IMyInterfaceabele myInterface = new BaseClass();
            myClass.AddCallback(myInterface);
            myClass.RemoveCallback();
            myClass.AddCallback(myInterface);
            myClass.DoWork();

            Console.ReadKey();
        }
    }

    public interface IMyInterfaceabele
    {
        void DoWork();
    }
    public class MyClassWithCallback
    {
        private IMyInterfaceabele _myInterfaceable;
        public void AddCallback(IMyInterfaceabele myInterfaceable)
        {
            this._myInterfaceable = myInterfaceable;
        }
        public void RemoveCallback()
        {
            this._myInterfaceable = null;
        }
        public void DoWork()
        {
            if (this._myInterfaceable != null)
            {
                this._myInterfaceable.DoWork();
            }
        }
    }
    public class BaseClass : IMyInterfaceabele
    {
        public void DoWork()
        {
            Console.WriteLine("用于接口的回调~");
        }
    }
}
