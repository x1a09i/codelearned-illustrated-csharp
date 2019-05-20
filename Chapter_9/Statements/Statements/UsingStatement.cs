// 注意此处的两个using都是指令，不是语句
using System;
using System.IO;

namespace Statements
{
    class UsingStatement
    {
        static void Main(string[] args)
        {
            // 这才是using语句
            using (TextWriter tw = File.CreateText("Lincoln.txt"))
            {
                tw.WriteLine("Valar Morghulis!");
            }

            using (TextReader tr = File.OpenText("Lincoln.txt"))
            {
                string inputString;
                while (null != (inputString = tr.ReadLine()))
                    Console.WriteLine(inputString);
            }

            Console.ReadKey();
        }
    }
}
