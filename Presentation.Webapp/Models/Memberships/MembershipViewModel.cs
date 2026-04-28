using Domain.Aggregates.Memberships;

namespace Presentation.Webapp.Models.Memberships;

public class MembershipViewModel
{
    public IEnumerable<Membership> Memberships { get; set; } = [];

}
