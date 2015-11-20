using OnlineWebShop.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;




namespace OnlineWebShop.DAL
{
  public class ProductDAL
  {
   public List<MODEL.Vare> getAll()
    {
      using (var db = new OnlineStoreEntities())
      {
        List<Vare> VareFraDb = db.Vareer.ToList();
        List<MODEL.Vare> allProduct = new List<MODEL.Vare>();
        foreach (var vare in VareFraDb)
        {
          var enVare = new MODEL.Vare();
          enVare.Pris = vare.Pris;
          enVare.ProduktNavn = vare.ProduktNavn;
          enVare.ProduktMerke = vare.ProduktMerke;
          enVare.VareId = vare.VareId;
          allProduct.Add(enVare);
        }
        return allProduct;
        //return VareFraDb;
      }
    }

    public Vare getVareWithID(int id)
    {
      using (var db = new OnlineStoreEntities()) {
        return db.Vareer.SingleOrDefault(
             p => p.VareId == id);
        }
    }
    public bool insertNewProduct(Vare NyProdukt)
    {
      var db = new OnlineStoreEntities();
      using (var dbTransaksjon = db.Database.BeginTransaction())
      {
        var nyVare = new Vare()
        {  
          // en annen måte å initsiere attributter i en klasse når den
            //instansieres (må ikke ha konstruktør for å gjøre dette)
          ProduktNavn = NyProdukt.ProduktNavn,
          ProduktMerke = NyProdukt.ProduktMerke,
          Pris = NyProdukt.Pris,
          PicUrl = NyProdukt.PicUrl,
          ProduktDescription = NyProdukt.ProduktDescription
        };
        try
        {
          db.Vareer.Add(nyVare);
          db.SaveChanges();
          dbTransaksjon.Commit();
          return true;
        }
        catch (Exception feil)
        {
          dbTransaksjon.Rollback();
          return false;
        }
      }
    }

    public bool deleteProduct(int slettId)
    {

      return true;
    }

    public Vare editProduct(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      var db = new OnlineStoreEntities();
      Vare vare = db.Vareer.Find(id);
      if (vare == null)
      {
        return HttpNotFound();
      }
      return vare;
    }

    private Vare HttpNotFound()
    {
      throw new NotImplementedException();
    }

    //public Vare getMODEL(Vare vare)
    //{
    //  using (var db = new OnlineStoreEntities())
    //  {
    //    var enVare = new MODEL.Vare();
    //    enVare.Pris = vare.Pris;
    //    enVare.ProduktNavn = vare.ProduktNavn;
    //    enVare.ProduktMerke = vare.ProduktMerke;
    //    enVare.VareId = vare.VareId;
    //    return enVare;
    //  }
    //}
  }

  internal class HttpStatusCodeResult : Vare
  {
    private HttpStatusCode badRequest;

    public HttpStatusCodeResult(HttpStatusCode badRequest)
    {
      this.badRequest = badRequest;
    }
  }
}
