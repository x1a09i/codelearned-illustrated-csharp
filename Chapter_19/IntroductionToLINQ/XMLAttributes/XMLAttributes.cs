using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace XMLAttributes
{
    class XMLAttributes
    {
        static void Main(string[] args)
        {
            XAttribute extraAttr = new XAttribute("extra", "Valar Morghulis!");
            XDocument xdoc =
                new XDocument(
                    new XElement("root",
                      // 创建标签属性时，直接将XAttribute写在标签元素之后即可
                      new XAttribute("color", "red"),
                      new XAttribute("size", "small"),
                      extraAttr,
                    new XElement("first"),
                    new XElement("second")
                    )
                );

            Console.WriteLine("Original Tree:\n" + xdoc);
            xdoc.Save("fake.xml");
            XElement root = xdoc.Element("root");

            // 使用节点的Attribute方法来获取属性的数据内容
            Console.WriteLine("\nGet Attributes Data:");
            IEnumerable<XAttribute> attrs = root.Attributes();
            foreach (var attr in attrs)
                Console.WriteLine(attr.Value);

            // 使用Remove()方法或SetAttributeValue(x, null)方法来删除标签属性
            Console.WriteLine("\nAfter Remove Attributes:");
            root.Attribute("color").Remove();
            root.SetAttributeValue("size", null);
            Console.WriteLine(root);

            // 通过SetAttributeValue()方法来修改或添加属性
            Console.WriteLine("\nAfter Modify Attributes:");
            root.SetAttributeValue("new-color", "Purple");
            root.SetAttributeValue("extra", "Valar Dohaeris!");
            Console.WriteLine(root);

            Console.ReadKey();
        }
    }
}
