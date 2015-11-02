using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo.Models;


namespace demo.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        ProductCatalogEntities productDB = new ProductCatalogEntities();
        public ActionResult Index()
        {
            var Categories = productDB.Categories.ToList();
           
            return View(Categories);
        }
        [HttpGet]
        public ActionResult Browse(string Category)
        {
            var CategoryModel = productDB.Categories.Include("Products").Single(c => c.CategoryName == Category);
            return View(CategoryModel);
        }
        public ActionResult Details(int id)
        {
            var product = productDB.Products.Find(id);
            return View(product);
        }
        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var categories = productDB.Categories.ToList();
            return PartialView(categories);
        }
    }
}
