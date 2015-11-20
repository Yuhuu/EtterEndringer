using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineWebShop.MODEL
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
}
