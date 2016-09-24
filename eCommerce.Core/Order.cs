using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core
{
    public class Order
    {

        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }

        public decimal Total { get; set; }

        public string PaymentTransactionId { get; set; }

        public bool HasBeenShipped { get; set; }

        public List<OrderDetail> OrderItems { get; set; }
    }
}
