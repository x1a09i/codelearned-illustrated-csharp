using System;

namespace Events
{
    // 1/5 委托声明
    delegate void MyHandler();

    // Publisher
    class Incrementer
    {
        // 2/5 事件声明
        public event MyHandler CountADozen;

        // 3/5 事件触发代码
        public int DoCount()
        {
            int publisherLoopCounter;
            for (publisherLoopCounter = 0; publisherLoopCounter < 120; publisherLoopCounter++)
            {
                if (publisherLoopCounter % 12 == 0)
                    // 注意此处用了简略的写法
                    CountADozen?.Invoke();
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
            // 4/5 事件订阅
            incrementer.CountADozen += IncrementDozensCount;
        }

        // 5/5事件处理程序
        void IncrementDozensCount()
        {
            DozensCount++;
        }
    }

    class PublisherSubscriberPattern
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
