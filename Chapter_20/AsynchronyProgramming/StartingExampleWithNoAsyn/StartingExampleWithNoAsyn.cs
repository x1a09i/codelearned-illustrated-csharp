using System;
// 为了使用WebClient类引入
using System.Net;
// 为了使用Stopwatch类引入
using System.Diagnostics;

namespace StartingExampleWithNoAsyn
{
    class DownloadStringFromWeb
    {
        Stopwatch sw = new Stopwatch();

        public void DoRun()
        {
            const int moreTimes = 6000000;
            sw.Start();

            int t1 = CountCharacters(1, "https://xqzh.me");
            int t2 = CountCharacters(2, "https://xqzh.jp");

            CountMore(1, moreTimes); CountMore(2, moreTimes);
            CountMore(3, moreTimes); CountMore(4, moreTimes);

            Console.WriteLine("Chars in http://xqzh.me : {0}", t1);
            Console.WriteLine("Chars in http://xqzh.jp : {0}", t2);
        }

        private int CountCharacters(int id, string uriString)
        {
            WebClient wc = new WebClient();
            Console.WriteLine("Starting Call{0} : {1, 4:N0}ms", id, sw.Elapsed.TotalMilliseconds);
            string result = wc.DownloadString(new Uri(uriString));
            Console.WriteLine("Call{0} Completed  : {1, 4:N0}ms", id, sw.Elapsed.TotalMilliseconds);

            return result.Length;
        }

        private void CountMore(int id, int extraTimes)
        {
            for (int i = 0; i < extraTimes; i++){
                // Do Nothing but killing the time.
                ;
            }
            Console.WriteLine("End Counting {0} : {1, 4:N0}ms", id, sw.Elapsed.TotalMilliseconds);
        }
    }
    class StartingExampleWithNoAsyn
    {
        static void Main(string[] args)
        {
            DownloadStringFromWeb ds = new DownloadStringFromWeb();
            ds.DoRun();

            Console.ReadKey();
        }
    }
}
