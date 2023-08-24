using ShopWhiskey.Core.Entities.ProductContext;

namespace ShopWhiskey.Core.Interfaces
{
    public interface ICartOrderRepository
    {
        Task<CartOrder> GetAsync(Guid id);
        Task<List<CartOrder>> GetCartOrder();
        Task<CartOrder> AddAsync(CartOrder cartOrder);

    }
}
