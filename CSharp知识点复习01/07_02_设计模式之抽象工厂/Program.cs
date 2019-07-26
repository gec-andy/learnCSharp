using System;
using System.IO;
using System.Text;
namespace _07_02_设计模式之抽象工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateFactory factory = new ChineseGenerateFactory();
            ChinesePlane plane = factory.GeneratePlane() as ChinesePlane;
            ChineseTank tank = factory.GenerateTank() as ChineseTank;

            Console.ReadKey();
        }
    }

    #region 模拟生产坦克和战斗机
    public abstract class GenerateFactory
    {
        public abstract Tank GenerateTank();
        public abstract Plane GeneratePlane();
    }
    public class ChineseGenerateFactory : GenerateFactory
    {
        public override Plane GeneratePlane()
        {
            Console.WriteLine("生产中国飞机~");
            return new ChinesePlane();
        }

        public override Tank GenerateTank()
        {
            Console.WriteLine("生产中国坦克~");
            return new ChineseTank();
        }
    }
    public class AmericanGenerateFactory : GenerateFactory
    {
        public override Plane GeneratePlane()
        {
            Console.WriteLine("生产美国飞机~");
            return new AmericanPlane();
        }

        public override Tank GenerateTank()
        {
            Console.WriteLine("生产美国坦克~");
            return new AmericanTank();
        }
    }
    public abstract class Tank
    {

    }
    public class ChineseTank : Tank { }
    public class AmericanTank : Tank { }
    public abstract class Plane { }
    public class ChinesePlane : Plane { }
    public class AmericanPlane : Plane { }
    #endregion


    public abstract class Factory
    {
        public static MyFillInfo CrerateFileInfo(string fileType)
        {
            MyFillInfo info = null;
            switch (fileType)
            {
                case "NoteFile":
                    info = new NoteFile();
                    break;
                case "VideoFile":
                    info = new VideoFile();
                    break;
                case "XlsFile":
                    info = new XlsFile();
                    break;
            }
            return info;
        }
    }

    public abstract class MyFillInfo
    {
        private enum FileType
        {
            Document,
            Video,
            Excel
        }
        private enum FileOperateType
        {
            Notetext,
            Excel,
            VideoPlayer,
            MusicPlayer
        }

        public FileInfo FileInfo { get; set; }
        private string FileName { get; set; }
        private StringBuilder builder = new StringBuilder();
        private FileType Type { get; set; }
        private string FileExternsion { get; set; }
        private FileOperateType FileOperate { get; set; }
        public virtual void FileInfoDescription(string fileName)
        {
            this.FileInfo = new FileInfo(fileName);
            this.FileName = Path.GetFileNameWithoutExtension(fileName);
            this.FileExternsion = this.FileInfo.Extension;
            switch (this.FileExternsion)
            {
                case ".txt":
                    this.SettingFileInfo(FileType.Document, FileOperateType.Notetext);
                    break;
                case ".avi":
                    this.SettingFileInfo(FileType.Video, FileOperateType.VideoPlayer);
                    break;
                case ".xsl":
                    this.SettingFileInfo(FileType.Excel, FileOperateType.Excel);
                    break;
                case ".xml":
                    this.SettingFileInfo(FileType.Document, FileOperateType.Notetext);
                    break;
            }
            this.builder.AppendFormat("【{0}】，是一个{1}，文件后缀是{2}，使用【{3}】打开", this.FileName, this.Type, this.FileExternsion, this.FileOperate);
        }
        private void SettingFileInfo(FileType type, FileOperateType operateType)
        {
            this.Type = type;
            this.FileOperate = operateType;
        }
        public override string ToString()
        {
            return this.builder.ToString();
        }
    }


    public class NoteFile : MyFillInfo
    {
        public override void FileInfoDescription(string fileName)
        {
            base.FileInfoDescription(fileName);
        }
    }
    public class VideoFile : MyFillInfo
    {
        public override void FileInfoDescription(string fileName)
        {
            base.FileInfoDescription(fileName);
        }
    }
    public class XlsFile : MyFillInfo
    {
        public override void FileInfoDescription(string fileName)
        {
            base.FileInfoDescription(fileName);
        }
    }
}
