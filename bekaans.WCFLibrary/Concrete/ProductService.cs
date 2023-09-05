using bekaans.BLL.Concrete;
using bekaans.DataAccessLayer.Concrete.EntityFramework;
using bekaans.Entities;
using bekaans.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekaans.WCFLibrary.Concrete
{
    public class ProductService : IProductService
    {
        private ProductManager _productManager = new ProductManager(new EFProductDAL());
        public void AddProduct(Product product)
        {
           _productManager.AddProduct(product);
        }

        public void DeleteProduct(int product)
        {
           _productManager.DeleteProduct(product);
        }

        public Product Get(int productid)
        {
          return _productManager.Get(productid);
        }

        public List<Product> GetAll()
        {
           return _productManager.GetAll();
        }

        public void UpdateProduct(Product product)
        {
           _productManager.UpdateProduct(product);
        }
    }
}
