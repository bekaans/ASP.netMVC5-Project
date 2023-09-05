using bekaans.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekaans.DataAccessLayer.Abstract
{
    public interface IProductDA 
    {
        List<Product> GetAll();
        Product Get(int productid);
        void AddProduct(Product product);
        void DeleteProduct(int productid);
        void UpdateProduct(Product product);
    }
}
