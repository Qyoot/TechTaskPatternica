using System;
using System.IO;
using System.Xml.Serialization;

namespace TechTaskPatternica
{
   public static class Deserialize
   {
        static XmlSerializer xs = new XmlSerializer(typeof(CATALOG));
        static CATALOG catalog;
        static string path = Path.Combine(Environment.CurrentDirectory, "TaskXML.xml");

        public static CATALOG GetCatalog()
        {
            using (FileStream stream = File.Open(path, FileMode.Open))
            {
                catalog = (CATALOG)xs.Deserialize(stream);
            }
            return catalog;
        }
    }
}
