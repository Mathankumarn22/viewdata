using System.Collections.Generic;
using OnlineMobileShop.Entity;
using OnlineMobileShop.Respository;
using System.Web.Mvc;


namespace OnlineMobileShop.Controllers
{
    public class MobileController : Controller
    {
        // GET: Mobile
        public ActionResult MobileDetails()
        {
            IEnumerable<Mobile> mobile = MobileRespository.GetDetails();
            ViewBag.Mobile = mobile;
            ViewData["mobile"] = mobile;
            TempData["mobile"] = mobile;
            return RedirectToAction("DisplayDetails");
        }
        public ActionResult DisplayDetails()
        {
            return View();
        }
    }
}