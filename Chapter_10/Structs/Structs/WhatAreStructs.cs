using System;

namespace Structs
{
    struct Point
    {
        public int y;
        public int x;
    }
    class WhatAreStructs
    {
        static void Main(string[] args)
        {
            Point p1, p2, p3;

            p1.x = 10; p1.y = 10;
            p2.x = 20; p2.y = 20;
            p3.x = p1.x + p2.x; p3.y = p1.y + p2.y;

            Console.WriteLine("first: {0}, {1}", p1.x, p1.y);
            Console.WriteLine("second: {0}, {1}", p2.x, p2.y);
            Console.WriteLine("third: {0}, {1}", p3.x, p3.y);

            Console.ReadKey();
        }
    }
}
