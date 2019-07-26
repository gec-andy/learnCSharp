using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_面向对象之类的封装练习
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public enum Gender { Man, Woman }
    public abstract class Person
    {
        private int Id { get; set; }
        private readonly string Name;
        private readonly int Age;
        private readonly Gender Gender;
        private readonly List<Person> PersonInfoList = new List<Person>();
        private readonly Dictionary<int, string> DictPersonInfo = new Dictionary<int, string>();
        protected readonly List<string> MessageList = new List<string>();
        protected delegate void PersonDelegate();
        protected Person() { }
        protected Person(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        protected int Count
        {
            get
            {
                if (this.PersonInfoList != null)
                {
                    return this.PersonInfoList.Count;
                }
                return 0;
            }
        }
        public string this[int index]
        {
            get
            {
                return this.PersonInfoList[index].ToString();
            }
        }
        protected virtual void PersonMessage(string message) { }
        public virtual void ShowPersonInfo()
        {
            foreach (KeyValuePair<int, string> person in this.DictPersonInfo)
            {
                Console.WriteLine($"人物信息： {person.Value}");
            }
        }
        protected virtual void AddPersonInfo(PersonDelegate personDelegate) { }
        protected virtual string ReadPersonInfo()
        {
            StringBuilder builder = new StringBuilder();
            foreach (Person person in this.PersonInfoList)
                builder.AppendLine($"姓名：{person.Name},年龄：{person.Age}");
            return builder.ToString();
        }
        public virtual void RemovbePersonInfo(Person person)
        {
            for (int i = 0; i < this.PersonInfoList.Count; i++)
            {
                if (this.PersonInfoList.Contains(person) && this.DictPersonInfo.ContainsKey(person.Id))
                {
                    this.PersonInfoList.Remove(person);
                    this.DictPersonInfo.Remove(person.Id);
                }
            }
        }
        public abstract void ReceiveMessage(string messagae);
        public override string ToString()
        {
            return $"Id:{this.Id},Name:{this.Name},Age:{this.Age},Gender:{this.Gender.ToString()}";
        }
        protected virtual void OnProcessPersonEvent(PersonDelegate personDelegate)
        {
            personDelegate?.Invoke();
        }
    }

    public class Student : Person
    {
        protected Student(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ReceiveMessage(string messagae)
        {
            throw new NotImplementedException();
        }
    }

    public interface IMessageSystemable
    {
        void ProcessMessage(string message);
        void ReceiveMessage(string message);
        void SendMessage(string message);
    }
    public class MessageSystem : IMessageSystemable
    {
        public delegate void MessageDelegate(string message);
        public event MessageDelegate MessageEvent;
        public readonly List<string> messageList = new List<string>();
        private string Message { get; set; }

        public void ReceiveMessage(string message)
        {
            this.messageList.Add(message);
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("发送~" + message);
        }

        public void ProcessMessage(string message)
        {
            this.Message = message;
            if (this.MessageEvent != null)
            {
                switch (this.MessageEvent.Method.Name)
                {
                    case "SendMessage":
                        Console.WriteLine("发送消息测试~");
                        break;
                    case "ReceiveMessage":
                        Console.WriteLine("接收消息测试~");
                        break;
                }
                this.MessageEvent(this.Message);
            }
        }
    }
}
