using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core
{
    public class CartItem
    {

        public int Id { get; set; }

        public string CartId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }


        public DateTime CreatedDateTime { get; set; }

        public virtual Product Product { get; set; }
    }
}
