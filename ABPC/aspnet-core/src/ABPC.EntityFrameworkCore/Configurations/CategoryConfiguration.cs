using System.Linq;
using ABPC.Categories;
using ABPC.EntityFrameworkCore;
using ABPC.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.Users;

namespace ABPC.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ConfigureByConvention();

        builder.Property(x => x.Id).ValueGeneratedNever();
        
        builder.Property(x => x.NameAr).HasMaxLength(ABPCConsts.GeneralTextMaxLength).IsRequired();
        builder.Property(x => x.NameEn).HasMaxLength(ABPCConsts.GeneralTextMaxLength).IsRequired();
        builder.Property(x => x.DescriptionAr).HasMaxLength(ABPCConsts.DescriptionTextMaxLengt).IsRequired();
        builder.Property(x => x.DescriptionEn).HasMaxLength(ABPCConsts.DescriptionTextMaxLengt).IsRequired();
        
        builder.ToTable("Categories");

    }
}