using System;
using System.Threading.Tasks;

namespace ParallelForeach
{
    class ParallelForeach
    {
        static void Main(string[] args)
        {
            string[] iHaveADream = new string[]
                { "We", "hold", "these", "truths", "to", "be", "self-evident",
                    "that", "all", "men", "are", "created", "equal"};
            // 输出结果同样是乱序
            Parallel.ForEach(iHaveADream, i => Console.WriteLine("{0} has {1} letters", i, i.Length));

            Console.ReadKey();
        }
    }
}
