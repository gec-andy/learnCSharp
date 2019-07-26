using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _06_01_文件读写之FileStream类的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 写入文件测试
            //using (FileStream fsWriter = new FileStream(@"test1.txt", FileMode.OpenOrCreate))
            //{
            //    const string str = "今天天气好晴朗";
            //    byte[] buffer = Encoding.GetEncoding("utf-8").GetBytes(str);
            //    fsWriter.Write(buffer, 0, buffer.Length);
            //    Console.WriteLine("写入成功~");
            //}
            #endregion

            #region 读取文件测试
            using (FileStream fsReader = new FileStream(@"test1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                if (fsReader.Length > 0)
                {
                    byte[] buffer = new byte[fsReader.Length];
                    int length = fsReader.Read(buffer, 0, buffer.Length);
                    string result = Encoding.GetEncoding("utf-8").GetString(buffer, 0, length);
                    Console.WriteLine("读取文件成功呢~");
                    Console.WriteLine(result);
                }
            }
            #endregion
            Console.ReadKey();
        }

        /// <summary>
        /// 拷贝文件
        /// </summary>
        /// <param name="source">要拷贝的源文件地址</param>
        /// <param name="target">要拷贝的目标文件地址</param>
        private static void CopyFile(string source, string target)
        {
            if (source != string.Empty && target != string.Empty)
            {
                //先构建两个FileStream类型对象用于创建读取源和写入源
                using (FileStream fsReader = new FileStream(source, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    using (FileStream fsWriter = new FileStream(target, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                    {
                        //构建一个字节数组用于存储读取到的源数据
                        byte[] buffer = new byte[fsReader.Length];
                        //存储源数据长度
                        int length = fsReader.Read(buffer, 0, (int)fsReader.Length);
                        //如果数据长度满足,则进行对目标地址的数据写入
                        while (length > 0)
                        {
                            fsWriter.Write(buffer, 0, length);
                            //设置百分比的显示方式
                            //根据写入的数据位置信息/读取到的数据的长度*100
                            double precentage = (fsWriter.Position / (double)fsReader.Length) * 100;
                            Console.WriteLine(precentage);
                        }
                    }
                    //再写入目标
                }
            }
        }
    }
}
