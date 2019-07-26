using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_编程练习题复习之变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "张三";
            //string gender = "男";
            //int age = 20;
            //int phoneNumber = 877888;
            //Console.WriteLine("姓名：" + name + ",性别: " + gender + ",年龄：" + age);
            //Console.WriteLine("_______________________________");
            //Console.WriteLine("模拟敌人应该有的一些属性");
            //string enemyName;
            //string enemyType;
            //float enemyHealthpoint;
            //float attackValue;
            //float attackDistance;
            //float defenceValue;
            //float attackRate;
            //Console.WriteLine("--------------------");
            //string strMyName;
            //string strAddress;
            //int numMyAge;
            //Console.WriteLine("--------------------");
            //Console.WriteLine("声明两个变量,并进行两个变量的数据交换");
            //int a = 10, b = 20;
            //Console.WriteLine("两个变量交换之前的数据为");
            //Console.WriteLine(a + ": " + b);
            //int temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine("两个变量交换之后的数据为");
            //Console.WriteLine(a + ": " + b);
            //Console.WriteLine();
            //a = a + b;//先将两个值累加给一个值
            //b = a - b;//然后使用累加后的值进行减去第二个累加的值,就得出第一个累加的值,并赋值给第二个值
            //a = a - b;//这样的话再使用累加后的值减去第二个累加的值,就得出第二个累加的值,并赋值给第一个值
            //Console.WriteLine(a + ": " + b);
            //Console.WriteLine("请输入两个数据：");
            //int numInput1, numInput2;
            //Console.WriteLine("请输入第一个数");
            //numInput1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数");
            //numInput2 = Convert.ToInt32(Console.ReadLine());
            //int result = numInput1 + numInput2;
            //Console.WriteLine("输入的数据累加后获得的结果为：" + result);
            //Console.WriteLine();
            //Console.WriteLine("你喜欢吃什么水果?");
            //string strFruitName = string.Empty;
            //strFruitName = Console.ReadLine();
            //if (!string.IsNullOrEmpty(strFruitName))
            //{
            //    Console.WriteLine("哈哈哈,我跟你一样,也喜欢{0}", strFruitName);
            //}
            //Console.WriteLine();
            //Console.WriteLine("旅店模拟登记系统~");
            //Console.WriteLine("请输入你的姓名:");
            //Console.WriteLine("请输入你的年龄:");
            //Console.WriteLine("请输入你的邮箱:");
            //Console.WriteLine("请输入你的联系方式:");
            //Console.WriteLine("请输入你的家庭住址:");
            //Console.WriteLine();
            Console.WriteLine("请输入你的年龄,我们将根据年龄,计算您存活了多少个月份");
            int age = 25;
            int months = age * 12;
            Console.WriteLine(months);
            Console.ReadKey();


        }
    }
}
