using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace LINQQueriesWithXML1
{
    class LINQQueriesWithXML1
    {
        static void Main(string[] args)
        {
            XDocument xd = 
                new XDocument(
                    new XElement("MyElements",
                        new XElement("first",
                          new XAttribute("color", "red"),
                          new XAttribute("size", "small")),
                        new XElement("second",
                          new XAttribute("color", "white"),
                          new XAttribute("size", "medium")),
                        new XElement("third",
                          new XAttribute("color", "blue"),
                          new XAttribute("size", "large"))
                          )
                    );

            xd.Save("Sample.xml");

            XDocument xdForQuery = XDocument.Load("Sample.xml");
            XElement root = xdForQuery.Element("MyElements");
            // 查询表达式与LINQ to XML的结合使用，用来筛选出XML文档中特定元素的子集
            IEnumerable<XElement> fiveCharElements = from e in root.Elements()
                                        where e.Name.ToString().Length == 5
                                        select e;
       
            foreach (XElement e in fiveCharElements)
                Console.WriteLine(e.Name);

            Console.WriteLine();

            foreach (XElement e in fiveCharElements)
                Console.WriteLine("Name: {0}, Color: {1}, Size: {2}",
                    e.Name, e.Attribute("color").Value, e.Attribute("size").Value);

            // 使用匿名类型创建想要的对象
            var anonymousElement = from e in root.Elements()
                                   select new { e.Name, color = e.Attribute("color").Value };
            Console.WriteLine();
            foreach (var e in anonymousElement)
                Console.WriteLine("{0, -6}, color: {1, -7}", e.Name, e.color);

            Console.ReadKey();
        }
    }
}
