using System.ComponentModel.DataAnnotations;

namespace Presentation.Webapp.Models.Account;

public class MyAccountViewModel
{
    [Display(Name="Email Adress")]
    public string Email { get; set; } =string.Empty;

    public MyProfileForm AboutMeForm { get; set; } = null!;
}