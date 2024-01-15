using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using synto.Models;

namespace synto.Controllers;

public class AdvanceduiController : Controller
{
    private readonly ILogger<AdvanceduiController> _logger;

    public AdvanceduiController(ILogger<AdvanceduiController> logger)
    {
        _logger = logger;
    }

    [Route("/calendar")]
    public IActionResult calendar()
    {
        return View("calendar");
    }

    [Route("/carousel")]
    public IActionResult carousel()
    {
        return View("carousel");
    }

    [Route("/draggable")]
    public IActionResult draggable()
    {
        return View("draggable");
    }

    [Route("/filedetails")]
    public IActionResult filedetails()
    {
        return View("filedetails");
    }

    [Route("/filemanager")]
    public IActionResult filemanager()
    {
        return View("filemanager");
    }

    [Route("/filemanagerlist")]
    public IActionResult filemanagerlist()
    {
        return View("filemanagerlist");
    }

    [Route("/gallery")]
    public IActionResult gallery()
    {
        return View("gallery");
    }

    [Route("/notifications")]
    public IActionResult notifications()
    {
        return View("notifications");
    }
    [Route("/rangeslider")]
    public IActionResult rangeslider()
    {
        return View("rangeslider");
    }
    [Route("/ratings")]
    public IActionResult ratings()
    {
        return View("ratings");
    }
    [Route("/sweetalert")]
    public IActionResult sweetalert()
    {
        return View("sweetalert");
    }
    [Route("/treeview")]
    public IActionResult treeview()
    {
        return View("treeview");
    }
}
