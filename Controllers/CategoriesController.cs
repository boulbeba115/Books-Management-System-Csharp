using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class CategoriesController
    {
        public static List<Category> getAllCategories(out String error)
        {
            return Category.getAllCategories(out error);
        }
        public static void addCategory (Category c, out String error)
        {
            Category.AddCategory(c,out error);
        }

        public static void UpdateCategory(Category c, out string error)
        {
            Category.UpadateCategory(c, out error);
        }
    }
}
