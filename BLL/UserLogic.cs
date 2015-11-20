using System;
using System.Collections.Generic;
using OnlineWebShop.DAL;
using OnlineWebShop.MODEL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  class UserLogic
  {

    //public List<OnlineWebShop.MODEL.Vare> getAll()
    //{
    //  var ProductDAL = new ProductDAL();
    //  List<OnlineWebShop.MODEL.Vare> allProduct = ProductDAL.getAll();
    //  return allProduct;
    //}
    public bool insertNewProduct(OnlineWebShop.DAL.Vare vare)
    {
      var ProductDAL = new ProductDAL();
      return ProductDAL.insertNewProduct(vare);
    }
    public OnlineWebShop.DAL.Vare editProduct(int? id)
    {
      var ProductDAL = new ProductDAL();
      return ProductDAL.editProduct(id);
    }
    public bool deleteProduct(int slettId)
    {
      var ProductDAL = new ProductDAL();
      return ProductDAL.deleteProduct(slettId);
    }
  }
}
