using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using ValidationWithCultureAndDatabase.Models;

namespace ValidationWithCultureAndDatabase.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new MyTestModel();
            model.CurrentCulture = Thread.CurrentThread.CurrentCulture.ToString();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(MyTestModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }
    }
}
