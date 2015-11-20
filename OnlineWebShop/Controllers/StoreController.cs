using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using webshop.Models;
using System;
using BLL;

namespace webshop.Controllers
{
    public class StoreController : Controller
    {

        public ActionResult Index()
        {
         var db = new ProductLogic();
     //    List<OnlineWebShop.MODEL.Vare> alleBestillinger = db.getAll();
         return View(db.getAll());
        }
  }
}
