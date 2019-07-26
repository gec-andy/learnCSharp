using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_算法之求质数
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 求质数
            /*
                输出1-1000之间的素数
             */

            for (int i = 2; i < 1001; i++)
            {
                bool isZhishu = true;
                for (int j = 0; j < i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        isZhishu = false;
                        break;
                    }
                }
                if (isZhishu)
                {
                    Console.WriteLine(i + "是质数~");
                }
            }
            #endregion
        }
    }
}
