using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1
{
    [TestClass]
    public class Computer
    {
        public String Name { set; get; }
        public int Price { set; get; }
        public Computer() { }
        public Computer(String name,int price)
        {
            this.Name = name;
            this.Price = price;
        }
        [TestMethod]
        public override string ToString()
        {
            return Name + "(" + Price + ")";
        }
    }
    [TestClass]
    public class Program
    {
        [TestMethod]
        public static void Main(string[] args)
        {
            Computer[] computer =
            {
                new Computer("Lenovo",5000),
                new Computer("Mac",10000),
            };
            XmlSerializer xmlser = new XmlSerializer(typeof(Computer[]));
            String xmlFileName = "c.xml";
            XmlSerialize(xmlser, xmlFileName, computer);
            string xml = File.ReadAllText(xmlFileName);
            Console.WriteLine(xml);
        }
        [TestMethod]
        public static void XmlSerialize(XmlSerializer ser, string fileName, object obj)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }
    }
}
