using bekaans.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekaans.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Get();
        void AddProduct(Product product);
        void DeleteProduct(int product);
        void UpdateProduct(Product product);
    }
}
