using System.ComponentModel.DataAnnotations;

namespace Presentation.Webapp.Models.CustomerService;

public class CustomerServiceForm
{
    [Required(ErrorMessage = "First name is required.")]
    [Display(Name = "First name", Prompt = "Enter first name")]

    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "Last name is required.")]
    [Display(Name = "Last name", Prompt = "Enter last name")]

    public string LastName { get; set; } = null!;

    [Required(ErrorMessage = "Email is required.")]
    [Display(Name = "Email", Prompt = "Enter Email Address")]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Phone]
    [Display(Name = "Phone number", Prompt = "Enter phone number")]
    public string? PhoneNumber { get; set; }

    [Required(ErrorMessage = "Message is required.")]
    [Display(Name = "Message", Prompt = "Message...")]
    public string Message { get; set; } = null!;
}
