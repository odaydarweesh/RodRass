using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class CategoryRepository
    {
        public static void SaveCategories(List<string> categoryList)
        {
            CategorySerialization.SaveCategories(categoryList);
        }
        public static List<string> GetCategories()
        {
            return CategorySerialization.GetCategories();
        }
    }
}
