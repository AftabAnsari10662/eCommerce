using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL
{
    public class eCommerceDbFactory:IDbContextFactory<eCommerceDb>
    {
       


        public eCommerceDb Create()
        {

            return new eCommerceDb("DefaultConnection");
        }
    }
}
