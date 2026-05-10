using Application.Common.Results;

namespace Application.Members.Abstractions;

public interface IRemoveMemberService
{
    Task<Result> RemoveMemberAsync(string memberId, CancellationToken ct = default);
}
