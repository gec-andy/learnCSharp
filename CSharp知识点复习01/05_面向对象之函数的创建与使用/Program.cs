using System;

namespace _05_面向对象之函数的创建与使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3 };
            //ArrayParameterFuncticon(array);
            //ParameterArrayFunction(array);
            #region 使用out参数获取用户是否登录成功的结果
            Console.WriteLine("请输入账号：");
            string strUserName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string strPassword = Console.ReadLine();
            string strLoginState = string.Empty;
            bool IsLoginSuccess = OnLogin(strUserName, strPassword, out strLoginState);
            Console.WriteLine($"登陆结果：{strLoginState} {IsLoginSuccess}");
            #endregion

            Console.ReadKey();
        }

        private static bool OnLogin(string strUserName, string strPassword, out string strLoginState)
        {
            if (strUserName == "8888")
            {
                if (strPassword == "8888")
                {
                    strLoginState = "登陆成功~";
                    return true;
                }
                else
                {
                    strLoginState = "密码错误,登录失败~";
                    return false;
                }
            }
            else
            {
                strLoginState = "账号不存在,登录失败~";
                return false;
            }
        }

        //数组参数 和参数数组的使用

        /// <summary>
        /// 数组参数函数
        /// </summary>
        /// <param name="array"></param>
        private static void ArrayParameterFuncticon(int[] array) { }
        /// <summary>
        /// 参数数组函数
        /// </summary>
        /// <param name="array"></param>
        private static void ParameterArrayFunction(params int[] array) { }
    }
}
