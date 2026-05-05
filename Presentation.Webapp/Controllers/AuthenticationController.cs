using Application.Abstractions.Identity;
using Application.Members.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Webapp.Controllers;

public class AuthenticationController
(
    IRegisterMemberService registerMemberService,
    ISignInMemberService signInMemberService,
    IIdentityService identityService

) : Controller

{
    public const string RegistrationEmailSessionKey = "RegistrationEmail";

    public IActionResult SignIn()
    {
        return View();
    }

    public IActionResult RegisterEmail()
    {
        return View();
    }

    public IActionResult RegisterPassword()
    {
        return View();
    }

    public IActionResult RegisterProfile()
    {
        return View();
    }
}
