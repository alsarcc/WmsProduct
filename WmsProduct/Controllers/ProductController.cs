using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WmsProduct.Models;

namespace WmsProduct.Controllers
{
    public class ProductController : Controller
    {

        private ApplicationDbContext _context;

        public ProductController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Product
        public ActionResult Index()
        {
            var products = _context.Products
                .ToList();

            return View(products);
        }
    }
}