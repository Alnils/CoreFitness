using Application.Abstractions.Identity;
using Application.Common.Results;
using Application.Members.Abstractions;

namespace Application.Members.Services;

public class RemoveMemberService(IIdentityService identityService) : IRemoveMemberService
{
    public async Task<Result> RemoveMemberAsync(string userId, CancellationToken ct = default)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(userId))
                return Result.BadRequest("User ID must be provided.");

            var deleteResult = await identityService.DeleteUserAsync(userId, ct);
            if (!deleteResult.Success)
                return Result.Error(deleteResult.ErrorMessage ?? "Failed to remove account.");

            return Result.Ok();
        }
        catch (Exception ex)
        {
            return Result.Error(ex.Message);
        }
    }
}
