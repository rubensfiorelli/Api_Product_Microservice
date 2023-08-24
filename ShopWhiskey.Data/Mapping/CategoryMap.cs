using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopWhiskey.Core.Entities.ProductContext;

namespace ShopWhiskey.Data.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(d => d.Title)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(d => d.Description)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasMany(w => w.Whiskeys);

        }
    }
}
