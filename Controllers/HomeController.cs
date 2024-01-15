using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using synto.Models;

namespace synto.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    [Route("/")]

    [Route("/index")]
    public IActionResult index()
    {
        return View("index");
    }

    [Route("/index2")]
    public IActionResult index2()
    {
        return View("index2");
    }

    [Route("/index3")]
    public IActionResult index3()
    {
        return View("index3");
    }

    [Route("/index4")]
    public IActionResult index4()
    {
        return View("index4");
    }

    [Route("/index5")]
    public IActionResult index5()
    {
        return View("index5");
    }

    [Route("/index6")]
    public IActionResult index6()
    {
        return View("index6");
    }

    [Route("/index7")]
    public IActionResult index7()
    {
        return View("index7");
    }

    [Route("/index8")]
    public IActionResult index8()
    {
        return View("index8");
    }

    [Route("/index9")]
    public IActionResult index9()
    {
        return View("index9");
    }

    [Route("/index10")]
    public IActionResult index10()
    {
        return View("index10");
    }

    [Route("/index11")]
    public IActionResult index11()
    {
        return View("index11");
    }

    [Route("/index12")]
    public IActionResult index12()
    {
        return View("index12");
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
