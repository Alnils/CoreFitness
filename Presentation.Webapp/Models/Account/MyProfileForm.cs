using System.ComponentModel.DataAnnotations;

namespace Presentation.Webapp.Models.Account;

public class MyProfileForm
{
    [Required(ErrorMessage ="First name is required.")]
    [Display(Name = "First name", Prompt = "Enter first name")]

    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "Last name is required.")]
    [Display(Name = "Last name", Prompt = "Enter last name")]

    public string LastName { get; set; } = null!;

    [Phone]
    [Display(Name = "Phone number", Prompt = "Enter phone number")]
    public string? PhoneNumber { get; set; }

    [Url]
    [Display(Name = "Profile Image", Prompt = "Upload profile image")]
    public string? ProfileImageUrl { get; set; }


}
