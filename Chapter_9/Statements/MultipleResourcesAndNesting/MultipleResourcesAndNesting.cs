using System;
using System.IO;

namespace MultipleResourcesAndNesting
{
    class MultipleResourcesAndNesting
    {
        static void Main(string[] args)
        {
            // 嵌套式构造
            using (TextWriter tw1 = File.CreateText("LinColn.txt"))
            {
                tw1.WriteLine("Valar Morghulis!");
                using (TextWriter tw2 = File.CreateText("Franklin.txt"))
                {
                    tw2.WriteLine("Valar Dohaeris!");
                }
            }
            // 多项式构造
            using (TextReader tr1 = File.OpenText("Lincoln.txt"),
                              tr2 = File.OpenText("Franklin.txt"))
            {
                string inputString;

                while (null != (inputString = tr1.ReadLine()))
                    Console.WriteLine(inputString);
                while (null != (inputString = tr2.ReadLine()))
                    Console.WriteLine(inputString);
            }

            Console.ReadKey();
        }
    }
}
