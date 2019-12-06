using DbFirst.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.BLL
{
    public class CategoryController
    {
        CategoryManagement categoryManagement = new CategoryManagement();
        public List<Category> GetListCategories()
        {
            List<Category> categories = categoryManagement.ListCategories();
            return categories;
            
        }

        public bool AddCategory(Category category)
        {
            bool isAdded = categoryManagement.AddCategories(category);
            return isAdded;
        }
        public bool DeleteCategory(Category category)
        {
            bool isDeleted = categoryManagement.DeleteCategories(category);
            return isDeleted;
        }
    }
}
