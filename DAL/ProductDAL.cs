using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineWebShop.MODEL;



namespace OnlineWebShop.DAL
{
  public class ProductDAL
  {
   public List<Vare> getAll()
    {
      using (var db = new OnlineStoreEntities())
      {
        List<Vare> VarerFraDb = db.Vareer.ToList();
        List<Vare> allProduct = new List<Vare>();
        foreach (var vare in VarerFraDb)
        {
          var enVare = new Vare();
          enVare.Antall = vare.Antall;
          enVare.Pris = vare.Pris;
          enVare.ProduktNavn = vare.ProduktNavn;
          enVare.ProduktMerke = vare.ProduktMerke;
          enVare.VareId = vare.VareId;
          allProduct.Add(enVare);
        }
        return allProduct;
      }
    }

   public bool insertNewProduct(Vare NyProdukt)
    {
      var db = new OnlineStoreEntities();
      using (var dbTransaksjon = db.Database.BeginTransaction())
      {
        var nyVare = new Vare()
        {   // en annen måte å initsiere attributter i en klasse når den
            //instansieres (må ikke ha konstruktør for å gjøre dette)
          Antall = NyProdukt.Antall,
          ProduktNavn = NyProdukt.ProduktNavn,
          ProduktMerke = NyProdukt.ProduktMerke,
          Pris = NyProdukt.Pris
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

    public bool editProduct(int id, Vare innProduct)
    {
      return true;
    }

  }
}
