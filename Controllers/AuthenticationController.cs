using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.ENTITIES.Models;
using synto.Models;

namespace synto.Controllers;

public class AuthenticationController : Controller
{
    private readonly ILogger<AuthenticationController> _logger;
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;


   

    public AuthenticationController(ILogger<AuthenticationController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _logger = logger;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [Route("/comingsoon")]
    public IActionResult comingsoon()
    {
        return View("comingsoon","_Layout4");
    }

    [Route("/construction")]
    public IActionResult construction()
    {
        return View("construction","_Layout4");
    }

    [Route("/createpassword")]
    public IActionResult createpassword()
    {
        return View("createpassword","_Layout2");
    }

    [Route("/createpasswordcover")]
    public IActionResult createpasswordcover()
    {
        return View("createpasswordcover","_Layout4");
    }

    [Route("/createpasswordcover2")]
    public IActionResult createpasswordcover2()
    {
        return View("createpasswordcover2","_Layout4");
    }

    [Route("/error404")]
    public IActionResult error404()
    {
        return View("error404","_Layout2");
    }

    [Route("/error500")]
    public IActionResult error500()
    {
        return View("error500","_Layout2");
    }

    [Route("/forgot")]
    public IActionResult forgot()
    {
        return View("forgot","_Layout2");
    }

    [Route("/forgotcover")]
    public IActionResult forgotcover()
    {
        return View("forgotcover","_Layout3");
    }

    [Route("/forgotcover2")]
    public IActionResult forgotcover2()
    {
        return View("forgotcover2","_Layout4");
    }
    [Route("/lockscreen")]
    public IActionResult lockscreen()
    {
        return View("lockscreen","_Layout2");
    }
    [Route("/lockscreencover")]
    public IActionResult lockscreencover()
    {
        return View("lockscreencover","_Layout3");
    }

    [Route("/lockscreencover2")]
    public IActionResult lockscreencover2()
    {
        return View("lockscreencover2","_Layout4");
    }

    [Route("/maintanace")]
    public IActionResult maintanace()
    {
        return View("maintanace","_Layout4");
    }

    [Route("/reset")]
    public IActionResult reset()
    {
        return View("reset","_Layout2");
    }

    [Route("/resetcover")]
    public IActionResult resetcover()
    {
        return View("resetcover","_Layout3");
    }

    [Route("/resetcover2")]
    public IActionResult resetcover2()
    {
        return View("resetcover2","_Layout4");
    }
    [HttpGet]
    

    
    public IActionResult SignIn()
    {

        return View();
    }
    [HttpPost]
    

    public async Task<IActionResult> SignIn(UserRegisterVM p)
    {

       
            var result = await _signInManager.PasswordSignInAsync(p.Mail, p.Password, false, false);
            if (result.Succeeded)
            {
                return Redirect("/Admin/Mission/AssignTask");

            }
            else
            {

                return RedirectToAction("SignIn");

            }
        
       
    }

    [Route("/signincover")]
    public IActionResult signincover()
    {
        return View("signincover","_Layout3");
    }

    [Route("/signincover2")]
    public IActionResult signincover2()
    {
        return View("signincover2","_Layout4");
    }
    [Route("/signup")]
    [HttpGet]
    public IActionResult signup()
    {
        return View();
    }

    [Route("/signup")]

    [HttpPost]
    public async Task<IActionResult> signup(UserRegisterVM p)
    {

        AppUser appUser = new AppUser
        {
            Name = p.Name,
            Surname = p.Surname,
            Email = p.Mail,
            UserName = p.Mail
            
            
        };
        if (p.Password == p.ConfirmPassword)
        {
            var result = await _userManager.CreateAsync(appUser, p.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("signin");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
        }
            return View("signup","_Layout2");

    }

    [Route("/signupcover")]
    public IActionResult signupcover()
    {
        return View("signupcover","_Layout3");
    }

    [Route("/signupcover2")]
    public IActionResult signupcover2()
    {
        return View("signupcover2","_Layout4");
    }

    [Route("/verfication")]
    public IActionResult verfication()
    {
        return View("verfication","_Layout2");
    }

    [Route("/verficationcover")]
    public IActionResult verficationcover()
    {
        return View("verficationcover","_Layout3");
    }

    [Route("/verficationcover2")]
    public IActionResult verficationcover2()
    {
        return View("verficationcover2","_Layout4");
    }
}
