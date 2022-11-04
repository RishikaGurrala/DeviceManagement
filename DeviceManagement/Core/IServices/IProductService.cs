
using DeviceManagement.DTO;
using DeviceManagement.Models;

namespace DeviceManagement.Core.IServices
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductById(int productId);
        string PostProduct(Product product);
        string DeleteProduct(Product product);
        string UpdateProduct(Product product);
        
    }
}
