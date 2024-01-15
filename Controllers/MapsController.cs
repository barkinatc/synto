using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using synto.Models;

namespace synto.Controllers;

public class MapsController : Controller
{
    private readonly ILogger<MapsController> _logger;

    public MapsController(ILogger<MapsController> logger)
    {
        _logger = logger;
    }

    [Route("/googlemaps")]
    public IActionResult googlemaps()
    {
        return View("googlemaps");
    }

    [Route("/leafletmaps")]
    public IActionResult leafletmaps()
    {
        return View("leafletmaps");
    }

    [Route("/vectormaps")]
    public IActionResult vectormaps()
    {
        return View("vectormaps");
    }

}
