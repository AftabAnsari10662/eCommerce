using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL
{
    public class eCommerceRepository : IeCommerceRepository
    {
        private readonly eCommerceDb _db;
        public eCommerceRepository()
        {
            _db = new eCommerceDb("DefaultConnection");
        }

        public IEnumerable<Core.Product> GetProduct()
        {

            var products = _db.Products.ToList();

            return products;
        }

        public Core.Product GetProductById()
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(Core.Product product)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Core.Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
