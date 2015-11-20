
using OnlineWebShop.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineWebShop.DAL
{
  public class Vare
  {
    [Key]
    public int VareId { get; set; }
    public string ProduktNavn { get; set; }
    public string ProduktMerke { get; set; }
    public decimal Pris { get; set; }
    public string ProduktDescription { get; set; }
    public string PicUrl { get; set; }
  }
  public partial class OnlineStoreEntities : DbContext
  {
      public OnlineStoreEntities()
          : base("name=OnlineStoreEntities")
      {
        // Database.CreateIfNotExists();
      }
     // public DbSet<Kunde> Kunder { get; set; }
      public DbSet<Vare> Vareer { get; set; }
      public DbSet<CartItem> CartItems { get; set; }
      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        // Add any configuration or mapping stuff here
      }
     // public System.Data.Entity.DbSet<webshop.Models.dbBruker> dbBrukers { get; set; }
    }
}
