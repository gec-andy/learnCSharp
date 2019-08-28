using MyNamespace;
using System;

namespace _01_计算机的基本实现
{
    class Program
    {
        static void Main(string[] args)
        {
            // 如何接收用户的输入
            // 声明定义一个字符串 用来接收用户的输入
            string str_Input_1 = string.Empty;
            // Console.ReadLine() 就是用来接收用户的输入 返回一个字符串对象(一组字符数据)
            Console.WriteLine("请输入第一个操作数：");
            str_Input_1 = Console.ReadLine();
            // 需要获取操作符 + - * /
            string str_input_2 = string.Empty;
            Console.WriteLine("请输入操作符：");
            str_input_2 = Console.ReadLine();
            string str_input_3 = string.Empty;
            Console.WriteLine("请输入第二个操作数：");
            str_input_3 = Console.ReadLine();
            //Console.ReadLine();

            Calculator calculator = new Calculator();
            int num1 = 0, num2 = 0, result = 0;
            num1 = Convert.ToInt32(str_Input_1);
            num2 = Convert.ToInt32(str_input_3);
            // switch - case  用来做流程控制 叫选择流程控制结构
            // 需要有一个逻辑条件 -> 就是一个变量值
            // 就是根据这个变量值 来进行判断 是否是正确的 是否是满足某一条数据
            switch (str_input_2)
            {
                case "+"://处理加法操作
                    {
                        // 代码体
                        result = calculator.AddNum(num1, num2);
                        break;
                    }
                case "-"://处理减法操作
                    {
                        // 代码体
                        result = calculator.ReduceNum(num1, num2);
                        break;
                    }
                case "*"://处理乘法操作
                    {
                        // 代码体
                        result = calculator.DeviceNum(num1, num2);
                        break;
                    }
                case "/"://处理除法操作
                    {
                        // 代码体
                        result = calculator.MutilNum(num1, num2);
                        break;
                    }
                default://以上四种都不满足,会执行到这里
                    Console.WriteLine("不满足以上四种~");
                    break;
            }
            Console.WriteLine("操作数1->{0},操作符->{1},操作数2->{2},结果:{3}", num1, str_input_2, num2, result);
            Console.ReadKey();
        }
    }


}

namespace MyNamespace
{
    /// <summary>
    /// 计算器的实现类
    /// </summary>
    public class Calculator
    {
        private int _num1;
        private int _num2;
        private int _result;
        /// <summary>
        /// 操作数1
        /// </summary>
        public int Num1 { get { return _num1; } set { _num1 = value; } }
        /// <summary>
        /// 操作数2
        /// </summary>
        public int Num2 { get { return _num2; } set { _num2 = value; } }
        /// <summary>
        /// 运算结果
        /// </summary>
        public int Result { get { return _result; } set { _result = value; } }
        /// <summary>
        /// 加法运算
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int AddNum(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            Result = this.Num1 + this.Num2;
            return Result;
        }
        /// <summary>
        /// 减法运算
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int ReduceNum(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            Result = this.Num1 - this.Num2;
            return Result;
        }
        /// <summary>
        /// 除法运算
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int DeviceNum(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            Result = this.Num1 / this.Num2;
            return Result;
        }
        /// <summary>
        /// 乘法运算
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int MutilNum(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            Result = this.Num1 * this.Num2;
            return Result;
        }
    }
}