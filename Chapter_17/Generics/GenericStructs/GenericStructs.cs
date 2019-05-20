using System;

namespace GenericStructs
{
    struct PieceOfData<T>
    {
        public T Data { get; set; }
        public PieceOfData(T data)
        {
            Data = data;
        }
    }

    class GenericStructs
    {
        static void Main(string[] args)
        {
            var intDataS = new PieceOfData<int>(30);
            var strDataS = new PieceOfData<string>("Hi There!");

            Console.WriteLine("intData = {0}", intDataS.Data);
            Console.WriteLine("stringData = {0}", strDataS.Data);

            Console.ReadKey();
        }
    }
}
