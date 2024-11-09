using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ABPC.Configurations;

public class TestConfiguration :IEntityTypeConfiguration<Test.Test>
{
    public void Configure(EntityTypeBuilder<Test.Test> builder)
    {
        builder.ConfigureByConvention();
        
        builder.Property(x => x.Name).HasMaxLength(ABPCConsts.GeneralTextMaxLength).IsRequired();
        builder.Property(x => x.state).IsRequired();
        
        builder.ToTable("Test");
    }
}