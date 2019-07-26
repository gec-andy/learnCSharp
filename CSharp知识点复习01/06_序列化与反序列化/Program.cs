using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace _06_序列化与反序列化
{
    class Program
    {
        static void Main(string[] args)
        {

            People people = new Chinese()
            {
                Name = "张三",
                Age = 18,

            };
            #region XML序列化的方式
            #region Example 1
            //XmlSerializer xml = new XmlSerializer(typeof(People));
            //using (FileStream fsWrite = new FileStream(@"test.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            //{
            //    xml.Serialize(fsWrite, people);
            //    Console.WriteLine("序列化成功~");
            //} 
            #endregion
            #region Example 2
            //XmlSerializer xml = new XmlSerializer(typeof(People));
            //xml.Serialize(new StreamWriter(@"test1.xml"), people);
            //Console.WriteLine("序列化成功");

            //object o = xml.Deserialize(new StreamReader(@"test1.xml"));
            //if (o != null)
            //{
            //    Console.WriteLine("反序列化成功");
            //    People temp = o as People;
            //    Console.WriteLine(temp);
            //}
            #endregion
            #endregion

            #region 二进制序列化的方式
            BinaryFormatter binary = new BinaryFormatter();
            using (FileStream fsWrite = new FileStream(@"test.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                binary.Serialize(fsWrite, people);
                Console.WriteLine("序列化成功~");
            }
            #endregion

            Console.ReadKey();
        }
    }

    #region 模拟人类
    /// <summary>
    /// 人类共同持有的行为
    /// </summary>
    public interface IPeopleable
    {
        void Eating();
        void Sleeping();
        void Playing();
        void SayHello();
    }
    public interface IEatable { void Eat(); }
    public interface IDuckable { void Duck(); }
    public interface IFireAttackable
    {
        void SingleFireAttack();
        void MuitlFireAttack();
    }
    /// <summary>
    /// 人类抽象类
    /// </summary>
    [Serializable]
    [XmlInclude(typeof(People))]
    public abstract class People : IPeopleable, IEatable, IDuckable, IFireAttackable
    {
        private string _name;
        private int _age;
        private string _gender;
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get { return this._name; } set { this._name = value; } }
        /// <summary>
        /// 年龄（带有约束的属性值）
        /// </summary>
        public int Age
        {
            get
            {
                if (this._age > 18 && this._age < 101)
                {
                    return this._age;
                }
                return 10;
            }
            set
            {
                if (value >= 18 && value <= 101)
                {
                    this._age = value;
                }
                else
                {
                    this.Age = 18;
                }
            }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get { return this._gender; } set { this._gender = value; } }

        public void Duck()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Eating() { Console.WriteLine("我可以吃饭"); }

        public void MuitlFireAttack()
        {
            throw new NotImplementedException();
        }

        public void Playing() { Console.WriteLine("我可以玩"); }

        public abstract void SayHello();

        public void SingleFireAttack()
        {
            throw new NotImplementedException();
        }

        public void Sleeping() { Console.WriteLine("我可以睡觉"); }
    }
    [Serializable]
    public class Chinese : People
    {
        public override void SayHello()
        {
            Console.WriteLine("这是中国人在打招呼~");
        }
    }
    [Serializable]
    public class American : People
    {
        public override void SayHello()
        {
            Console.WriteLine("这是美国人在打招呼~");
        }
    }
    [Serializable]
    public class EnglishMen : People
    {
        public override void SayHello()
        {
            Console.WriteLine("这是英国人在打招呼~");
        }
    }
    [Serializable]
    public class Germans : People
    {
        public override void SayHello()
        {
            Console.WriteLine("这是德国人在打招呼~");
        }
    }
    #endregion
}
