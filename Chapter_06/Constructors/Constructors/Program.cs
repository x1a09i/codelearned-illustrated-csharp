using System;

namespace Constructors
{
    class RandomKeyGenerater
    {
        private static Random randomNumber;

        static RandomKeyGenerater()
        {
            randomNumber = new Random();
            // 注意，在身为静态构造函数的情况下，这行代码仅被执行一次
            Console.WriteLine("Done!");
        }

        public int GetRandomNunmer()
        {
            return randomNumber.Next();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RandomKeyGenerater rkga = new RandomKeyGenerater();
            RandomKeyGenerater rkgb = new RandomKeyGenerater();

            Console.WriteLine("The New Number is {0:n}", rkga.GetRandomNunmer());
            Console.WriteLine("The New Number is {0:n}", rkgb.GetRandomNunmer());

            Console.ReadLine();
        }
    }
}
