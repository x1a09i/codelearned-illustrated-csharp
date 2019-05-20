using System;
using System.Xml.Linq;
using System.Collections.Generic;

namespace MethodsForTraverseXMLTree
{
    class MethodsForTraverseXMLTree
    {
        static void Main(string[] args)
        {
            XDocument playerDoc =
                new XDocument(
                    new XElement("Players",
                        new XElement("Player",
                            new XElement("Name", "Carter"),
                            new XElement("Position", "SG"),
                            new XElement("Position")
                        ),
                        new XElement("Player",
                            new XElement("Name", "McGrady"),
                            new XElement("Position", "SF"),
                            new XElement("Position", "SG")
                        )
                     )
                  );

            // 使用Element()方法获取当前节点（文档）的第一个子XElemet
            XElement root = playerDoc.Element("Players");
            // 使用Descendants()方法获取当前节点（根节点）的所有类型为XElement的子节点
            IEnumerable<XElement> employees = root.Descendants();

            foreach (var emp in employees)
            {
                XElement empNameNode = emp.Element("Name");
                // 在读取XElement的数据时，使用Value属性
                Console.WriteLine(empNameNode.Value);

                IEnumerable<XElement> empPositions = emp.Elements("Position");
                foreach (var position in empPositions)
                    Console.WriteLine("\t{0}", position.Value);
            }

            Console.ReadLine();
        }
    }
}
