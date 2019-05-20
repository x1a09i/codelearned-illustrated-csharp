using System;

namespace RemovingEventHandlers
{
    class Publisher
    {
        public event EventHandler SimpleEvent;

        public void RaiseTheEvent() { SimpleEvent?.Invoke(this, null); }
    }

    class Subscriber
    {
        public void MethodA(object o, EventArgs e)
        {
            Console.WriteLine("This is MethodA");
        }
        public void MethodB(object o, EventArgs e)
        {
            Console.WriteLine("This is MethodB");
        }
    }

    class RemovingEventHandlers
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber sub = new Subscriber();

            pub.SimpleEvent += sub.MethodA;
            pub.SimpleEvent += sub.MethodB;
            pub.RaiseTheEvent();

            Console.WriteLine("\r\nRemove MethodB");
            pub.SimpleEvent -= sub.MethodB;
            pub.RaiseTheEvent();

            Console.ReadKey();
        }
    }
}
