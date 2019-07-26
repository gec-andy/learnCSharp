using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_06_面向对象之类的封装机制复习
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ATM
    {

        private bool IsValidUser { get; set; }
        public Client GetClient(int userId) {
            return new Client();
        }

    }

    public class Client
    {
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public string UserPassworrd { get; set; }

    }
}
