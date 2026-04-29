using Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class MembershipBenefitConfiguration : IEntityTypeConfiguration<MembershipBenefitEntity>
{
    public void Configure(EntityTypeBuilder<MembershipBenefitEntity> builder)
    {
        builder.ToTable("MembershipBenefits");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .IsRequired();
        builder.Property(x => x.MembershipId)
            .IsRequired();
    }
}
