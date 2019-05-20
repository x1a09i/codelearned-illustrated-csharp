using System;
using System.Net;
using System.Diagnostics;
// 使用异步编程时必须引入
using System.Threading.Tasks;

namespace StartingExampleWithAsyn
{
    class DownloadStringFromWeb
    {
        Stopwatch sw = new Stopwatch();

        public void DoRun()
        {
            const int moreTimes = 6000000;
            sw.Start();
            // 变化之一：返回值类型 int → Task<int>
            // Task<int>本身是一个占位符对象(placeholder object)
            Task<int> t1 = CountCharactersAsyn(1, "https://xqzh.me");
            Task<int> t2 = CountCharactersAsyn(2, "https://xqzh.jp");

            CountMore(1, moreTimes); CountMore(2, moreTimes);
            CountMore(3, moreTimes); CountMore(4, moreTimes);
            // 变化之二：从各个Task<int>中的Result属性获取结果
            Console.WriteLine("Chars in http://xqzh.me : {0}", t1.Result);
            Console.WriteLine("Chars in http://xqzh.jp : {0}", t2.Result);
        }

        private void CountMore(int id, int extraTimes)
        {
            for (int i = 0; i < extraTimes; i++)
            {
                // Do Nothing but killing the time.
                ;
            }
            Console.WriteLine("End Counting {0} : {1, 4:N0}ms", id, sw.Elapsed.TotalMilliseconds);
        }

        // 变化之三：返回值类型 int → Task<int>、添加async关键字
        private async Task<int> CountCharactersAsyn(int id, string uriString)
        {
            WebClient wc = new WebClient();
            Console.WriteLine("Starting Call{0} : {1, 4:N0}ms", id, sw.Elapsed.TotalMilliseconds);
            // 变化之四：添加await关键字、调用方法为DownloadStringTaskAsync()
            string result = await wc.DownloadStringTaskAsync(new Uri(uriString));
            Console.WriteLine("Call{0} Completed  : {1, 4:N0}ms", id, sw.Elapsed.TotalMilliseconds);

            return result.Length;
        }
    }
    class StartingExampleWithAsyn
    {
        static void Main(string[] args)
        {
            DownloadStringFromWeb ds = new DownloadStringFromWeb();
            ds.DoRun();

            Console.ReadKey();
        }
    }
}
