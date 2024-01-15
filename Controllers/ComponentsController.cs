using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using synto.Models;

namespace synto.Controllers;

public class ComponentsController : Controller
{
    private readonly ILogger<ComponentsController> _logger;

    public ComponentsController(ILogger<ComponentsController> logger)
    {
        _logger = logger;
    }

    [Route("/accordion")]
    public IActionResult accordion()
    {
        return View("accordion");
    }

    [Route("/alerts")]
    public IActionResult alerts()
    {
        return View("alerts");
    }

    [Route("/avatars")]
    public IActionResult avatars()
    {
        return View("avatars");
    }

    [Route("/badges")]
    public IActionResult badges()
    {
        return View("badges");
    }

    [Route("/blockquotes")]
    public IActionResult blockquotes()
    {
        return View("blockquotes");
    }
    [Route("/buttons")]
    public IActionResult buttons()
    {
        return View("buttons");
    }
    [Route("/cards")]
    public IActionResult cards()
    {
        return View("cards");
    }
    [Route("/collapse")]
    public IActionResult collapse()
    {
        return View("collapse");
    }
    [Route("/indicators")]
    public IActionResult indicators()
    {
        return View("indicators");
    }
    [Route("/listgroup")]
    public IActionResult listgroup()
    {
        return View("listgroup");
    }
    [Route("/list")]
    public IActionResult list()
    {
        return View("list");
    }
    [Route("/progress")]
    public IActionResult progress()
    {
        return View("progress");
    }

    [Route("/skeleton")]
    public IActionResult skeleton()
    {
        return View("skeleton");
    }
    [Route("/spinners")]
    public IActionResult spinners()
    {
        return View("spinners");
    }
    [Route("/toast")]
    public IActionResult toast()
    {
        return View("toast");
    }

}
