using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core
{
    public class OrderDetail
    {

        public int Id { get; set; }

        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public int Quantity { get; set; }

        public double? UnitPrice { get; set; }

        public string UserName { get; set; }

        public virtual Product Product { get; set; }

        public virtual Order Order { get; set; }
    }
}
