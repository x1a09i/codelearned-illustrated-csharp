using System;
using System.Collections.Generic;

namespace ProducingMultipleEnumerables
{
    class Spectrum
    {
        string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

        // 第一个迭代器：创建序列为 紫外线→红外线 的可枚举类型
        public IEnumerable<string> UVtoIR()
        {
            for (int i = 0; i < colors.Length; i++)
                yield return colors[i];
        }
        // 第二个迭代器：创建序列为 红外线→紫外线 的可枚举类型
        public IEnumerable<string> IRtoUV()
        {
            for (int i = colors.Length - 1; i >= 0; i--)
                yield return colors[i];
        }
    }
    class ProducingMultipleEnumerables
    {
        static void Main(string[] args)
        {
            var spectrum = new Spectrum();
            // 因为Spectrum类本身没有定义GetEnumerator()方法，所以不能直接进行遍历操作
            foreach (var color in spectrum.UVtoIR())
                Console.Write(color + " ");

            Console.WriteLine();

            foreach (var color in spectrum.IRtoUV())
                Console.Write(color + " ");

            Console.ReadKey();
        }
    }
}
