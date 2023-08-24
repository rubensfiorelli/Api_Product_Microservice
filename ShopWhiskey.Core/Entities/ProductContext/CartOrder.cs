using ShopWhiskey.Core.Prime;
using ShopWhiskey.Core.ValueObject;

namespace ShopWhiskey.Core.Entities.ProductContext
{
    public sealed class CartOrder : BaseEntity
    {
        public CartOrder(string description,
                          int quantity,
                          DeliveryAddress deliveryAddress,
                          decimal totalPrice) : base()
        {
            Description = description;
            Quantity = quantity;
            PostedAt = DateTime.Today;
            DeliveryAddress = deliveryAddress;
            TotalPrice = totalPrice;

            Items = new List<CartItem>();
        }

        public string Description { get; private set; }
        public int Quantity { get; private set; }
        public DateTime PostedAt { get; private set; }
        public DeliveryAddress DeliveryAddress { get; private set; }
        public decimal TotalPrice { get; private set; }
        public List<CartItem> Items { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public void SetupActions(List<Product> products)
        {
            foreach (var item in products)
            {
                var productPrice = item.Price * Quantity;

                TotalPrice = productPrice;
                Items.Add(new CartItem(item.Title, Quantity, item.Price, item.Id, productPrice));
            }

        }

    }
}
