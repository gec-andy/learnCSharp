using System;
using System.Collections.Generic;
using System.Text;

namespace _04_泛型的知识点复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //泛型集合的运用

            var accounts = new List<Account>() {
                new Account("王五",4000),
                new Account("张三",2000),
                new Account("李四",1000)
            };

            decimal result = AccmulateSimple<Account>(accounts);
            Console.WriteLine(result);
            result = AccmulateSimple<Account, decimal>(accounts, (account, balance) => balance += account.Balance);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        /*
            泛型方法的声明与使用
         */

        /// <summary>
        /// 传入一个集合对象 并计算这个集合对象中的所有值
        /// </summary>
        /// <typeparam name="TAccount">类型参数占位符</typeparam>
        /// <param name="accounts"></param>
        /// <returns></returns>
        private static decimal AccmulateSimple<TAccount>(IEnumerable<TAccount> accounts)
            where TAccount : Account
        {
            decimal balanceSum = 0;
            foreach (var item in accounts)
            {
                if (item is Account)
                    balanceSum += ((Account)item).Balance;
            }
            return balanceSum;
        }

        /// <summary>
        /// 更为复杂的泛型方法
        /// </summary>
        /// <typeparam name="T">具体的操作类型参数占位符</typeparam>
        /// <typeparam name="TResult">作为返回值的类型参数</typeparam>
        /// <param name="accounts">要进行操作的集合对象</param>
        /// <param name="func">声明的委托类型参数</param>
        /// <returns></returns>
        private static TResult AccmulateSimple<T, TResult>(IEnumerable<T> accounts, Func<T, TResult, TResult> func)
            where T : Account
        {
            var balanceSum = default(TResult);
            foreach (var item in accounts)
            {
                if (item is Account)
                {
                    if (func != null)
                        balanceSum = func(item, balanceSum);
                }
            }
            return balanceSum;
        }
    }
    #region 模拟账户
    public class Account
    {
        public string Name { get; private set; }
        public decimal Balance { get; private set; }
        public Account(string name, decimal balance)
        {
            this.Name = name;
            this.Balance = balance;
        }
    }
    #endregion

    #region 模拟文档管理队列
    public class Document
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Document()
        {

        }
        public Document(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }
    }
    public interface IDocumentManagerAction<TDoc> where TDoc : Document
    {
        void AddDoc(TDoc doc);
        TDoc GetDoc();
        void DisplayAllDoc();
    }
    public class DocumentManager<TDoc> where TDoc : Document, IDocumentManagerAction<TDoc>
    {
        private StringBuilder builder = new StringBuilder();
        private Queue<TDoc> docQueue = new Queue<TDoc>();
        private object oLock = new object();
        public void AddDoc(TDoc doc)
        {
            lock (oLock)
                this.docQueue.Enqueue(doc);
        }
        public TDoc GetDoc()
        {
            var doc = default(TDoc);
            lock (this.oLock)
                doc = this.docQueue.Dequeue();
            return doc;
        }
        public void DisplayAllDoc()
        {
            if (this.docQueue.Count > 0)
            {
                foreach (TDoc doc in this.docQueue)
                    this.builder.AppendLine($"Title:{doc.Title}, Content:{doc.Content}.");
            }
            Console.WriteLine(this.builder.ToString());
        }
    }
    #endregion
}
