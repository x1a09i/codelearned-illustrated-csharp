using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskYield
{
    class DoStuff
    {
        public static async Task<int> FindSeriesSum(int loopCounter)
        {
            int sum = 0;
            for (int i = 0; i < loopCounter; i++)
            {
                sum += i;
                if (i % 50 == 0)
                {
                    Console.WriteLine("Yield:{0}", sum);
                    // 每50次执行，交出一次处理器控制权
                    await Task.Yield();
                }
            }
            return sum;
        }
    }
    class TaskYield
    {
        static void Main(string[] args)
        {
            Task<int> value = DoStuff.FindSeriesSum(100);
            CountBig(100); CountBig(100);
            CountBig(100); CountBig(100);

            Console.WriteLine("Sum: {0}", value.Result);

            Console.ReadKey();
        }

        static void CountBig(int loopCounter)
        {
            Console.WriteLine("Execute CountBig");
            for (int i = 0; i < loopCounter; i++) ;
            Console.WriteLine("Exit CountBig");
        }
    }
}
