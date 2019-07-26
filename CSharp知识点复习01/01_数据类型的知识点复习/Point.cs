using System;
using System.Collections;

namespace _01_数据类型的知识点复习
{
    public struct Point : IComparer
    {
        private int x;
        private int y;
        private int z;
        public int X { get => this.x; set => this.x = value; }
        public int Y { get => this.y; set => this.y = value; }
        public int Z { get => this.z; set => this.z = value; }
        public void Increment()
        {
            this.X++;
            this.Y++;
            this.Z++;
        }
        public void Decrement()
        {
            this.X--;
            this.Y--;
            this.Z--;
        }
        public void Display()
        {
            Console.WriteLine($"{X},{Y},{Z}.");
        }
        public override string ToString()
        {
            return $"{X},{Y},{Z}.";
        }

        public int Compare(object x, object y)
        {
            try
            {
                var point1 = (Point)x;
                var point2 = (Point)y;
                if (point1.X > point2.X && point1.y > point2.y)
                    return 1;
                else if (point1.x < point2.x && point1.y < point2.y)
                    return -1;
                else
                    return 0;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return -1;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Point))
                return false;
            var temp = (Point)obj;
            return temp.x == this.x && temp.y == this.y;
        }
    }



}
