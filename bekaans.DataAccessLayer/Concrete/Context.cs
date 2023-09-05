using bekaans.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekaans.DataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
