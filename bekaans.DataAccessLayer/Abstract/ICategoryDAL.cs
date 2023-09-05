using bekaans.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekaans.DataAccessLayer.Abstract
{
    public interface ICategoryDAL
    {
        List<Category> GetAll();

    }
}
