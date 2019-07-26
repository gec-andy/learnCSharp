using System;
using System.Threading;
using System.Threading.Tasks;

namespace _03_委托的异步调用
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 委托异步编程实例一
            //Action action = () =>
            //{
            //    Thread.Sleep(1500);
            //    Console.WriteLine("这是第一个要执行的函数");
            //};
            ////   IAsyncResult asyncResult = null;
            //// 委托异步执行 是用于大任务时刻的执行操作, 在执行大任务的时候也不影响其他对象的相关操作
            //action.BeginInvoke((IAsyncResult result) =>
            //{
            //    //  asyncResult = result;
            //    object obj = result.AsyncState;
            //    if (obj != null)
            //    {
            //        Console.WriteLine(obj);

            //    }
            //    if (result.IsCompleted)
            //        action.EndInvoke(result);// 有返回值的时候, 就使用对应的数据类型声明变量进行接收工作
            //}, null);

            ////action += () =>
            ////{
            ////    Console.WriteLine("这是第二个要执行的函数");
            ////};
            ////action();
            //Test t = new Test();
            //t.TestFunction(); 
            #endregion

            #region 委托异步执行的函数测试
            //string result = Program.GetString("......");
            //Program.Test();
            //Console.WriteLine(result);
            #endregion
            Console.ReadKey();
        }

        private static async void Test()
        {
            Task<string> stringAsync = Program.GetStringAsync(".....");
            if (stringAsync != null)
            {
                string str = await stringAsync;
                await stringAsync.ContinueWith((obj) =>
                {
                    if (obj != null)
                    {
                        string objResult = obj.Result;
                        Console.WriteLine(objResult);
                    }
                });
            }
        }

        private static Task<string> GetStringAsync(string message)
        {
            return Task.Run(() => message + "hello world");
        }

        private static string GetString(string value)
        {
            Task.Delay(3000)?.Wait();
            return value + " hello world";
        }
    }
    public class Test
    {
        public void TestFunction() { Console.WriteLine("dawdaw"); }
    }
}
