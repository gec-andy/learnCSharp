namespace _05_面向对象之函数的重载
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /*
            函数的重载概念
                返回值不受影响, 主要是参数的个数以及参数的数据类型。(要么参数的个数不一样,要么参数的数据类型不一样)
             */

        /// <summary>
        /// 函数的重载
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b) => a + b;
        public double Add(double a, double b) => a + b;

        private static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        private static void Swap(out string result) { result = "你好,这是出参参数"; }
        private static void Swap(ref string msg1, ref string msg2)
        {
            string temp = msg1;
            msg1 = msg2;
            msg2 = temp;
        }
        private static void Swap(ref double leftDouble, ref double rightDouble)
        {
            double temp = leftDouble;
            leftDouble = rightDouble;
            rightDouble = temp;
        }


    }
}
