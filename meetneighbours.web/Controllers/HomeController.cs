using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using meetneighbours.services;
using meetneighbours.services.contracts;

namespace meetneighbours.web.Controllers
{
    public class HomeController : Controller
    {
        //BusinessListsController x = new BusinessListsController();
        
        public ActionResult Index()
        {
            //var y = _BusinessListService.GetAllBusinessLists();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}