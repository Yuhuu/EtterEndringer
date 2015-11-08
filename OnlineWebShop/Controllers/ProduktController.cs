using BLL;
using OnlineWebShop.MODEL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace webshop.Controllers
{
  public class ProduktController : Controller
    {
        
        public ActionResult Index()
        {
         var product = new ProductLogic();
         List<Vare> allproduct = product.getAll();
         return View(allproduct);
    }

    //public ActionResult Edit(int? id)
    //{
    //  if (id == null)
    //  {
    //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //  }
    //  var db = new OnlineStoreEntities();
    //  Vare vare = db.Vareer.Find(id);
    //  if (vare == null)
    //  {
    //    return HttpNotFound();
    //  }
    //  return View(vare);
    //}

    //// POST: ShoppingCart/Edit/5
    //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Edit
    //   ([Bind(Include = "VareId,ProduktNavn,ProduktMerke,Pris,Antall")] Vare vare)
    //{
    //  var db = new OnlineStoreEntities();
    //  if (ModelState.IsValid)
    //  {
    //    db.Entry(vare).State = EntityState.Modified;
    //    db.SaveChanges();
    //    return RedirectToAction("Index");
    //  }
    //  //ViewBag.VareId = new SelectList(db.Vareer, "VareId", "ProduktNavn", vare.VareId);
    //  return View(vare);
    //}

    public ActionResult NyVare()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NyVare(Vare vare)
        {
            var db = new ProductLogic();
            if(db.insertNewProduct(vare))
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}