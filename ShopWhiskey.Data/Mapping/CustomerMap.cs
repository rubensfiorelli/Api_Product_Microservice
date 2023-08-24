using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopWhiskey.Core.Entities;

namespace ShopWhiskey.Data.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(f => f.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder
               .Property(f => f.LastName)
               .HasMaxLength(80)
               .IsRequired();

            builder
               .Property(f => f.Email)
               .HasMaxLength(200)
               .IsRequired();

            builder
                .OwnsOne(a => a.Address);

            builder
                .HasIndex(x => x.Email)
                .IsUnique();

            builder
                 .HasIndex(p => new { p.FirstName, p.LastName });

        }
    }
}
