
using Infrastructure.Identity;
using Infrastructure.Persistence.Entities.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Members;

internal class MemberEntityConfiguration : IEntityTypeConfiguration<MemberEntity>
{
    public void Configure(EntityTypeBuilder<MemberEntity> builder)
    {
        builder.ToTable("Members");
        builder.HasIndex(x => x.Id);
        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.UserId).IsRequired();
        builder.Property(x => x.FirstName).HasMaxLength(100);
        builder.Property(x => x.LastName).HasMaxLength(100);
        builder.Property(x => x.PhoneNumber).HasMaxLength(20);
        builder.Property(x => x.ProfilePictureUrl).HasMaxLength(200);
        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.ModifiedAt);

        builder.HasIndex(x => x.UserId).IsUnique();

        builder
            .HasOne<ApplicationUser>()
            .WithOne(x => x.Member)
            .HasForeignKey<MemberEntity>(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
