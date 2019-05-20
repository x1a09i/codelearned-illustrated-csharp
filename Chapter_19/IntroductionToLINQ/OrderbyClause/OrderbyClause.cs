using System;
using System.Linq;

namespace OrderbyClause
{
    class OrderbyClause
    {
        static void Main(string[] args)
        {
            var players = new[]
            {
                // 此处使用匿名类型来创建数组
                new { FName = "Vince", LName = "Carter", Age = 28, Height =198, Position = "SG" },
                new { FName = "Tracy", LName = "McGrady", Age = 28, Height =203, Position = "SF" },
                new { FName = "Ming", LName = "Yao", Age = 18, Height =229, Position = "C" }
            };

            var query = from p in players
                        orderby p.Age, p.Height descending
                        select new { p.FName, p.LName, p.Position };

            foreach (var player in query)
                Console.WriteLine(player);

            Console.ReadKey();
        }
    }
}
