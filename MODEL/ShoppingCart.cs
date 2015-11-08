using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineWebShop.MODEL
{
  public class ShoppingCart
  {
    public string ShoppingCartId { get; set; }

    public const string CartSessionKey = "CartId";
  }
}