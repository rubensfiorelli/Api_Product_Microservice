using ShopWhiskey.Core.Prime;

namespace ShopWhiskey.Core.Entities.ProductContext
{
    public sealed class Product : BaseEntity
    {
        public Product(string origin,
                       string title,
                       string bio,
                       string img,
                       string thumb,
                       decimal price,
                       Guid categoryId) : base()
        {
            Origin = origin;
            Title = title;
            Bio = bio;
            Img = img;
            Thumb = thumb;
            Price = price;
            IsDeleted = false;
            CategoryId = categoryId;
        }

        public string Origin { get; private set; }
        public string Title { get; private set; }
        public string Bio { get; private set; }
        public string Img { get; private set; }
        public string Thumb { get; private set; }
        public decimal Price { get; private set; }
        public bool IsDeleted { get; private set; }
        public Guid CategoryId { get; private set; }
        public Category? Category { get; set; }


        public void Delete()
        {
            IsDeleted = true;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public void SetProduct(string newOrigin, string newTitle, string newBio, string newImg, string newThumb, decimal newPrice)
        {
            Origin = newOrigin;
            Title = newTitle;
            Bio = newBio;
            Img = newImg;
            Thumb = newThumb;
            Price = newPrice;

        }

    }
}
