using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06_正则表达式的复习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 初始正则表达式
            //string str = "正则表达式~";
            //str = Regex.Replace(str, "^", "开始部分");
            //str = Regex.Replace(str, "$", "结束部分");
            //Console.WriteLine(str);
            #endregion

            #region 判断用户输入的是不是数字
            //string s = "5";
            //string pattern = @"^\d*$";
            //bool result = Regex.IsMatch(s, pattern);
            //Console.WriteLine(result);
            #endregion

            #region 正则表达式的分隔符的使用
            //string str1 = "One,two,Three Liberty Associates,Inc";
            //Regex theRegex = new Regex("|,|,");
            //StringBuilder stringBuilder = new StringBuilder();
            //int index = 1;
            //foreach (string s in theRegex.Split(str1))
            //{
            //    stringBuilder.AppendFormat($"{index},{s}\n");
            //}
            #endregion

            #region 使用正则表达式的Match集合
            //string myStr = "this is a test string.";
            //Regex theRegex = new Regex(@"(\S+)\s");
            //MatchCollection coll = theRegex.Matches(myStr);
            //foreach (Match match in coll)
            //{
            //    Console.WriteLine(match.Length);
            //    if (match.Length != 0)
            //    {
            //        Console.WriteLine(match + "");
            //    };
            //}
            #endregion

            #region Example 1 
            //判断用户输入的字符串,是否满足身份证件的需求
            //其中,第一个数字不能为0,且身份证最后一位数是数字或者xx
            //Console.WriteLine("请输入你的身份证号");
            //string input = Console.ReadLine();
            //bool b = Regex.IsMatch(input, @"^([(1|2)-9]){17}|[(1-2)-9]{14})[0-9|xX]{1}$");
            //Console.WriteLine(b);
            #endregion

            #region 反序输出字符串
            //const string str = "abc";
            //for (int i = str.Length - 1; i >= 0; i--)
            //    Console.WriteLine(str[i]);
            #endregion

            #region 查找一个字符串中指定字符所出现的次数
            //const string str = "咳嗽 咳嗽 哈哈哈哈 咳嗽 家具安监局 咳嗽 家家具安监局 恪守";
            //string[] strings = new[] { "咳嗽 咳嗽 哈哈哈哈 咳嗽 家具安监局 咳嗽 家家具安监局 恪守" };
            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //foreach (string item in strings)
            //{
            //    string[] split = item.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            //    foreach (string temp in split)
            //    {
            //        if (temp != "咳嗽")
            //            continue;
            //        else
            //        {
            //            if (!dict.ContainsKey(temp))
            //                dict.Add(temp, 1);
            //            else
            //                dict[temp]++;
            //        }
            //    }

            //}
            //foreach (KeyValuePair<string, int> keyValue in dict)
            //{
            //    Console.WriteLine(keyValue.Key + " " + keyValue.Value);
            //}
            //Console.WriteLine();
            #endregion

            #region 接收用户所输入的一句英文, 将其中的单词以反序进行输出
            //string str = "I love you";
            //char[] cs = str.ToCharArray();
            //for (int i = 0; i < cs.Length / 2; i++)
            //{
            //    char temp = cs[i];
            //    cs[i] = cs[cs.Length - 1 - i];
            //    cs[cs.Length - 1 - i] = temp;
            //    if (cs[i] >= cs[cs.Length - 1 - i])
            //        continue;   

            //}
            #endregion

            #region 求出数组中长度最长的字符串
            //string[] strings = new[] { "草你妈单", "日你钩子", "小蜜蜂", "小鸡仔", "我草你是个傻逼" };
            //string maxLength = strings[0];
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    if (strings[i].Length > maxLength.Length)
            //        maxLength = strings[i];
            //}
            //Console.WriteLine(maxLength);
            #endregion
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
    public class Student : Person { }
    public class SingleObject
    {
        private static SingleObject _instance;
        private SingleObject() { }
        public static SingleObject Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingleObject();
                }
                return _instance;
            }
        }
    }
}
