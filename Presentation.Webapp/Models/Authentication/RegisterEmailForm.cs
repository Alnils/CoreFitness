using System.ComponentModel.DataAnnotations;

namespace Presentation.Webapp.Models.Authentication;

public class RegisterEmailForm
{
    [Required(ErrorMessage = "Email address is required.")]
    [EmailAddress(ErrorMessage = "Invalid email adress.")]
    [Display(Name = "Email Address", Prompt = "Enter Email address")]
    public string Email { get; set; } = null!;
}
