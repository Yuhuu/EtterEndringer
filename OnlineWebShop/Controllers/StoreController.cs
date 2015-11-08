using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using webshop.Models;
using System;
using BLL;
using OnlineWebShop.MODEL;

namespace webshop.Controllers
{
    public class StoreController : Controller
    {

        public ActionResult Index()
        {
         var db = new ProductLogic();
         List<Vare> alleBestillinger = db.getAll();
         return View(alleBestillinger);
        }
  }
}
