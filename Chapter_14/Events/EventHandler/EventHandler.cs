using System;

namespace EventHandler
{
    //// 委托声明 → 并不需要
    //delegate void MyHandler();

    // Publisher
    class Incrementer
    {
        // 事件声明
        public event System.EventHandler CountADozen;

        // 事件触发代码
        public int DoCount()
        {
            int publisherLoopCounter;
            for (publisherLoopCounter = 0; publisherLoopCounter <= 120; publisherLoopCounter++)
            {
                if (publisherLoopCounter > 0 && publisherLoopCounter % 12 == 0)
                    // 注意此处的参数传递方式
                    CountADozen(this, null);
            }
            return publisherLoopCounter;
        }
    }
    // Subscriber
    class Dozens
    {
        public int DozensCount { get; private set; }

        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            // 事件订阅
            incrementer.CountADozen += IncrementDozensCount;
        }

        // 事件处理程序 → 签名与EventHandler委托类型保持一致
        void IncrementDozensCount(object o, EventArgs e)
        {
            DozensCount++;
        }
    }
    class EventHandler
    {
        static void Main(string[] args)
        {
            Incrementer incrementer = new Incrementer();
            Dozens dozens = new Dozens(incrementer);

            Console.WriteLine("Count {0} times", incrementer.DoCount());
            Console.WriteLine("Number of dozens is {0}", dozens.DozensCount);

            Console.ReadKey();
        }
    }
}
