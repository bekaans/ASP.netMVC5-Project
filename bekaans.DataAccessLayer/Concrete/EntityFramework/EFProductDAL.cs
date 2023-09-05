using bekaans.DataAccessLayer.Abstract;
using bekaans.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekaans.DataAccessLayer.Concrete.EntityFramework
{
  
    public class EFProductDAL : IProductDAL
    {   
        private Context _context = new Context();

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int productid)
        {
            _context.Products.Remove(_context.Products.FirstOrDefault(x => x.ProductID == productid));
            _context.SaveChanges();
        }

        public Product Get(int productid)
        {
            return _context.Products.FirstOrDefault(x => x.ProductID == productid);
           
        }

        public List<Product> GetAll()
        {
           return _context.Products.ToList();
           
        }

        public void UpdateProduct(Product product)
        {
            Product 
            productToUpdate = _context.Products.FirstOrDefault(x => x.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            _context.SaveChanges();
        }
    }
}
