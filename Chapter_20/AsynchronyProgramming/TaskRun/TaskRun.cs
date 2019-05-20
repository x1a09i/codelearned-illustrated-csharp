using System;
using System.Threading.Tasks;

namespace TaskRun
{
    class MyClass
    {
        int GetTen() { return 10; }

        int GetSum(int x, int y) { return x + y; }

        public async Task DoWorkAsync()
        {
            // ①将Run()方法的参数设为委托的变量
            Func<int> delGetTen = new Func<int>(GetTen);
            int a = await Task.Run(delGetTen);
            // ②将Run()方法的参数直接设为委托
            int b = await Task.Run(new Func<int>(GetTen));
            // ③直接把Lambda表达式用作Run()方法的参数
            int c = await Task.Run(() => 10);

            Console.WriteLine("{0} {1} {2}", a, b, c);

            // ④使用委托第一类形式：Action。不接受参数，没有返回值（仅执行代码）
            await Task.Run(() => Console.WriteLine(5.ToString()));
            // ⑤使用委托第二类形式：TResult Func()。不接受参数，返回特定简单类型（如int， string等）
            Console.WriteLine(await Task.Run(() => 6.ToString()));
            // ⑥使用委托第三类形式：Task Func()。不接受参数，返回特定Task类型
            await Task.Run(() => Task.Run(() => Console.WriteLine(7.ToString())));
            // ⑤使用委托第四类形式：Task<TResult> Func()。不接受参数，返回特定Task<T>类型
            int value = await Task.Run(() => Task.Run(() => 8));
            Console.WriteLine(value);

            // 使用Lambda表达式来执行传参操作（调用自己创建的方法）
            Console.WriteLine(await Task.Run(() => GetSum(5, 6)));
        }
    }
    class TaskRun
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            Task t = mc.DoWorkAsync();
            // 如果没有调用Wait()方法，("It's OVER!")字符串将输出于运行结果之前
            t.Wait();
            Console.WriteLine("It's OVER!");

            Console.ReadKey();
        }
    }
}
