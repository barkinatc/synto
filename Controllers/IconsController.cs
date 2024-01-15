using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using synto.Models;

namespace synto.Controllers;

public class IconsController : Controller
{
    private readonly ILogger<IconsController> _logger;

    public IconsController(ILogger<IconsController> logger)
    {
        _logger = logger;
    }

    [Route("/remixicons")]
    public IActionResult remixicons()
    {
        return View("remixicons");
    }

    [Route("/tablericons")]
    public IActionResult tablericons()
    {
        return View("tablericons");
    }

}
