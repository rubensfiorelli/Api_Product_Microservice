using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopWhiskey.Core.Entities.ProductContext;

namespace ShopWhiskey.Data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(c => c.Title)
                .HasMaxLength(60)
                .IsRequired();

            builder
               .Property(c => c.Bio)
               .HasMaxLength(60)
               .IsRequired();

            builder
               .Property(c => c.Img)
               .HasMaxLength(60)
               .IsRequired();

            builder
               .Property(c => c.Thumb)
               .HasMaxLength(60)
               .IsRequired();

            builder
               .Property(c => c.Price)
               .HasPrecision(10, 2)
               .IsRequired();

            builder
                .HasOne(c => c.Category)
                .WithMany(p => p.Whiskeys)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
