using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.DAL
{
    public class CategoryManagement
    {
        NORTHWNDEntities nORTHWNDEntities = new NORTHWNDEntities();
        public List<Category> ListCategories()
        {
            List<Category> categories =  nORTHWNDEntities.Categories.ToList();
            nORTHWNDEntities.SaveChanges();

            return categories;
        }

        public bool AddCategories(Category category)
        {
            nORTHWNDEntities.Set<Category>().Add(category);

            var isAdded = nORTHWNDEntities.SaveChanges();
            if (isAdded>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteCategories(Category category)
        {
            var deletedCategory = nORTHWNDEntities.Set<Category>().Find(category.CategoryID);
            if (deletedCategory != null)
            {
                nORTHWNDEntities.Set<Category>().Remove(deletedCategory);
            }
            else
            {
                return false;
            }
            
            var isDeleted = nORTHWNDEntities.SaveChanges();
            if (isDeleted > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
