using DeviceManagement.Core.IServices;
using DeviceManagement.DTO;
using DeviceManagement.Models;

namespace DeviceManagement.Core.Services
{
    public class ProductService:IProductService
    {
        private readonly MobileContext Model;
        private List<Product> Products=new List<Product>();
        public ProductService(MobileContext model)
        {
            Model = model;
        }
        public string PostProduct(Product product)
        {
            try
            {
                if (product != null)
                {
                    Model.Products.Add(product);
                    Model.SaveChanges();
                    return "Product Inserted succesfully";
                }
                else
                {
                    return "Product Insertion failed";
                }
            }
            catch (Exception ex)
            {
                return "Something went wrong";
            }
        }

         List<Product> IProductService.GetProducts()
        {
            
                var db = new MobileContext();
                return db.Products.ToList();
            
        }

        public Product GetProductById(int productId)
        {
            
                  return  Products.FirstOrDefault(x => x.ProductId == productId);
                   
                
            //throw new NotImplementedException();
        }

        public string DeleteProduct(Product product)
        {
            try
            {
                
                if (product != null)
                {
                    Model.Products.Remove(product);
                    Model.SaveChanges();
                    return "Product deleted sucessfully";
                    
                }
                else
                {
                    return "Product deletion failed";
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
