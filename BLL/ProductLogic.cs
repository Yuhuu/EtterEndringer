
using OnlineWebShop.DAL;
using System.Collections.Generic;
using OnlineWebShop.MODEL;


namespace BLL
{
  public class ProductLogic
  {
    public List<OnlineWebShop.MODEL.Vare> getAll()
    {
      var ProductDAL = new ProductDAL();
      List<OnlineWebShop.MODEL.Vare> allProduct = ProductDAL.getAll();
      return allProduct;
    }
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
