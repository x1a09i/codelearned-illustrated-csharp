using System;
using System.Linq;

namespace groupClause
{
    class GroupClause
    {
        static void Main(string[] args)
        {
            var players = new[]
            {
                new { FNmame = "Carter", LName="Vince", Position="SG" },
                new { FNmame = "Ming", LName="Yao", Position="C" },
                new { FNmame = "McGrady", LName="Tracy", Position="SF" },
                new { FNmame = "O'Neal", LName="Shaq", Position="C" },
                new { FNmame = "Pierce", LName="Paul", Position="SG" },
                new { FNmame = "Paul", LName="Chris", Position="PG" },
                new { FNmame = "Nash", LName="Steve", Position="PG" },
                new { FNmame = "Garnett", LName="Kevin", Position="PF" },
                new { FNmame = "Durant", LName="Kevin", Position="SF" },
                new { FNmame = "Duncan", LName="Tim", Position="PF" }
            };

            var positionQuery = from p in players
                                orderby p.Position
                                group p by p.Position;

            foreach(var group in positionQuery)
            {
                // 使用Key关键字获取分组字段的信息
                Console.WriteLine(group.Key);

                foreach (var player in group)
                {
                    Console.WriteLine("\t{0} {1}", player.LName, player.FNmame);
                }
            }
            Console.ReadKey();
        }
    }
}
