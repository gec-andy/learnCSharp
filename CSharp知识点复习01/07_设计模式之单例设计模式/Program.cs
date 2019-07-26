using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_设计模式之单例设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    /*
         几种单例模式的实现方式
         */
    public class Singlection1
    {
        private static readonly Singlection1 _instance = new Singlection1();
        private Singlection1()
        {

        }
        public Singlection1 Instance
        {
            get { return _instance; }
        }
    }

    public class Singlection2
    {
        public static Singlection2 Instance;
        static Singlection2()
        {
            Instance = new Singlection2();
        }
    }
    public class Singlection3
    {
        private Singlection3 _instance;
        public Singlection3 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singlection3();
                }
                return _instance;
            }
        }
    }
    public class Singlection4
    {
        private Singlection4 _instance;
        private readonly object o = new object();
        public Singlection4 Instance
        {
            get
            {
                lock (o)
                {
                    if (this._instance == null)
                    {
                        this._instance = new Singlection4();
                    }
                }
                return _instance;
            }
        }
    }
}
