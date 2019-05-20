using System;
using System.Threading.Tasks;

namespace ExceptionHandlingInAwaitExpression
{
    class ExceptionHandlingInAwaitExpression
    {
        static void Main(string[] args)
        {
            
            Task t = BadAsync();
            t.Wait();
            // 这里的输出结果都是正常执行——因为你已经处理了所有的异常
            Console.WriteLine("Task Status : {0}", t.Status);
            Console.WriteLine("Task IsFaulted: {0}", t.IsFaulted);

            Console.ReadKey();
        }

        static async Task BadAsync()
        {
            try
            {
                await Task.Run(() => { throw new Exception(); });
            }
            catch
            {
                Console.WriteLine("Exception in BadAsync");
            }
        }
    }
}
