using OnlineWebShop.MODEL;
using OnlineWebShop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
  public class ProductLogic
  {
    public List<Vare> getAll()
    {
      var ProductDAL = new ProductDAL();
      List<Vare> allProduct = ProductDAL.getAll();
      return allProduct;
    }
    public bool insertNewProduct(Vare vare)
    {
      var ProductDAL = new ProductDAL();
      return ProductDAL.insertNewProduct(vare);
    }
    public bool editProduct(int id, Vare innVare)
    {
      var ProductDAL = new ProductDAL();
      return ProductDAL.editProduct(id, innVare);
    }
    public bool deleteProduct(int slettId)
    {
      var ProductDAL = new ProductDAL();
      return ProductDAL.deleteProduct(slettId);
    }
  }
  
}
