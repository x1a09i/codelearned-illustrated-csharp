using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAsProperties
{
    class Spectrum
    {
        bool _listFromUVtoIR;
        string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

        public IEnumerator<string> GetEnumerator()
        {
            return _listFromUVtoIR
                ? UVtoIR
                : IRtoUV;
        }

        public Spectrum(bool listFromUVtoIR)
        {
            _listFromUVtoIR = listFromUVtoIR;
        }
        // 迭代器更优雅使用方法——当作属性
        public IEnumerator<string> UVtoIR
        {
            get
            {
                for (int i = 0; i < colors.Length; i++)
                    yield return colors[i];
            }
        }

        public IEnumerator<string> IRtoUV
        {
            get
            {
                for (int i = colors.Length - 1; i >= 0; i--)
                    yield return colors[i];
            }
        }
    }
    class IteratorsAsProperties
    {
        static void Main(string[] args)
        {
            var spectumFromUV = new Spectrum(true);
            var spectumFromIR = new Spectrum(false);

            foreach (var color in spectumFromUV)
                Console.Write(color + " ");

            Console.WriteLine();

            foreach (var color in spectumFromIR)
                Console.Write(color + " ");

            Console.ReadKey();
        }
    }
}
