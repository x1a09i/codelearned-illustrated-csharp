using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ManipulatingXMLTree
{
    class ManipulatingXMLTree
    {
        static void Main(string[] args)
        {
            XDocument xd = 
                new XDocument(
                    new XElement("root", 
                        new XElement("first")
                    )
                );

            Console.WriteLine("Original Tree:");
            Console.WriteLine(xd);

            XElement root = xd.Element("root");
            // 使用Add()方法添加一个子元素
            root.Add(new XElement("second"));
            // 同时添加多个子元素
            root.Add(new XElement("third")
                ,new XComment("Some AWESOME comments here!")
                ,new XElement("fourth"));

            Console.WriteLine("\r\nModified Tree");
            Console.WriteLine(xd);

            root.SetElementValue("fourth", "new value here!");
            Console.WriteLine(xd);

            Console.ReadKey();
        }
    }
}
