using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    public class Category : TitleE
    {
        public string CategoryName { get; set; }
        public Category(string categoryNamne)
        {
            CategoryName = categoryNamne;
        }
        public override string ToString()
        {
            return CategoryName;
        }
    }
}
