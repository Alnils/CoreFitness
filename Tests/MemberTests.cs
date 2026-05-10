using Domain.Aggregates.Members;
using Xunit;

namespace Tests;

public class MemberTests
{
    [Fact]
    public void Create_WithValidUserId_CreatesSuccessfully()
    {

        var userId = "test-user-123";

        var member = Member.Create(userId);

        Assert.NotNull(member.Id);           // Member should have an ID
        Assert.Equal(userId, member.UserId);  // UserId should match what we passed
    }

    [Fact]
    public void Create_WithEmptyUserId_Throws()
    {
        // Member cant be created without user id.
        var exception = Assert.Throws<ArgumentException>(() => Member.Create(""));

        Assert.Equal("Applicaton User Id is required.", exception.Message);
    }

    [Fact]
    public void UpdateInformation_WithValidValues_UpdatesProperties()
    {
        // Member can be updated with valid information.
        var member = Member.Create("test-user");

        member.UpdateInformation("John", "Doe", "123456", null);

        Assert.Equal("John", member.FirstName);
        Assert.Equal("Doe", member.LastName);
        Assert.Equal("123456", member.PhoneNumber);
    }
}
