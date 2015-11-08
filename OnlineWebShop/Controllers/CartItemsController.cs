using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webshop.Models;

namespace webshop.Controllers
{
    public class CartItemsController : Controller
    {
        

        // GET: CartItems
        public ActionResult Index()
        {
        var cart = new ShoppingCartLogic();
        var cartItem = cart.GetCartItems();
            return View(cartItem.ToList());
        }

    // GET: CartItems/Details/5
    public ActionResult Details(string id)
    {
      var cart = new ShoppingCartLogic();
      var cartItem = cart.findCartItem(id);
      return View(cartItem);

    }
     
        // GET: CartItems/Delete/5
        public ActionResult Delete(string id)
        {
      var cart = new ShoppingCartLogic();
      var cartItem = cart.Delete(id);
      return View(cartItem);
        }

        // POST: CartItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
      var cart = new ShoppingCartLogic();
      var cartItem = cart;
      return View(cartItem);
      return RedirectToAction("Index");
    }
    public ActionResult AddToCart(int id)
    {
      var cart = new ShoppingCartLogic();
      cart.AddToCart(id);
      var cartItem = cart.GetCartItems();
      return View(cartItem);
    }

    public ActionResult Checkout()
    {
      var cart = new ShoppingCartLogic();
      var cartItem = cart.GetCartItems();

      if (Session["InnLogget"] != null)
      {
        Session["InnLogget"] = true;
        ViewBag.Loggetinn = true;
        return View(cartItem.ToList());
      }
      else
      {
        Session["InnLogget"] = false;
        ViewBag.Loggetinn = false;
        return RedirectToAction("../Sikkerhet/Index");
      }

    }

    public ActionResult Kvittering()
    {
      var cart = new ShoppingCartLogic();
      var cartItem = cart.GetCartItems();

      if (Session["InnLogget"] != null)
      {
        Session["InnLogget"] = true;
        ViewBag.Loggetinn = true;
        return View(cartItem.ToList());
      }
      else
      {
        Session["InnLogget"] = false;
        ViewBag.Loggetinn = false;
        return RedirectToAction("../Sikkerhet/Index");
      }
    }
    //protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }
    }
}
