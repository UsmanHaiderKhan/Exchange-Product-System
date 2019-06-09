using EPSClassLibrary;
using EPSClassLibrary.ProductMgmt;
using EPSClassLibrary.UserMgmt;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EPS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User u = (User)Session[WebUtil.CURRENT_USER];
            if (u == null)
            {
                return RedirectToAction("Login", "User", new { ctl = "Home", act = "Index" });
            }
            ViewBag.recomProds = new ProductHandler().RecommendedProductsForHomepage(u);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "EPS is Exchange Product System. First Ever In Pakistan";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For Any Queries, Dont Hesitate to Contact Us";

            return View();
        }

        [Route("item/{_item}")]
        public ActionResult ItemPage(String _item)
        {
            return View();
        }

        [Route("post")]
        public ActionResult Post()
        {
            return View();
        }

        public ActionResult Messages()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string search)
        {
            List<Product> products = new ProductHandler().SearchProduct(search);
            return View(products);
        }


        //[HttpGet]
        //public ActionResult GetCat()
        //{
        //    List<Category> categories = new ProductHandler().GetCategories();
        //    return View(categories);
        //}
    }
}
