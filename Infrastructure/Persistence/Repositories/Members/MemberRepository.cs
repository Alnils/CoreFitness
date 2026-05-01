using Domain.Abstractions.Repositories.Members;
using Domain.Aggregates.Members;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Entities.Members;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Members;

public class MemberRepository(DataContext context) : RepositoryBase<Member, string, MemberEntity, DataContext>(context), IMemberRepository
{

    protected override string GetId(Member model)
    {
        return model.Id;
    }

    public string GetUserId(Member model)
    {
        return model.UserId;
    }

    protected override void ApplyPropertyUpdates(MemberEntity entity, Member model)
    {
        entity.FirstName = model.FirstName;
        entity.LastName = model.LastName;
        entity.PhoneNumber = model.PhoneNumber;
        entity.ProfilePictureUrl = model.ProfileImageUrl;
        entity.ModifiedAt = model.ModifiedAt;
    }



    protected override Member ToDomainModel(MemberEntity entity)
    {
        var model = Member.Create(
            entity.Id,
            entity.UserId,
            entity.FirstName,
            entity.LastName,
            entity.PhoneNumber,
            entity.ProfilePictureUrl,
            entity.CreatedAt,
            entity.ModifiedAt
            );

        return model;

    }

    protected override MemberEntity ToEntity(Member model)
    {
        var entity = new MemberEntity
        {
            Id = model.Id,
            UserId = model.UserId,
            FirstName = model.FirstName,
            LastName = model.LastName,
            PhoneNumber = model.PhoneNumber,
            ProfilePictureUrl = model.ProfileImageUrl,
            CreatedAt = model.CreatedAt,
            ModifiedAt = model.ModifiedAt,
        };

        return entity;
    }

    public async Task<Member?> GetMemberByUserIdAsync(string userId, CancellationToken ct = default)
    {
        try
        {
            var entity = await Set.FirstOrDefaultAsync(x => x.UserId == userId, ct);
            return entity is null ? default : ToDomainModel(entity);
        }
        catch
        {
            throw;
        }
    }
}
