using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace OtherTypesofNodes
{
    class OtherTypesofNodes
    {
        static void Main(string[] args)
        {
            XDocument xdoc =
                new XDocument(
                    // XML声明（不会在程序中显示）
                    new XDeclaration("1.0", "utf-8", "yes"),
                    // XML注释
                    new XComment("I'm a AWESOME comment!"),
                    // XML处理指令。留意第二参数的用法
                    new XProcessingInstruction("xml-stylesheet",
                                                @"href=""stories.css"" type=""text/css"""),
                    new XElement("root",
                        new XElement("first"),
                        new XElement("second")
                    )
                );

            xdoc.Save("other.xml");
        }
    }
}
