using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using synto.Models;

namespace synto.Controllers;

public class ChartsController : Controller
{
    private readonly ILogger<ChartsController> _logger;

    public ChartsController(ILogger<ChartsController> logger)
    {
        _logger = logger;
    }

    [Route("/apexcharts")]
    public IActionResult apexcharts()
    {
        return View("apexcharts");
    }

    [Route("/chartjs")]
    public IActionResult chartjs()
    {
        return View("chartjs");
    }

    [Route("/echartjs")]
    public IActionResult echartjs()
    {
        return View("echartjs");
    }

}
