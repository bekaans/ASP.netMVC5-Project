using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bekaans.Entities
{
    public class Cart
    {
        List<CartLine> lines = new List<CartLine>();
        public void AddToCart(Product product,int quantity)
        {
            CartLine cartline = lines.FirstOrDefault(c => c.Product.ProductID == product.ProductID);
            if(cartline == null)
            {
                lines.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                cartline.Quantity += quantity;
            }
            
        }
        public void RemoveFromCart(Product product)
        {
            lines.RemoveAll(p => p.Product.ProductID == product.ProductID);
        }
        public decimal TotalPrice
        {
            get { return lines.Sum(c => c.Product.UnitPrice + c.Quantity); }
        }
        public void Clear()
        {
            lines.Clear();
        }
        public List<CartLine> GetAll
        {
            get { return lines; }
        }
        public class CartLine 
        {
            public Product Product { get; set; }
            public int Quantity { get; set; }
        }
    }
}
