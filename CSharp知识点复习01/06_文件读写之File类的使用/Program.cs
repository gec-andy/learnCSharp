using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _06_文件读写之File类的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            #region File的一些方法
            ////D:\Worksapce\VSWorksoace\CSharp知识点复习01\06_文件读写之File类的使用\TestFile
            //string sourceFileName = @"D:\Worksapce\VSWorksoace\CSharp知识点复习01\06_文件读写之File类的使用\TestFile\test.txt";
            //string targetFileName = @"D:\Worksapce\VSWorksoace\CSharp知识点复习01\06_文件读写之File类的使用\TestFile1\test.txt";
            ////File.Move(@"D:\Worksapce\VSWorksoace\CSharp知识点复习01\06_文件读写之File类的使用\TestFile\test.txt", @"D:\Worksapce\VSWorksoace\CSharp知识点复习01\06_文件读写之File类的使用\TestFile1\test.txt");
            //byte[] bytes = File.ReadAllBytes(targetFileName);
            //string str = Encoding.Default.GetString(bytes);

            //byte[] buffer = Encoding.GetEncoding("utf-8").GetBytes(str);
            //File.WriteAllBytes(targetFileName, buffer);

            //string strNew = "今天是个好风光~";
            //byte[] buffer1 = Encoding.GetEncoding("utf-8").GetBytes(strNew);
            //File.WriteAllBytes(targetFileName, buffer1);

            //File.AppendAllText(targetFileName, "打完大无");
            #endregion


            Console.ReadKey();
        }
    }
}
