using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using synto.Models;

namespace synto.Controllers;

public class FormsController : Controller
{
    private readonly ILogger<FormsController> _logger;

    public FormsController(ILogger<FormsController> logger)
    {
        _logger = logger;
    }

    [Route("/advancedforms")]
    public IActionResult advancedforms()
    {
        return View("advancedforms");
    }

    [Route("/fileupload")]
    public IActionResult fileupload()
    {
        return View("fileupload");
    }

    [Route("/formcheckbox")]
    public IActionResult formcheckbox()
    {
        return View("formcheckbox");
    }

    [Route("/formelements")]
    public IActionResult formelements()
    {
        return View("formelements");
    }

    [Route("/forminputgroup")]
    public IActionResult forminputgroup()
    {
        return View("forminputgroup");
    }
    
    [Route("/formlayouts")]
    public IActionResult formlayouts()
    {
        return View("formlayouts");
    }

    [Route("/formradio")]
    public IActionResult formradio()
    {
        return View("formradio");
    }

    [Route("/formselect")]
    public IActionResult formselect()
    {
        return View("formselect");
    }
    
    [Route("/formswitch")]
    public IActionResult formswitch()
    {
        return View("formswitch");
    }

    [Route("/formvalidations")]
    public IActionResult formvalidations()
    {
        return View("formvalidations");
    }

    [Route("/quileditor")]
    public IActionResult quileditor()
    {
        return View("quileditor");
    }
}
