using bekaans.DataAccessLayer.Abstract;
using bekaans.Entities;
using bekaans.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekaans.BLL.Concrete
{
   
    public class ProductManager : IProductService
    { 
        IProductDAL _iproductdal;

        public ProductManager(IProductDAL iproductdal)
        {
            _iproductdal = iproductdal;
        }

        public void AddProduct(Product product)
        { 
          _iproductdal.AddProduct(product);
        }

        public void DeleteProduct(int product)
        {
           _iproductdal.DeleteProduct(product);
        }

        public Product Get(int productid)
        {
            return _iproductdal.Get(productid);
        }

        public List<Product> GetAll()
        {
           return _iproductdal.GetAll();
        }

        public void UpdateProduct(Product product)
        {
           _iproductdal.UpdateProduct(product);
        }
    }
}
