using bekaans.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace bekaans.Interfaces
{   
    [ServiceContract]
    public interface IProductService
    {

        [OperationContract]
        List<Product> GetAll();


        [OperationContract]
        Product Get(int productid);


        [OperationContract]
        void AddProduct(Product product);


        [OperationContract]
        void DeleteProduct(int product);


        [OperationContract]
        void UpdateProduct(Product product);
    }
}
