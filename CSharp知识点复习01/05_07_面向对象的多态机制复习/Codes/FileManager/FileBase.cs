using System;
using System.IO;
using System.Text;

namespace _05_07_面向对象的多态机制复习.Codes.FileManager
{
    public enum FileType
    {
        pdf, mp4, avi, xls, xml, doc, txt, ppt, jpg, gif, mp3
    }
    /// <summary>
    /// 基本文件类型
    /// </summary>
    public class FileBase
    {
        public string FileName { get; set; }
        public string FileDirectory { get; set; }
        private StringBuilder builder = new StringBuilder();
        public void SaveFileInfo(FileInfo info)
        {
            this.FileName = info.Name;
            this.FileDirectory = info.DirectoryName;
            this.builder.Append("文件名称：" + this.FileName + "\r\n" + "文件所在目录：" + this.FileDirectory + "\r\n" + "文件扩展名：" + this.GetType().Name);
        }
        public void DisplayFileInfo()
        {
            Console.WriteLine(this.builder.ToString());
        }
        public void DisplayFileType()
        {
            Console.WriteLine($"打开 {this.GetType().Name} 的类型文件~");
        }
    }
}
