using System;
using System.Text;
using System.Text.RegularExpressions;
namespace _02_文本字符串的一系列处理
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 字符串转义序列
            //string str = "C#开发实战宝典";
            //Console.Write(str + "\n");
            //Console.Write(str + "\r\n");
            //Console.WriteLine(@"" + str);
            #endregion

            #region 比较两个字符串是否相等
            //string str1 = "hello world";
            //string str2 = "hello world";
            //Console.WriteLine(object.ReferenceEquals(str1, str2));
            //Console.WriteLine(str1 == str2);
            //Console.WriteLine(str1.Equals(str2));
            #endregion

            #region 分割字符串
            //string strNames = "大妈,大叔,大爷;小马,小术,小夜";
            //var names = strNames.Split(';');
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //    string[] test = names[i].Split(',');
            //    for (int j = 0; j < test.Length; j++)
            //    {
            //        Console.WriteLine(test[j]);
            //    }
            //}
            #endregion

            // FormatFunction1();

            #region 字符串的一系列方法

            #region Example 1 
            //string msg = "今天天气好晴朗~";
            //string msg1 = "hello world!";
            //Console.WriteLine($"{msg}的字符串长度为{msg.Length}.");
            //Console.WriteLine($"{msg1}的字符串长度为{msg1.Length}.");
            ////取出字符串中的第一个位置的字符数据
            //Console.WriteLine(msg.Aggregate((c1, c2) => c1));
            ////判断是否是一个包含字符元素的字符串
            //Console.WriteLine("判断是否是一个包含字符元素的字符串: " + msg.Any());
            //Console.WriteLine("拷贝一个字符串");
            //char[] cs = new char[msg.Length];//构建一个字符数组,用来存储要拷贝的字符串中的数据
            //msg.CopyTo(0, cs, 0, msg.Length);//进行拷贝
            //for (int i = 0; i < cs.Length; i++)
            //{
            //    Console.WriteLine(cs[i]);
            //}
            //Console.WriteLine();
            //char[] arrChar = msg.ToCharArray();//转换成字符数组 
            #endregion

            #region Example 2
            //string message1 = "Hello world";
            //string message2 = "C#";

            //Console.WriteLine(message1.Equals(message2, StringComparison.Ordinal));
            //Console.WriteLine(message2.Equals(message1, StringComparison.Ordinal));

            //Console.WriteLine(object.ReferenceEquals(message1, message2));
            //Console.WriteLine(object.ReferenceEquals(message2, message1));

            //Console.WriteLine(message1 + " " + message2);

            //Console.WriteLine(message1.ToLower());
            //Console.WriteLine(message1.ToUpper()); 
            #endregion

            #region Example 3
            //string str = "你好,这个世界~";
            //char[] cs = str.ToCharArray();
            //string newStr = new string(cs);

            //int length = str.Length;
            //string str1 = "aaabbcc";
            //string str2 = "AABBCC";
            //Console.WriteLine(str1.ToUpper());
            //Console.WriteLine(str2.ToLower());

            //string[] strArray = str.Split(',');
            //foreach (var item in strArray)
            //{
            //    Console.WriteLine(item);
            //}

            //StringBuilder builder = new StringBuilder("你好, aaaaaaa~");
            //builder.Append("bbbbbbbb");
            //Console.WriteLine(builder.ToString());
            #endregion

            #region Example 4

            #region 分割字符串
            //string strA = "G F FFFSS";
            //char[] separator = { ' ', 'W' };
            //string[] splits = new string[100];
            //splits = strA.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < splits.Length; i++)
            //{
            //    Console.WriteLine(splits[i]);
            //}
            #endregion

            #region 替换字符串
            //string strA = "国家关键人物";
            //if (strA.Contains("国家"))
            //{
            //    strA = strA.Replace("国家", "**");
            //}
            //Console.WriteLine(strA);
            #endregion

            #region 使用指定字符进行连接一组字符串
            //string[] strs = { "诸葛亮", "鸟叔", "马化腾" };
            //string str = string.Join("|", strs);
            //Console.WriteLine(str);
            #endregion
            #endregion

            #region Example 5
            //string myStr = "测试字符串~";
            //char[] myChar = myStr.ToCharArray();
            //foreach (char c in myChar)
            //{
            //    Console.WriteLine(c);
            //}
            //myStr = myStr.Substring(0);
            //Console.WriteLine(myStr);

            //myStr = myStr.Remove(0, 1);
            //Console.WriteLine(myStr);
            //int result = myStr.LastIndexOf("试", StringComparison.Ordinal);
            //Console.WriteLine(result);
            //myStr = myStr.Insert(0, "你好，");

            #endregion

            #region Example 6
            //string str = "张三";
            //int length = str.Length;
            //Console.WriteLine(length);
            //char[] chars = str.ToCharArray();
            //foreach (char c in chars)
            //{
            //    Console.WriteLine(c);
            //}

            //string newStr = new string(chars);
            //Console.WriteLine(newStr);

            //string str1 = "老毕吃了一顿饭,结果老毕火了";
            //str1 = str1.Substring(str.LastIndexOf(',') + 1);
            //Console.WriteLine(str1);
            //str1 = str1.Substring(1, 2);
            //Console.WriteLine(str1);
            #endregion

            #region Example 7
            //string str = "张；三；李；四";
            //str = Regex.Replace(str, @"；+", "");
            //Console.WriteLine(str);
            #endregion

            #endregion

            #region StringBuilder 类型的一些常用方式
            //StringBuilder sb = new StringBuilder();
            //sb.Append("hello ");
            //sb.Append("world");
            //Console.WriteLine(sb.ToString());
            //sb.Insert(sb.ToString().Length, ",你好,世界！");
            //Console.WriteLine(sb.ToString());

            //StringBuilder sb1 = new StringBuilder();
            //sb1.AppendFormat("{0},{1},{2}", "你好", "我是", "保定");
            //sb1.Replace("我是", "他是");
            //Console.WriteLine(sb1.ToString());
            #endregion
            Console.ReadKey();
        }
        static void FormatFunction1()
        {
            Console.WriteLine("格式化数字字符串");
            Console.WriteLine("{0:c}", 9999);//currency 以货币的形式输出数字
            Console.WriteLine("{0:d}", 9999);//Digat 以十进制的形式输出数字
            //其他形式根据应用的场景需要再进行细细的研究
        }
    }
}
