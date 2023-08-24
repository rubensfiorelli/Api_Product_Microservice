using ShopWhiskey.Core.Entities.ProductContext;

namespace ShopWhiskey.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetAllAsync();
    }
}
