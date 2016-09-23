using eCommerce.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL
{
    public interface IeCommerceRepository
    {

        IEnumerable<Product> GetProduct();

        Product GetProductById();

        void InsertProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int id);

        void Save();

    }
}
