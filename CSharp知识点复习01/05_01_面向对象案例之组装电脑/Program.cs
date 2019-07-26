using System;
using System.Threading;

namespace _05_01_面向对象案例之组装电脑
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过使用里氏转换的概念, 使用父类构建一个子类对象
            Computer computer = new SumsungComputer()
            {
                ComputerName = "三星电脑",
                GenerationDate = new DateTime(2002, 12, 25),
                Displayer = new Displayer()
                {
                    Name = "三星曲面显示器",
                    DeceiveColor = DeceiveColor.Blue,
                    DeceiveManufacturer = DeceiveManufacturer.Sumsung,
                    GenerationDate = new DateTime(2001, 12, 25)
                },
                Machine = new Machine()
                {
                    Name = "三星主机",
                    DeceiveColor = DeceiveColor.Blue,
                    DeceiveManufacturer = DeceiveManufacturer.Sumsung,
                    GenerationDate = new DateTime(2001, 11, 15)
                },
                Mouse = new Mouse()
                {
                    Name = "雷蛇",
                    DeceiveColor = DeceiveColor.Black,
                    DeceiveManufacturer = DeceiveManufacturer.Razer,
                    GenerationDate = new DateTime(1991, 12, 21)
                },
                KeyBoard = new KeyBorad()
                {
                    Name = "樱桃机械键盘",
                    DeceiveColor = DeceiveColor.Black,
                    DeceiveManufacturer = DeceiveManufacturer.Apple,
                    GenerationDate = new DateTime(1992, 12, 21)
                },
                HeadSet = new HeadSet()
                {
                    Name = "达尔优",
                    DeceiveColor = DeceiveColor.White,
                    DeceiveManufacturer = DeceiveManufacturer.Sony,
                    GenerationDate = new DateTime(1555, 12, 21)
                }
            };
            computer.StartUse();
            Console.WriteLine("电脑组装完成~  ");
            Console.ReadKey();
        }
    }
    /// <summary>
    /// 电脑生产厂商
    /// </summary>
    public enum ComputerManufacturer
    {
        Sumsung,
        Acer,
        Sony,
        Razer,
        Apple,
        Microsoft
    }

    public enum DeceiveColor
    {
        Black,
        White,
        Blue,
        Yellow,
        Red
    }
    public enum DeceiveManufacturer
    {
        Sumsung,
        Acer,
        Sony,
        Razer,
        Apple,
        Microsoft
    }

    public abstract class Computer : IComputerable
    {
        public string ComputerName { get; set; }
        public DateTime GenerationDate { get; set; }
        public ComputerManufacturer Facturer { get; set; }
        public Displayer Displayer { get; set; }
        public Machine Machine { get; set; }
        public Mouse Mouse { get; set; }
        public KeyBorad KeyBoard { get; set; }
        public HeadSet HeadSet { get; set; }

        public void OnShowDeceiveInfo()
        {
            Console.WriteLine("当前电脑的名称: {0}", this.ComputerName);
            Console.WriteLine("当前电脑的生产时间: {0}", this.GenerationDate.ToShortDateString());
            Console.WriteLine("当前电脑的生产厂商: {0}", this.Facturer.ToString());
        }

        public void StartUse()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            this.OnShowDeceiveInfo();
            Console.WriteLine("摁下开机按钮...........");
            Thread.Sleep(1500);
            Console.WriteLine("电脑开始运转...........");
            Thread.Sleep(500);
            this.Displayer.OnShowDeceiveInfo();
            this.Displayer.StartUse();
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("显示器被打开了...........");
            this.Machine.OnShowDeceiveInfo();
            this.Machine.StartUse();
            Thread.Sleep(1000);
            Console.WriteLine("主机被打开了...........");
            Console.WriteLine();
            this.Mouse.OnShowDeceiveInfo();
            this.Mouse.StartUse();
            Thread.Sleep(200);
            Console.WriteLine("鼠标准备开始使用...........");
            Console.WriteLine();
            this.KeyBoard.OnShowDeceiveInfo();
            Thread.Sleep(200);
            this.KeyBoard.StartUse();
            Console.WriteLine("键盘准备开始使用...........");
            Console.WriteLine();
            this.HeadSet.OnShowDeceiveInfo();
            Thread.Sleep(200);
            this.HeadSet.StartUse();
            Console.WriteLine("耳机准备开始使用...........");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        public void StopUse()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("摁下关机按钮...........");
            Console.WriteLine("电脑开始停止运转...........");
            this.Displayer.StopUse();
            Console.WriteLine("显示器被关闭了...........");
            this.Mouse.StopUse();
            Console.WriteLine("鼠标准备停止使用...........");
            this.KeyBoard.StopUse();
            Console.WriteLine("键盘准备停止使用...........");
            this.HeadSet.StopUse();
            Console.WriteLine("耳机准备停止使用...........");
            this.Machine.StopUse();
            Console.WriteLine("主机被关闭了...........");
            this.OnShowDeceiveInfo();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
    public class SumsungComputer : Computer { }
    public class AcerComputer : Computer { }
    public class SonyComputer : Computer { }
    public class RazerComputer : Computer { }
    public class AppleComputer : Computer { }
    public class MicrosoftComputer : Computer { }

    public interface IComputerable : IElctronDeciveable
    {

    }
    /// <summary>
    /// 电子设备类
    /// </summary>
    public abstract class ElctronDeceive : IElctronDeciveable
    {
        public string Name { get; set; }
        public DateTime GenerationDate { get; set; }
        public DeceiveColor DeceiveColor { get; set; }
        public DeceiveManufacturer DeceiveManufacturer { get; set; }
        public ElctronDeceive()
        {

        }
        public ElctronDeceive(string name, DateTime generationDate, DeceiveColor color, DeceiveManufacturer facturer)
        {
            this.Name = name;
            this.GenerationDate = generationDate;
            this.DeceiveColor = color;
            this.DeceiveManufacturer = facturer;
        }

        public abstract void StartUse();
        public abstract void StopUse();
        public void OnShowDeceiveInfo()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~电子设备~~~~~~~~~~~~~~~");
            Console.WriteLine("当前设备名称：{0}", this.Name);
            Console.WriteLine("当前设备颜色：{0}", this.DeceiveColor.ToString());
            Console.WriteLine("当前设备生产时间：{0}", this.GenerationDate.ToShortDateString());
            Console.WriteLine("当前设备生产厂商：{0}", this.DeceiveManufacturer.ToString());
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
    /// <summary>
    /// 电子设备能力接口
    /// </summary>
    public interface IElctronDeciveable
    {
        void StartUse();
        void StopUse();
        void OnShowDeceiveInfo();
    }

    #region 具体的电子设备类
    public class Displayer : ElctronDeceive
    {
        public override void StartUse()
        {
            Console.WriteLine("开始使用显示器~");
        }

        public override void StopUse()
        {
            Console.WriteLine("停止使用显示器~");
        }
    }
    public class Machine : ElctronDeceive
    {
        public override void StartUse()
        {
            Console.WriteLine("开始使用主机~");
        }

        public override void StopUse()
        {
            Console.WriteLine("停止使用主机~");
        }
    }
    public class Mouse : ElctronDeceive
    {
        public override void StartUse()
        {
            Console.WriteLine("开始使用鼠标~");
        }

        public override void StopUse()
        {
            Console.WriteLine("停止使用鼠标~");
        }
    }
    public class KeyBorad : ElctronDeceive
    {
        public override void StartUse()
        {
            Console.WriteLine("开始使用键盘~");
        }

        public override void StopUse()
        {
            Console.WriteLine("停止使用键盘~");
        }
    }
    public class HeadSet : ElctronDeceive
    {
        public override void StartUse()
        {
            Console.WriteLine("开始使用耳机~");
        }

        public override void StopUse()
        {
            Console.WriteLine("停止使用耳机~");
        }
    }
    #endregion
}
