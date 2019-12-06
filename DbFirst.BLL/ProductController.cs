using DbFirst.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.BLL
{
    public class ProductController
    {
        ProductManagement productManagement = new ProductManagement();
        public List<Product> GetListProducts()
        {
            List<Product> products = productManagement.GetListProducts();
            return products;
        }
        public bool AddProduct(Product product)
        {
            bool isAdded = productManagement.AddProducts(product);
            return isAdded;
        }
        public bool DeletedProduct(Product product)
        {
            bool isDeleted = productManagement.DeleteProducts(product);
            return isDeleted;
        }
    }
}
