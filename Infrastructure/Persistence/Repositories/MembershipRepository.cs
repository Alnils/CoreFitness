using Domain.Abstractions.Repositories;
using Domain.Aggregates.Memberships;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public sealed class MembershipRepository(DataContext context)
    : RepositoryBase<Membership, string, MembershipEntity, DataContext>(context)
    , IMembershipRepository
    
{
    protected override void ApplyPropertyUpdates(MembershipEntity entity, Membership model)
    {
        entity.Title = model.Title;
        entity.Description = model.Description;
        entity.Price = model.Price;
        entity.MonthlyClasses = model.MonthlyClasses;
        // Sync benefits: clear old, add new
        entity.Benefits.Clear();
        foreach (var benefit in model.Benefits)
        {
            entity.Benefits.Add(new MembershipBenefitEntity
            {
                Id = Guid.NewGuid().ToString(),
                MembershipId = model.Id,
                Benefit = benefit
            });
        }
    }

    protected override string GetId(Membership model)
    {
        return model.Id;
    }

    protected override Membership ToDomainModel(MembershipEntity entity)
    {
        var benefits = new List<string>();

        foreach (var benefit in entity.Benefits)
        {
            benefits.Add(benefit.Benefit);
        }

        var model = Membership.Create(
            entity.Id,
            entity.Title,
            entity.Description,
            benefits,
            entity.Price,
            entity.MonthlyClasses
        );

        return model;
    }

    protected override MembershipEntity ToEntity(Membership model)
    {
        var entity = new MembershipEntity
        {
            Id = model.Id,
            Title = model.Title,
            Description = model.Description,
            Price = model.Price,
            MonthlyClasses = model.MonthlyClasses
        };

        foreach (var benefit in model.Benefits)
        {
            entity.Benefits.Add(new MembershipBenefitEntity
            {
                Id = Guid.NewGuid().ToString(),
                MembershipId = model.Id,
                Benefit = benefit
            });
        }

        return entity;
    }
}
