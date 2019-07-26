using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_算术运算
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 20;
            //int result = a + b;
            ////2πr(周长)
            ////π r平方(面积)
            //float radius = 5.0f;
            ////float zc = (3.14f * radius) * 2;
            //float area = 3.14f * (radius * radius);//面积
            //// Console.WriteLine(zc);
            //Console.WriteLine(area);
            //Console.WriteLine(2 * 3.14f * radius);//周长

            //根据用户的需求 求不同几何体的面积
            //Shape shape = new Triangel(5, 3);
            //float result = shape.Calculate();
            //Console.WriteLine(result);

            #region 报销路费
            //接受用户输入两个数：
            //一个为开始里程数
            //一个为结束里程数
            //可以计算出总里程多少  每公里行程给用户报销0.39
            int start = Convert.ToInt32(Console.ReadLine()), end = Convert.ToInt32(Console.ReadLine());
            decimal rate = 0.39m;
            while (true)
            {
                if (start < end)
                {
                    int totalMile = end - start;
                    Console.WriteLine($"总里程为：{totalMile}");
                    decimal totalCost = totalMile * rate;
                    Console.WriteLine($"报销之后需要缴纳的金额为：{totalCost}");
                    break;
                }
                else
                {
                    Console.WriteLine("无法报销,请重新输入！！！");
                    Console.WriteLine("请重新输入开始里程数");
                    start = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("请重新输入结束里程数:");
                    end = Convert.ToInt32(Console.ReadLine());
                    //continue;
                }
            }
            #endregion

            Console.ReadKey();
        }
        /*
            通过重载的方式计算不同几何体的面积
             */
        /// <summary>
        /// 计算圆的面积
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static float Calculate(float radius) { return 3.14f * radius * radius; }
        /// <summary>
        /// 计算长方体的面积
        /// </summary>
        /// <param name="length"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public static float Calculate(float length, float weight) { return length * weight; }
        /// <summary>
        /// 计算三角形的面积
        /// </summary>
        /// <param name="bottom"></param>
        /// <param name="height"></param>
        /// <param name="divideValue"></param>
        /// <returns></returns>
        public static float Calculate(float bottom, float height, int divideValue = 2) { return (bottom * height) / divideValue; }

    }


    /*
        通过面向对象的方式计算不同几何体的面积
         */

    /// <summary>
    /// 图形的基类
    /// </summary>
    public class Shape
    {

        public virtual float Calculate()
        {
            return 0.0f;
        }
    }
    /// <summary>
    /// 圆
    /// </summary>
    public class Ciycle : Shape
    {
        public float radius;
        private float pai = 3.14f;
        public Ciycle(float radius)
        {
            this.radius = radius;
        }
        public override float Calculate()
        {
            return this.pai * radius * radius;
        }
    }
    public class Triangel : Shape
    {
        public float bottom;
        public float height;
        public Triangel(float bottom, float height)
        {
            this.bottom = bottom;
            this.height = height;
        }
        public override float Calculate()
        {
            return (bottom * height) / 2;
        }
    }
    public class RectBox : Shape
    {
        public float length;
        public float weight;
        public RectBox(float length, float weight)
        {
            this.length = length;
            this.weight = weight;
        }
        public override float Calculate()
        {
            return this.length * this.weight;
        }
    }

    public class Box : Shape
    {
        public new float Calculate()
        {
            return 0.0f;
        }
    }

    public abstract class ShapeAbstarct
    {
        public abstract float Calculate();
    }
    public interface IShapeable
    {
        float Calculate();
    }
}
