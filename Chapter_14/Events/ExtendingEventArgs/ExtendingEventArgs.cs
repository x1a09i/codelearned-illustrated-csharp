using System;

namespace ExtendingEventArgs
{
    // 自定义一个派生自EventArgs的类，用来传递参数
    public class IncrementeEventArgs : EventArgs
    {
        public int IterationCount { get; set; }
    }
    // Publisher
    class Incrementer
    {
        // 事件声明时使用泛型
        public event EventHandler<IncrementeEventArgs> CountADozen;

        public void DoCount()
        {
            // 初始化EventArgs派生类
            IncrementeEventArgs args = new IncrementeEventArgs();
            for (int i = 0; i < 120; i++)
            {
                if (i % 12 == 0 && CountADozen != null)
                {
                    args.IterationCount = i;
                    // 传参
                    CountADozen.Invoke(this, args);
                }
            }
        }
    }
    // Subscriber
    class Dozens
    {
        public int DozensCount { get; private set; }

        public Dozens(Incrementer incrementer)
        {
            incrementer.CountADozen += IncrementDozensCount;
        }

        // 参数列表的第二项为自定义的派生类
        void IncrementDozensCount(object source, IncrementeEventArgs e)
        {
            Console.WriteLine("Incremented at iteration: {0} in {1}"
                , e.IterationCount, source.ToString());

            DozensCount++;
        }
    }

    class ExtendingEventArgs
    {
        static void Main(string[] args)
        {
            Incrementer incrementer = new Incrementer();
            Dozens dozen = new Dozens(incrementer);

            incrementer.DoCount();

            Console.WriteLine("Number of dozens is {0}", dozen.DozensCount);

            Console.ReadKey();
        }
    }
}
