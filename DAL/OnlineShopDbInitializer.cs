using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OnlineWebShop.MODEL;

namespace OnlineWebShop.DAL
{
  //public class OnlineShopDbInitializer : DropCreateDatabaseIfModelChanges<OnlineStoreEntities>
     public class OnlineShopDbInitializer : CreateDatabaseIfNotExists<OnlineStoreEntities>
  {
    protected override void Seed(OnlineStoreEntities context)
    {
     // new List<Kunde>
     // {
     //  new Kunde { Navn = "roger", Adresse = "adress norway", Epost = "hello1hotmail.com" },
     //  new Kunde { Navn = "Person", Adresse = "Høyskolen0726Oslo",Epost = "hellohotmail.com"},
     //  new Kunde { Navn = "lop", Adresse = "Høyskolen0726Oslo", Epost = "hello@hotmail.com"},
     //  new Kunde { Navn = "aaaeee", Adresse = "Høyskolen0726 Oslo",Epost = "hellotmail.com" },
     // new Kunde { Navn = "jpe", Adresse = "Høyskolen0433Oslo",Epost = "hellocom" },
     //new Kunde { Navn = "kina", Adresse = "adress korea",Epost = "hello6@hotmail.com" }
     //          }.ForEach(a => context.Kunder.Add(a));
     // context.SaveChanges();
     new List<Vare>
     {
       new Vare { ProduktNavn = "Model-2014-navesti", ProduktMerke = "navesti", Pris = 223M, ProduktDescription = "...", PicUrl = ".-d" },
        new Vare { ProduktNavn = "Model-2011-apple", ProduktMerke = "Apple", Pris = 323M, ProduktDescription = "...", PicUrl = ".-d" },
          new Vare { ProduktNavn = "Model-2005-navesti", ProduktMerke = "HTC", Pris = 3241M, ProduktDescription = "...", PicUrl = ".-d" },
        new Vare { ProduktNavn = "Model-2014-vpl", ProduktMerke = "HP", Pris = 2344M, ProduktDescription = "...", PicUrl = ".-d"},
          new Vare { ProduktNavn = "Model-2015-volve", ProduktMerke = "HTC", Pris = 2241M, ProduktDescription = "...", PicUrl = ".-d"},
        new Vare { ProduktNavn = "Model-2014-naHPvesti", ProduktMerke = "HP", Pris = 24344M, ProduktDescription = "...", PicUrl = ".-d"},
          new Vare { ProduktNavn = "Model-2015-Hifi", ProduktMerke = "HTC", Pris = 9241M, ProduktDescription = "...", PicUrl = ".-d" },
        new Vare { ProduktNavn = "Model-2004-naHPvesti", ProduktMerke = "HP", Pris = 2344M, ProduktDescription = "...", PicUrl = ".-d" },
          new Vare { ProduktNavn = "Model-2015-navesti", ProduktMerke = "HTC", Pris = 241M, ProduktDescription = "...", PicUrl = ".-d" },
        new Vare { ProduktNavn = "Model-2017-naHPvesti", ProduktMerke = "HP", Pris = 2344M, ProduktDescription = "...", PicUrl = ".-d" }
     }.ForEach(a => context.Vareer.Add(a));
     //// Kunde = context.Kunder.Single(g => g.KId == 5)
     context.SaveChanges();
      base.Seed(context);
    }
  }
}
