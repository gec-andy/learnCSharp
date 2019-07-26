using _05_07_面向对象的多态机制复习.Codes.FileManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05_07_面向对象的多态机制复习
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileDirectory = string.Empty;
            string fileName = string.Empty;
            string input = string.Empty;
            Console.WriteLine("程序开始~~~");

            Console.WriteLine("~~~程序结束");
            Console.ReadKey();
        }
        /// <summary>
        /// 加载文件1
        /// </summary>
        /// <param name="fileDirectory">文件所在目录</param>
        /// <param name="fileName">文件名称</param>
        /// <param name="input"></param>
        private void LoadFile(string fileDirectory, string fileName, string input)
        {
            FileLoad fileLoad = new FileLoad();
            do
            {
                Console.WriteLine("请输入你要操作的文件目录：");
                fileDirectory = Console.ReadLine();
                if (fileDirectory.Length > 0)
                {
                    if (Directory.Exists(fileDirectory))
                    {
                        Console.WriteLine("请输入你亚奥操作的文件名称");
                        fileName = Console.ReadLine();
                        if (fileName.Length > 0)
                        {
                            bool result = fileLoad.CheckInput(Path.Combine(fileDirectory, fileName));
                            fileLoad.CheckResult(result, input);
                            if (fileLoad.IsOpertaion)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                           
                        }
                    }
                }
            } while (input != "退出");
        }
    }
}
