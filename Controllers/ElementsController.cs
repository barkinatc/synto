using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using synto.Models;

namespace synto.Controllers;

public class ElementsController : Controller
{
    private readonly ILogger<ElementsController> _logger;

    public ElementsController(ILogger<ElementsController> logger)
    {
        _logger = logger;
    }

    [Route("/breadcrumb")]
    public IActionResult breadcrumb()
    {
        return View("breadcrumb");
    }

    [Route("/columns")]
    public IActionResult columns()
    {
        return View("columns");
    }

    [Route("/grid")]
    public IActionResult grid()
    {
        return View("grid");
    }

    [Route("/megamenu")]
    public IActionResult megamenu()
    {
        return View("megamenu");
    }

    [Route("/navbar")]
    public IActionResult navbar()
    {
        return View("navbar");
    }
    
    [Route("/pagination")]
    public IActionResult pagination()
    {
        return View("pagination");
    }

    [Route("/scrollspy")]
    public IActionResult scrollspy()
    {
        return View("scrollspy");
    }

    [Route("/tabs")]
    public IActionResult tabs()
    {
        return View("tabs");
    }
}
