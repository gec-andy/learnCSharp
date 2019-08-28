using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00_HelloWorld
{
    /// <summary>
    /// public 公开的
    /// private 私有的
    /// class -> 就是表示类的关键字
    /// MyClass_01 -> 就是表示类名
    /// </summary>
    public class MyClass_01
    {
        //变量 属性 字段 方法

        //私有变量
        private int num1;
        //公有变量
        public int num2;

        // 定义字段(字段一般配合属性来用)
        private int _num1;
        private float _fNum1;

        // 定义属性(属性是对字段的一种封装)
        public int Num1 {
            // get 就是用来获取数据的
            get { return _num1; }
            // set 就是用来表示设置数据的
            // value -> 就是表示要设置的值
            set { _num1 = value; }
        }

        // 定义方法
        // 这个方法有一个返回值(返回值类型就是 int 类型)
        public int getNum1() {
            // 这个是用来获取属性的数据(间接地来获取字段的数据)
            return this.Num1;
        }

        //定义方法
        // 这个方法没有返回值(返回值为 void, void 就表示没有返回值,因为它表示空的含义)
        // 这个方法需要传入一个参数（int 类型的参数） 方法所声明定义的参数 为形式参数
        public void setNum1(int num1) {
            // 这个是用来给属性赋值的(间接地来给字段进行赋值)
            this.Num1 = num1;
        }

        /// <summary>
        /// 测试函数用来计算两个数的数值
        /// </summary>
        /// <param name="a">第一个参数</param>
        /// <param name="b">第二个参数</param>
        /// <returns>返回值是整数类型</returns>
        public int Test_Func(int a, int b) {
            // return 就是用来跳出函数,或者是说用来结束函数的
            return a + b;
        }

        /// <summary>
        /// 测试函数用来计算两个数的值
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="res"></param>
        public void Test_Func(int a, int b ,out int res) {
            // 使用out 修饰函数参数的时候,需要放在最后,并且要在函数内部进行赋值,否则会报错
            res = a + b;
        }
    }
}
