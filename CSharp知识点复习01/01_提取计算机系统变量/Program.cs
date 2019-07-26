using System;

namespace _01_提取计算机系统变量
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] diversName = Environment.GetLogicalDrives();
            foreach (string diverName in diversName)
            {
                Console.WriteLine($"设备名称：{diversName}");
            }
            Console.WriteLine();
            string folderName = Environment.GetFolderPath(Environment.SpecialFolder.CDBurning);
            Console.WriteLine(folderName);
            Console.WriteLine(Environment.Is64BitOperatingSystem);//是否是64位计算机系统
            Console.WriteLine(Environment.SystemDirectory);//系统目录
            Console.ReadKey();
        }
    }
}
