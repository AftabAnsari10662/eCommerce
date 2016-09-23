using eCommerce.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Web.Controllers
{
    public class ProductController : Controller
    {

        private readonly eCommerceRepository _repository;
        public ProductController()
        {
            _repository = new eCommerceRepository();
        }

        public ActionResult Index()
        {
            var model = _repository.GetProduct();
            return View(model);
        }

    }
}
