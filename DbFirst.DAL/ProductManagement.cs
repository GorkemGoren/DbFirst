using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.DAL
{
    public class ProductManagement
    {
        NORTHWNDEntities nORTHWNDEntities = new NORTHWNDEntities();
        public List<Product> GetListProducts()
        {
            List<Product> products = nORTHWNDEntities.Products.ToList();
            nORTHWNDEntities.SaveChanges();
            return products;
        }
        public bool AddProducts(Product product)
        {

            nORTHWNDEntities.Set<Product>().Add(product);
            int isAdded = nORTHWNDEntities.SaveChanges();

            if (isAdded>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteProducts(Product product)
        {
            var deletedProduct = nORTHWNDEntities.Set<Product>().Find(product.ProductID);
            if (deletedProduct != null)
            {
                nORTHWNDEntities.Set<Product>().Remove(deletedProduct);
            }
            else
            {
                return false;
            }
            var isDeleted = nORTHWNDEntities.SaveChanges();
            if (isDeleted>0)
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
