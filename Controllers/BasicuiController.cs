using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using synto.Models;

namespace synto.Controllers;

public class BasicuiController : Controller
{
    private readonly ILogger<BasicuiController> _logger;

    public BasicuiController(ILogger<BasicuiController> logger)
    {
        _logger = logger;
    }

    [Route("/datatables")]
    public IActionResult datatables()
    {
        return View("datatables");
    }

    [Route("/dropdown")]
    public IActionResult dropdown()
    {
        return View("dropdown");
    }

    [Route("/edittable")]
    public IActionResult edittable()
    {
        return View("edittable");
    }

    [Route("/modal")]
    public IActionResult modal()
    {
        return View("modal");
    }

    [Route("/offcanvas")]
    public IActionResult offcanvas()
    {
        return View("offcanvas");
    }
    [Route("/tables")]
    public IActionResult tables()
    {
        return View("tables");
    }
    [Route("/tooltippopovers")]
    public IActionResult tooltippopovers()
    {
        return View("tooltippopovers");
    }
}
