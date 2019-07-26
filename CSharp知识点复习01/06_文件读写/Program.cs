using System;
using System.IO;
namespace _06_文件读写
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo("TextFile1.txt");
            bool isExist = fileInfo.Exists;
            Console.WriteLine(isExist);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.Length);

            Console.ReadKey();
        }
    }
}
