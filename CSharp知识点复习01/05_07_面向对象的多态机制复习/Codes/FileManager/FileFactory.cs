using _05_07_面向对象的多态机制复习.Codes.DocFiles;
using _05_07_面向对象的多态机制复习.Codes.ImageFiles;
using _05_07_面向对象的多态机制复习.Codes.MediaaFiles;
using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace _05_07_面向对象的多态机制复习.Codes.FileManager
{
    public class FileFactory
    {
        public FileBase FileBase { get; set; }
        public FileBase CreateFile(string fileName)
        {
            FileType type = (FileType)Enum.Parse(typeof(FileType), fileName);
            switch (type)
            {
                case FileType.pdf:
                    this.FileBase = new Pdf();
                    break;
                case FileType.mp4:
                    this.FileBase = new Mp4();
                    break;
                case FileType.avi:
                    this.FileBase = new Avi();
                    break;
                case FileType.xls:
                    this.FileBase = new Xls();
                    break;
                case FileType.xml:
                    this.FileBase = new Xml();
                    break;
                case FileType.doc:
                    this.FileBase = new Xls();
                    break;
                case FileType.txt:
                    this.FileBase = new Txt();
                    break;
                case FileType.ppt:
                    this.FileBase = new PPt();
                    break;
                case FileType.jpg:
                    this.FileBase = new Jpg();
                    break;
                case FileType.gif:
                    this.FileBase = new Gif();
                    break;
                case FileType.mp3:
                    this.FileBase = new Mp3();
                    break;
            }
            return this.FileBase;
        }
        public void DeleteFile(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            fileInfo.Delete();
        }
    }

}
