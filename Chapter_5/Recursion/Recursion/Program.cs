using System;

namespace Recursion
{
    class Program
    {
        public void Count(int val)
        {
            if (val == 0)
                return;
            else
                Count(val - 1);

            Console.WriteLine(val);
        }
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.Count(15);

            Console.ReadLine();
        }
    }
}
