using bekaans.DataAccessLayer.Abstract;
using bekaans.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekaans.DataAccessLayer.Concrete.EntityFramework
{
    public class EFCategoryDAL : ICategoryDAL
    {
        Context context = new Context();
        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }
    }
}
