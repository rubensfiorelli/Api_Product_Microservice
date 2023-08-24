using ShopWhiskey.Core.Prime;

namespace ShopWhiskey.Core.Entities.ProductContext
{
    public sealed class CartItem : BaseEntity
    {
        public CartItem(string title, int quantity, decimal price, Guid productId, decimal totalPrice) : base()
        {
            Title = title;
            Quantity = quantity;
            Price = price;
            ProductId = productId;
            TotalPrice = totalPrice;
        }

        public string Title { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public Guid ProductId { get; private set; }
        public decimal TotalPrice { get; private set; }
        public Product? Product { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
