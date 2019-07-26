using System;
using System.Threading;

namespace _03_基于事件的邮件发送接收模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过接口构建一个具体的邮件管理器
            IMailManager manager = new MailManager();
            //构建一个邮件事件单元测试
            INewMailTest newMail = new NewMailEventUnitTest(manager, new MailEventLog());
            INewMailTest newMail1 = new Fax(manager, new MailEventLog());
            MailManager mailManager = manager as MailManager;
            //注册事件
            mailManager.NewMailHandler += newMail.OnNewMail;
            //触发事件
            manager.OnNewMailEvent(new NewMailEventArgs("张三", "李四", "张三骂李四是个傻逼"));
            //注销事件
            mailManager.NewMailHandler -= newMail.OnNewMail;
            //注册事件
            mailManager.NewMailHandler += newMail1.OnNewMail;
            //触发事件
            manager.OnNewMailEvent(new NewMailEventArgs("李四", "张三", "李四骂张三是个傻逼"));


            Console.ReadKey();
        }
    }
    /// <summary>
    /// 构建一个自己的事件参数类 继承于EventArgs
    /// </summary>
    public class NewMailEventArgs : EventArgs
    {
        /// <summary>
        /// 信件来自于谁
        /// </summary>
        private readonly string _from;
        /// <summary>
        /// 信件发送给谁
        /// </summary>
        private readonly string _to;
        /// <summary>
        /// 信件的消息内容
        /// </summary>
        private readonly string _message;
        private NewMailEventArgs() { }
        /// <summary>
        /// 带全部参数的构造函数
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="message"></param>
        public NewMailEventArgs(string @from, string @to, string @message)
        {
            this._from = @from;
            this._to = @to;
            this._message = @message;
        }

        public string GetFrom() => this._from;
        public string GetTo() => this._to;
        public string GetMessage() => this._message;
    }
    /// <summary>
    /// 事件日志接口
    /// </summary>
    /// <typeparam name="TEventArgs"></typeparam>
    public interface IEventLog<in TEventArgs> where TEventArgs : EventArgs
    {
        /// <summary>
        /// 打印参数成员
        /// </summary>
        /// <param name="args"></param>
        void PrintArgsMember(TEventArgs args);
    }
    /// <summary>
    /// 实现继承的邮件事件日志类
    /// </summary>
    public class MailEventLog : IEventLog<NewMailEventArgs>
    {
        /// <summary>
        /// 打印参数成员
        /// </summary>
        /// <param name="args"></param>
        public void PrintArgsMember(NewMailEventArgs args)
        {
            Console.WriteLine($"邮件的发送者:   {args.GetFrom()}  邮件的接收者:  {args.GetTo()} 邮件的内容:   {args.GetMessage()}");
        }
    }
    /// <summary>
    /// 邮件管理器接口
    /// </summary>
    public interface IMailManager
    {
        void OnNewMailEvent(NewMailEventArgs args);
    }
    /// <summary>
    /// 邮件管理器
    /// </summary>
    public class MailManager : IMailManager
    {
        public event EventHandler<NewMailEventArgs> NewMailHandler;
        public void OnNewMailEvent(NewMailEventArgs args)
        {
            var tempHandler = Volatile.Read(ref this.NewMailHandler);
            tempHandler?.Invoke(this, args);
        }
    }
    public interface INewMailTest
    {
        void OnNewMail(object sender, NewMailEventArgs args);
    }
    public abstract class NewMailEventTestBase : INewMailTest
    {
        private readonly IMailManager _mailManager;
        private readonly MailEventLog _mailEventLog;
        public void OnNewMail(object sender, NewMailEventArgs args)
        {
            Monitor.Enter(this);
            this._mailEventLog.PrintArgsMember(args);
            Monitor.Exit(this);
        }
        private NewMailEventTestBase() { }
        protected NewMailEventTestBase(IMailManager mailManager, MailEventLog mailEventLog)
        {
            this._mailManager = mailManager;
            this._mailEventLog = mailEventLog;
        }
    }
    public class Fax : NewMailEventTestBase
    {
        public Fax(IMailManager mailManager, MailEventLog mailEventLog) : base(mailManager, mailEventLog)
        {
        }
    }
    public class NewMailEventUnitTest : NewMailEventTestBase
    {
        public NewMailEventUnitTest(IMailManager mailManager, MailEventLog mailEventLog) : base(mailManager, mailEventLog)
        {
        }
    }
}
