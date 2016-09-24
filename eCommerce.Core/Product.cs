using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core
{
    public class Product
    {

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public Double UnitPrice { get; set; }

        public string ImagePath { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
