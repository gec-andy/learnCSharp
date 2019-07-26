using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_面向对象之收钱借钱模拟
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IGuyActionable
    {
        void GiveCash(Guy guy, decimal aamount);
        void ReceiveCash(decimal amount);
        void DisplayInfo();
    }
    public class Guy : IGuyActionable
    {
        public string Name { get; set; }
        public decimal Cash { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"姓名：{this.Name}, 现金：{this.Cash}");
        }

        public void GiveCash(Guy guy, decimal amount)
        {
            if (this.Cash > 0)
                guy.ReceiveCash(amount);
            else
                Console.WriteLine("现金不足,无法给钱！！");
        }

        public void ReceiveCash(decimal amount)
        {
            if (amount > 0)
                this.Cash += amount;
        }
    }
}
