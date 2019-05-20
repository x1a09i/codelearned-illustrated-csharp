using System;
using System.Collections;

namespace IEnumerableAndIEnumerator
{
    // 可枚举类
    class Spectrum : IEnumerable
    {
        string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };
        public IEnumerator GetEnumerator()
        {
            // 虽然此处返回的是枚举器（对象）本身，而不是接口。
            // 但是不要忘了，接口是一个引用类型，所以我们可以通过对实现接口的对象的引用，来获取接口本身的引用（而且还是隐式转换哦！）
            return new ColorEnumerator(colors);
        }
    }
    // 枚举器
    class ColorEnumerator : IEnumerator
    {
        string[] _colors;
        int _position = -1;

        // 构造函数
        public ColorEnumerator(string[] theColors)
        {
            _colors = new string[theColors.Length];
            for (int i = 0; i < theColors.Length; i++)
                _colors[i] = theColors[i];
        }
        // Current属性实现
        public object Current
        {
            get
            {
                if (_position < 0)
                    throw new InvalidOperationException();
                if (_position >= _colors.Length)
                    throw new InvalidOperationException();
                return _colors[_position];
            }
        }
        // MoveNext方法实现
        public bool MoveNext()
        {
            if (_position == _colors.Length - 1)
                return false;

            _position++;
            return true;
        }
        // Reset方法实现
        public void Reset() { _position = -1; }
    }
    class IEnumerableAndIEnumerator
    {
        static void Main(string[] args)
        {
            Spectrum spectrum = new Spectrum();
            foreach (var color in spectrum)
                Console.WriteLine(color);

            Console.ReadKey();
        }
    }
}
