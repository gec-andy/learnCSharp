using System;
using System.Collections.Generic;

namespace _07_03_设计模式之工厂模式
{
    class Program
    {
        public static Dictionary<int, string> dictNumbers = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            // BaseFood food = Factory.GenerationFood(BaseFood.FoodType.饭类, "大米饭");
            //NumberFactory numFactory = new NumberFactory();
            //numFactory.dictNumbers.Add(1, "一");
            //string result = numFactory.GetStringNumber(new Number() { IntNumber = 1 });
            //Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class Number
    {
        public int IntNumber { get; set; }
    }
    public class NumberFactory
    {
        public Dictionary<int, string> dictNumbers = new Dictionary<int, string>();
        /// <summary>
        /// 根据数字类获取对应的
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string GetStringNumber(Number number)
        {
            if (dictNumbers.ContainsKey(number.IntNumber))
            {
                return this.dictNumbers[number.IntNumber];
            }
            return string.Empty;
        }
    }

    //模拟生产饭

    public abstract class BaseFood
    {
        public enum FoodType
        {
            饭类,
            面类
        }
        public string Name { get; set; }
        public FoodType Type { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
    public class Rice : BaseFood { }
    public class Noodle : BaseFood { }
    public class Tomato : BaseFood { }
    public class Factory
    {
        public static BaseFood GenerationFood(BaseFood.FoodType foodType, string foodName)
        {
            switch (foodType)
            {
                case BaseFood.FoodType.饭类:
                    return new Rice() { Name = foodName };
                case BaseFood.FoodType.面类:
                    return new Noodle() { Name = foodName };
            }
            return null;
        }
    }

    public class FoodFactory
    {
        public BaseFood GenerateFood(string foodName)
        {
            BaseFood food = null;
            switch (foodName)
            {
                case "Noodle":
                    food = new Noodle();
                    break;
                case "Tomato":
                    food = new Tomato();
                    break;
            }
            return food;
        }
    }
}
