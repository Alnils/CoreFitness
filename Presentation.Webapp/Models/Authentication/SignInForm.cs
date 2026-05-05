using System.ComponentModel.DataAnnotations;

namespace Presentation.Webapp.Models.Authentication;

public class SignInForm
{
    [Required(ErrorMessage = "Email address is required.")]
    [Display(Name = "Email Address", Prompt = "Enter Email address")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter Password")]
    public string Password { get; set; } = null!;

    public bool RememberMe { get; set; }
}