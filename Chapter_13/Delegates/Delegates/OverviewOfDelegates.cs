using System;

namespace Delegates
{
    // 注意，此处定义的是一个委托类型
    delegate void MyDel(int value);

    class OverviewOfDelegates
    {
        void PrintLow(int value)
        {
            Console.WriteLine("{0} - Low Value", value);
        }
        void PrintHigh(int value)
        {
            Console.WriteLine("{0} - High Value", value);
        }

        static void Main(string[] args)
        {
            OverviewOfDelegates overview = new OverviewOfDelegates();
            MyDel del; // Declare delegate variable.
                       
            // Create random-integer-generator object and get a random
            // number between 0 and 99.
            Random rand = new Random();
            int randomValue = rand.Next(99);
            // Create a delegate object that contains either Print

            del = randomValue < 50
            ? new MyDel(overview.PrintLow)
            : new MyDel(overview.PrintHigh);
            del(randomValue); // Execute the delegate. 

            Console.ReadKey();
        }
    }
}
