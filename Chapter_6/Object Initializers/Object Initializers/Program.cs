using System;

namespace Object_Initializers
{
    class Point
    {
        public int x = 1;
        public int y = 2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point();
            // 对象初始化语句
            Point pt2 = new Point {
                x = 4,
                y = 5
            };

            Console.WriteLine("pt1: {0}, {1}", pt1.x, pt1.y);
            Console.WriteLine("pt2: {0}, {1}", pt2.x, pt2.y);

            Console.ReadLine();
        }
    }
}
