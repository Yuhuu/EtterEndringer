using OnlineWebShop.DAL;
using OnlineWebShop.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public class ShoppingCartLogic
  {
    public List<CartItem> GetCartItems()
    {
      var dal = new ShoppingCartDAL();
      List<CartItem> allCart = dal.GetCartItems();
      return allCart;
    }

    public void AddToCart(int id)
    {
      var dal = new ShoppingCartDAL();
      dal.AddToCart(id);
    }

    public CartItem findCartItem(String id)
    {
      var dal = new ShoppingCartDAL().findCartItem(id);
      return dal;
    }

    public CartItem Delete(String id)
    {
      var dal = new ShoppingCartDAL();
      return dal.Delete(id);

    }
    public void DeleteConfirmed(String id) {
      var dal = new ShoppingCartDAL();
      dal.DeleteConfirmed(id);

    }
  }
}
