using Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class MembershipConfiguration : IEntityTypeConfiguration<MembershipEntity>
{
    public void Configure(EntityTypeBuilder<MembershipEntity> builder)
    {
        builder.ToTable("Memberships");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .IsRequired();
    }
}

internal class MembershipBenefitConfiguration : IEntityTypeConfiguration<MembershipBenefitEntity>
{
    public void Configure(EntityTypeBuilder<MembershipBenefitEntity> builder)
    {
        builder.ToTable("Memberships");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .IsRequired();
        builder.Property(x => x.MembershipId)
            .IsRequired();
    }
}
