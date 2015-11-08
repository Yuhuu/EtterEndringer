using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using System.Web;
using OnlineWebShop.MODEL;

namespace OnlineWebShop.DAL
{
  public class ShoppingCartDAL
  {
    private OnlineStoreEntities _db = new OnlineStoreEntities();
    public const string CartSessionKey = "CartId";

    private string ShoppingCartId;

    public void AddToCart(int id)
    {
      // Retrieve the product from the database.           
      ShoppingCartId = GetCartId();

      var cartItem = _db.CartItems.SingleOrDefault(
          c => c.CartId == ShoppingCartId
          && c.VareId == id);
      if (cartItem == null)
      {
        // Create a new cart item if no cart item exists.                 
        cartItem = new CartItem
        {
          ItemId = Guid.NewGuid().ToString(),
          VareId = id,
          CartId = ShoppingCartId,
          Vare = _db.Vareer.SingleOrDefault(
           p => p.VareId == id),
          Quantity = 1,
          UnitSum = _db.Vareer.SingleOrDefault(
           p => p.VareId == id).Pris,
        };

        _db.CartItems.Add(cartItem);

      }
      else
      {
        // If the item does exist in the cart,                  
        // then add one to the quantity.                 
        cartItem.Quantity++;
        cartItem.UnitSum = (_db.Vareer.SingleOrDefault(
            p => p.VareId == id).Pris * (decimal)cartItem.Quantity);
      }
      _db.SaveChanges();
    }
    public CartItem findCartItem(String id) {
      var db = new OnlineStoreEntities();
  
      CartItem cartItem = db.CartItems.Find(id);
 
      return cartItem;
    }

    public string GetCartId()
    {
      if (HttpContext.Current.Session[CartSessionKey] == null)
      {
        if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
        {
          HttpContext.Current.Session[CartSessionKey] = HttpContext.Current.User.Identity.Name;
        }
        else
        {
          // Generate a new random GUID using System.Guid class.     
          Guid tempCartId = Guid.NewGuid();
          HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
        }
      }
      return HttpContext.Current.Session[CartSessionKey].ToString();
    }

    public List<CartItem> GetCartItems()
    {
      ShoppingCartId = GetCartId();
      return _db.CartItems.Where(
          c => c.CartId == ShoppingCartId).ToList();
    }

    public CartItem Delete(String id)
    {
      var db = new OnlineStoreEntities();
   
      CartItem cartItem = db.CartItems.Find(id);
  
      return cartItem;

    }

      public void DeleteConfirmed(String id)
    {
      var db = new OnlineStoreEntities();
       CartItem cartItem = db.CartItems.Find(id);
       db.CartItems.Remove(cartItem);
       db.SaveChanges();}
     }
  }


