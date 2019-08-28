//  引入命名空间
using System;

//引入自定义命名空间
using MyNamespace;
//引入自定义命名空间
using MyNamespace1;

/// <summary>
/// 命名空间
/// </summary>
namespace _00_HelloWorld
{
    /// <summary>
    /// 类 就是一个代码文件
    /// </summary>
    class Program
    {
        /// <summary>
        /// 方法 方法也可以写Summary
        /// </summary>
        /// <param name="args"></param>
        /// Main 函数 是所有编程语言中都有的这么一个理念
        /// 就是程序的入口函数
        ///  static 静态的
        ///  void 空的,表示无的意思
        ///  string 就是一种字符串类型的数据类型
        ///  [] 就是表示要定义一个数组的意思
        ///  args 就是表示所定义的数组名称
        static void Main(string[] args)
        {// 左花括号：代码语句的起始点
         //这里边被称为代码体,或者是叫做代码块[Coding block]
         //  这里边可以编写很多行代码语句,

            #region VS 常用快捷键
            #region 计算机中常用的快捷键(通用的快捷键)
            //ctrl + c 复制文本内容
            //ctrl + v 粘贴文本内容
            //ctrl + d 复制当前行文本内容,粘贴到下一行
            //ctrl + x 剪切文本内容 
            #endregion

            // 代码注释的快捷键  ctrl + k + c
            // 取消代码注释的快捷键 ctrl + k + u
            // 代码块的使用 ctrl + k + s 
            #endregion


            // MyClass myClass = new MyClass();

            //  调用一个方法
            //MyClass.MyMehtod();
            //  使程序暂停

            #region 定义变量 并输出变量中的数据
            // 输入一段数据
            // 变量 常量
            //变量 就可以理解为一个盒子 这个盒子就是用来装东西用的,盒子有很多分类,比如说,装衣服的盒子,有装鞋的盒子
            //在程序中 就有装数据的盒子,装整数 装实数 装文本 等等类型的数据

            //  变量就可以理解为 可变的量
            //  数据类型 标识符(变量名称) = 数据
            ////  定义一个整数
            //int num = 10;
            ////  定义一个小数
            //float f = 5.5f;
            ////  定义一个字符串
            //string str = "你好,世界";
            // 值类型 自己单独的一个值 存储在栈上
            //  引用类型 对值的引用保留  存储在堆上

            // 可以换行的输出
            //Console.WriteLine("整数的数据为:" + num);
            //Console.WriteLine("小数的数据为:" + f);
            //Console.WriteLine("字符串的数据为:" + str); 
            #endregion

            #region 使用自定义的 Struct 类型
            // new 关键字 就是表示创建的意思
            // 就是创建一个结构体类型的数据(对象)
            // 结构体类型 标识符 = new 结构体类型();
            //MyStruct tmpStruct = new MyStruct();
            //tmpStruct.INum = 2;
            ////  double d
            //// float f
            //// int 类型不需要修饰,直接定义使用就可以了
            //tmpStruct.FNum = 3.333f;
            //int tmpNum1 = tmpStruct.INum;
            //float tmpNum2 = tmpStruct.FNum;

            //// + - * /
            ////  数据类型转换这个概念
            ////  在程序世界中 有大数据 有小数据
            ////  一种大数据转换成小数据  强制类型转换
            ////  另一种是小数据转换成大数据 隐式类型转换
            ////  就好比有两个盒子 这两个盒子 就是存放不同类型的数据,存放数据的容量也不一样
            ////  大盒子 就是存放的东西会多一些, 小盒子就是存放的东西会少一些
            ////  int -> float

            //// 需要做一个强制转换的操作
            //// 第一种强制转换数据类型的方法
            ////  直接在要进行转换的变量前边加上括号,括号内就是要转换的数据类型
            //Console.WriteLine(tmpNum2);
            ////  在转换成整数类型的时候 就会存在精度的丢失问题
            ////   这个精度丢失的问题就是指的是 大数据在转换成小数据的时候,可能会出现
            ////  就比如小数类型 转换成 整数类型,就会出现小数点后几位的精度丢失
            //int result = (int)tmpNum2;
            //Console.WriteLine(result);
            ////int result = tmpNum1 + tmpNum2;
            ////同数据类型的变量  直接可以转换 而不需要类型转换
            //float f = tmpStruct.FNum;

            ////  小数据类型转换成大数据类型 直接可以转换,而不需要做类型转换操作
            //float f1 = tmpStruct.INum;

            //// + - * /

            //int sum = 10 + 5;
            //int reduceResult = 10 - 5;
            //int multiResult = 10 * 5;
            //int chuResult = 10 / 5;
            // 使用对应格式输出数据
            // 0 sum
            // 1 reduceResult
            // 2 multiResult
            // 3 chuResult

            // 就好比一个一个的萝卜坑
            //  一个坑就是对应一个萝卜
            //  每个坑必须要有一个萝卜
           // Console.WriteLine("Sum:{0},Reduce:{1},Multi:{2},Chu:{3}", sum, reduceResult, multiResult, chuResult);

            #region 输出自定义的结构体中的数据
            ////Console.WriteLine(tmpNum1);
            ////Console.WriteLine(tmpNum2);
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            //tmpNum1 = 10;
            //tmpNum2 = 5;
            //Console.WriteLine("_____________________________________");
            ////Console.WriteLine(tmpStruct.INum);
            ////Console.WriteLine(tmpStruct.FNum); 
            #endregion

            #region 调用一个自定义的结构体中的方法
            ////  调用一个方法(函数)
            ////  使用对象名,或者是变量名(这个变量是new出来的) . 方法名();
            //tmpStruct.PrintNum();
            //Console.WriteLine("_____________________________________");
            ////Console.WriteLine(tmpNum1);
            ////Console.WriteLine(tmpNum2); 
            #endregion
            #endregion

            //  不可以进行换行输出
            //Console.Write("输出数据,不进行换行");

            #region 实例化自己所声明定义的类
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.WriteLine("获取当前系统时间: " + DateTime.Now + " ");
            //// 创建一个自定义的类型,并实例化出一个对象到内存中
            MyClass_01 myClass_01 = new MyClass_01();
            // 声明定义并初始化 4个值类型
            int a = 10, b = 22, result1 = 0, result2 = 0;
            // 调用自己定义的函数 求两个数的值(是接收的返回值)
            result1 = myClass_01.Test_Func(a, b);
           // 调用自己定义的函数 求两个数的值(是不接收返回值,使用out 修饰的参数)
           // 这是一个重载函数,重载函数和返回值没有关系,无关
            myClass_01.Test_Func(a, b, out result2);
            Console.WriteLine("不使用out修饰的参数,而是接收的函数的返回值,a+b=" + result1);
            Console.WriteLine("使用out修饰的参数,不是接收的函数的返回值,a+b=" + result2);
            #region 通过属性操作变量 和 通过方法操作属性
            //// 为属性进行赋值
            //myClass_01.Num1 = 10;
            //// 使用属性获取数据
            //// 并输出到控制台上
            //Console.WriteLine(myClass_01.Num1);
            //// 为这个 myClass_01 这个对象中的变量 num2 进行赋值
            //myClass_01.num2 = 100;
            //// 通过获取变量 num2 进行数据的输出打印
            //Console.WriteLine("通过使用变量名称来获取的数据:" + myClass_01.num2);
            //// 通过方法为属性设置数据(赋值)
            //myClass_01.setNum1(20);
            //Console.WriteLine("通过调用方法获取的数据:" + myClass_01.getNum1());
            //Console.WriteLine("通过调用属性获取的数据:" + myClass_01.Num1);
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~"); 
            #endregion
            #endregion

            //Console.Write("这个可以换行\r\n");
            //输出一段数据
            Console.ReadKey();

        }//右花括号：代码语句的结束点
    }
}

//alt + shift + f10 这个就是针对你对名称修改以后,不确定在哪里使用了这个名称,就可以方便的一键修改
/// <summary>
/// 定义一个命名空间
/// </summary>
namespace MyNamespace
{
    /// <summary>
    /// 定义一个代码文件
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// 定义一个方法
        /// </summary>
        /// static 可选择的关键字 void 就是方法的返回值 MyMethod 就是方法名称
        public static void MyMehtod()
        {
            //代码体,但是在方法里叫做,方法体
            // Console 控制台的意思
            // Write() 向控制台写入一些内容 括号内就是表示要写入的内容,需要使用双引号引起来("")
            //  然后每行代码语句都需要以分号结尾,就好比是写完了一句话,要进行结尾。
            Console.Write("Hello world~");
            //  \n 就是表示 new Line 新的一行的意思
            Console.Write("\r\n");
            Console.Write("你好 世界~");

            // ctrl + f5
        }
    }
}

/// <summary>
/// 自定义的一个命名空间
/// </summary>
namespace MyNamespace1
{
    /// <summary>
    ///     public 就是表示公开的
    ///     struct 就是表示结构体 也就是自己定义的一种值类型的数据类型
    ///     MyStruct 就是表示这个定义的值类型的名称
    /// </summary>
    public struct MyStruct
    {
        // 变量 可变的量
        // 属性 就好比人的性格
        // 字段 对变量的一种封装 或者叫做一种隐藏的变量,字段只能在类或者结构体的内部使用
        // 函数(方法) 
        //  一种是实例函数 一种是静态函数 还有两种是特殊的函数 一种叫做构造函数 一种叫做析构函数
        // 构造函数就是指的是 就是好比用来描述人出生的过程
        // 析构函数就是指的是 就是好比用来描述人去世的过程

        // 访问修饰符 private public
        // private 就是私有的 只能在内部访问
        // public 就是公开的 内部 和 外部 都可以访问

        /// <summary>
        /// 变量1
        /// </summary>
        private int iNum;
        /// <summary>
        /// 变量2
        /// </summary>
        private float fNum;
        /// <summary>
        /// 属性1
        /// </summary>
        public int INum
        {
            get { return iNum; }
            set { iNum = value; }
        }
        /// <summary>
        /// 属性2
        /// </summary>
        public float FNum
        {
            get { return fNum; }
            set { fNum = value; }
        }
        /// <summary>
        /// 声明定义一个结构体的构造函数 
        /// 包含三部分 访问修饰符 函数名称 (){}
        /// </summary>
        //public MyStruct()
        //{
        //    iNum = 10;
        //    fNum = 10.5f;
        //}

        // 变量的名称 也叫做标识符
        /// <summary>
        /// 声明定义一个结构体的构造函数 
        /// 包含三部分 访问修饰符 函数名称 (函数的参数,参数可以有多个[参数格式:数据类型 标识符]){}
        /// </summary>
        public MyStruct(int iNum, float fNum)
        {
            // this 就是表示当前的这个自定义的 struct 的值类型
            // this.iNum(这个就是结构体内部的变量) =iNum(这个就是函数的参数)
            this.iNum = iNum;
            this.fNum = fNum;
        }

        /// <summary>
        /// 定义一个方法 
        /// 三部分: 访问修饰符,方法的返回值,方法名, 参数列表
        /// </summary>
        public void MethodName()
        {
            //方法体,也可以叫做函数体,
            //方法呢 就是用来做一件事

        }

        /// <summary>
        /// 一个输出方法(函数)
        /// </summary>
        public void PrintNum()
        {
            Console.WriteLine(this.iNum);
            Console.WriteLine(this.fNum);
        }
    }
}
