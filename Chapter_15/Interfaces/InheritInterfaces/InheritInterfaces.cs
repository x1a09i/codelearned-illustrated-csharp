using System;

namespace InheritInterfaces
{
    interface IDataRetrieve
    { int GetData(); }

    interface IDataStore
    { void SetData(int x); }

    interface IDataIO:IDataRetrieve, IDataStore
    {
        // Nothing But John Snow.
    }

    class MyData : IDataIO
    {
        public int MyIntVal { get; set; }

        public int GetData()
        { return MyIntVal; }

        public void SetData(int x)
        { MyIntVal = x; }
    }

    class InheritInterfaces
    {
        static void Main(string[] args)
        {
            MyData md = new MyData();
            md.SetData(13);

            Console.WriteLine("The Value is {0}.", md.GetData());
            Console.ReadKey();
        }
    }
}
