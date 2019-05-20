using System;
using System.Xml.Linq;

namespace ManipulateXMLDocument
{
    class ManipulateXMLDocument
    {
        static void Main(string[] args)
        {
            // 使用对象创建表达式的语法创建一个完整的XML文档
            XDocument playerXml = 
                new XDocument(
                    new XElement("Players",
                        new XElement("Player",
                            new XElement("Name", "Vince Carter"),
                            new XElement("Age", 32),
                            new XElement("Position", "SG")
                            ),
                        new XElement("Player",
                            new XElement("Name", "Yao Ming"),
                            new XElement("Age", 30),
                            new XElement("Position", "C")
                            )
                        )
                );

            playerXml.Save("player.xml");

            // 使用Load静态方法加载文件
            XDocument playerLoader = XDocument.Load("player.xml");
            // 直接打印
            Console.WriteLine(playerLoader);

            Console.ReadKey();
        }
    }
}
