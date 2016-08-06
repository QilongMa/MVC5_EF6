using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class ProductController : Controller {
        public ActionResult Index() {
            // Add action logic here
            throw new NotImplementedException();
        }

        public ActionResult Details(int Id) {

            return View("Details");
        }
    }
}