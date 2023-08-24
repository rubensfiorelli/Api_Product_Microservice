using ShopWhiskey.Core.Prime;

namespace ShopWhiskey.Core.Entities.ProductContext
{
    public sealed class Category : BaseEntity
    {
        public Category(string title, string description) : base()
        {
            Title = title;
            Description = description;
            IsDeleted = false;
            Whiskeys = new List<Product>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsDeleted { get; private set; }
        public List<Product> Whiskeys { get; private set; }


        public void Delete()
        {
            IsDeleted = true;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public void SetCategory(string newTitle, string newDescription)
        {
            Title = newTitle;
            Description = newDescription;

        }




    }

}