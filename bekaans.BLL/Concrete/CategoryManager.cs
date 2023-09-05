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
    public class CategoryManager : ICategoryService
    {
        private ICategoryDAL _icategorydal;

        public CategoryManager(ICategoryDAL icategorydal)
        {
            _icategorydal = icategorydal;
        }

        public List<Category> GetAll()
        {
           return _icategorydal.GetAll();
        }
    }
}
