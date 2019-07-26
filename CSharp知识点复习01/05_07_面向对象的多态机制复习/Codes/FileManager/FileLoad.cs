using _05_07_面向对象的多态机制复习.Codes.DocFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_07_面向对象的多态机制复习.Codes.FileManager
{
    public class FileLoad
    {
        public bool IsFileExists { get; set; }
        public bool IsOpertaion { get; set; }
        public string FileLoadStateInfo { get; set; }
        public FileType FileType { get; set; }
        public FileFactory FileFactory { get; set; }
        private List<FileBase> files = new List<FileBase>();

        public bool CheckInput(string fileName)
        {
            if (fileName != string.Empty && fileName.Length > 0)
            {
                if (File.Exists(fileName))
                {
                    Console.WriteLine("文件存在~");
                    this.FileLoadStateInfo = "文件存在";
                    this.loadFileByFileName(fileName);
                    this.IsFileExists = true;
                }
                else
                {
                    this.FileLoadStateInfo = "文件不存在";
                    this.IsFileExists = false;
                }
            }
            else
            {
                this.IsFileExists = false;
            }
            return this.IsFileExists;
        }
        public void CheckResult(bool result, string input)
        {
            if (result)
                this.ResultSwitch(input = Console.ReadLine());
        }
        private void ResultSwitch(string input)
        {
            switch (input)
            {
                case "继续":
                    this.IsOpertaion = true;
                    break;
                case "退出":
                    this.IsOpertaion = false;
                    break;
            }
        }

        private void loadFileByFileName(string fileName)
        {
            FileInfo info = new FileInfo(fileName);
            this.FileFactory = new FileFactory();
            if (info != null)
            {
                this.FileType = (FileType)Enum.Parse(typeof(FileType), info.Extension.Substring(1));
                FileBase file = this.FileFactory.CreateFile(this.FileType.ToString());
                file.SaveFileInfo(info);
                file.DisplayFileType();
                file.DisplayFileType();
                this.files.Add(file);
            }

        }

        public void PrintLoadStateInfo()
        {
            Console.WriteLine(this.FileLoadStateInfo);
        }
        private void Test(string fileName)
        {
            using (FileStream fsWriter = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                byte[] buffer = new byte[fsWriter.Length];
                int length = 0;
                do
                {
                    length = fsWriter.Read(buffer, 0, buffer.Length);
                } while (length != 0);
                string fileInfo = Encoding.Default.GetString(buffer, 0, length);
                if (fileInfo.Length > 0)
                    Console.WriteLine(fileInfo);
            }
        }
        public List<FileBase> GetAllFiles
        {
            get { return this.files; }
        }
        public void OpenAllFiles()
        {
            foreach (FileBase file in this.files)
                file.DisplayFileInfo();
        }
    }
}
