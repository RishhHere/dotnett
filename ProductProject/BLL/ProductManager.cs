namespace BLL;
using BOL;
using DBManager.Connected;

public class ProductManager{
    public List<Product> GetAllProducts(){
        List<Product> products = new List<Product>();
        products = DBManager.GetAllProducts();
        return products;
    }

     public List<Product>  GetProductsById(int pid){
        List<Product> products = new List<Product>();
        products = DBManager. GetProductsById(pid);
        return products;
    }


}