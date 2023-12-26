using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Data_Layer
{
    public class CategorySerialization
    {
        public static void SaveCategories(List<string> categoryList)
        {
            using (var writer = new StreamWriter("categories.xml"))
            {
                var serializ = new XmlSerializer(typeof(List<string>));
                serializ.Serialize(writer, categoryList);
                writer.Flush();
            }
        }
        public static List<string> GetCategories()
        {
            if (File.Exists("categories.xml") == false)
            {
                return new List<string>();
            }

            using (var stream = File.OpenRead("categories.xml"))
            {
                var serializer = new XmlSerializer(typeof(List<string>));
                return serializer.Deserialize(stream) as List<string>;
            }
        }
    }
}
