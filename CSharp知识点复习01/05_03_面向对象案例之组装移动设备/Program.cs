using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_面向对象案例之组装移动设备
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface IComputeraable
    {
        void ReadDevice();
        void WriteDevice();
    }
    public class Computer : IComputeraable
    {
        public MobileDevice Device { get; set; }

        public void ReadDevice()
        {
            this.Device.Read();
        }

        public void WriteDevice()
        {
            this.Device.Write();
        }
    }
    public interface IDeviceable
    {
        void Read();
        void Write();
    }
    public abstract class MobileDevice : IDeviceable
    {
        public abstract void Read();
        public abstract void Write();
    }
    public class MobilePhone : MobileDevice
    {
        public override void Read()
        {
            Console.WriteLine("移动手机正在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("移动手机正在写入数据");
        }
    }
    public class MobileDisk : MobileDevice
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘正在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘正在写入数据");
        }
    }
    public class Mp3Player : MobileDevice
    {
        public override void Read()
        {
            Console.WriteLine("Mp3播放器正在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3播放器正在写入数据");
        }
        public static void OnPlayMusic()
        {
            Console.WriteLine("Mp3播放器正在播音乐");
        }
        public static void OnStopPlayMusic()
        {
            Console.WriteLine("Mp3播放器正在停止播音乐");
        }
    }
}
