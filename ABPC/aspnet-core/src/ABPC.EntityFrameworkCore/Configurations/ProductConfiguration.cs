using ABPC.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.Domain.Entities;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ABPC.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ConfigureByConvention();
        
        builder.Property(x => x.NameAr).HasMaxLength(ABPCConsts.GeneralTextMaxLength).IsRequired();
        builder.Property(x => x.NameEn).HasMaxLength(ABPCConsts.GeneralTextMaxLength).IsRequired();
        builder.Property(x => x.DescriptionAr).HasMaxLength(ABPCConsts.DescriptionTextMaxLengt).IsRequired();
        builder.Property(x => x.DescriptionEn).HasMaxLength(ABPCConsts.DescriptionTextMaxLengt).IsRequired();

        builder.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryId).IsRequired();
        
        builder.ToTable("Products");
    }
}