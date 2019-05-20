using System;
using System.Collections;
// 此处一定要添加对泛型版本类库的引用
using System.Collections.Generic;

namespace GenericEnumerationInterfaces
{
    // 可枚举类
    class Spectrum<T> : IEnumerable<T>
    {
        T[] genericArr;
        public Spectrum(T[] paramArr)
        {
            genericArr = new T[paramArr.Length];
            for(int i =0; i< paramArr.Length; i++)
                genericArr[i] = paramArr[i];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ColorEnumerator<T>(genericArr);
        }
        // 继承自非泛型版本接口中的方法也必须实现一次
        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
    // 枚举器
    class ColorEnumerator<T> : IEnumerator<T>
    {
        T[] _array;
        int _position = -1;

        // 构造函数
        public ColorEnumerator(T[] theColors)
        {
            _array = theColors;
        }
        // Current属性实现
        public T Current
        {
            get
            {
                if (_position < 0)
                    throw new InvalidOperationException();
                if (_position >= _array.Length)
                    throw new InvalidOperationException();
                return _array[_position];
            }
        }
        // Current属性实现(非泛型)
        object IEnumerator.Current{ get; }
        // MoveNext方法实现
        public bool MoveNext()
        {
            if (_position == _array.Length - 1)
                return false;

            _position++;
            return true;
        }
        // Reset方法实现
        public void Reset() { _position = -1; }
        // Dispose方法实现
        public void Dispose()
        {
            // Nothing here...
        }
    }
    class GenericEnumerationInterfaces
    {
        static void Main(string[] args)
        {
            var spectrumInt = new Spectrum<int>
                (new int[] { 1, 2, 3, 4, 5 });
            var spectrumString = new Spectrum<string>
                (new string[] { "1st", "2nd", "3rd", "4th", "5th" });

            foreach (var val in spectrumInt)
                Console.WriteLine(val);
            Console.WriteLine();
            foreach (var val in spectrumString)
                Console.WriteLine(val);

            Console.ReadKey();
        }
    }
}
