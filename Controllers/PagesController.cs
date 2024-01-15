using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using synto.Models;

namespace synto.Controllers;

public class PagesController : Controller
{
    private readonly ILogger<PagesController> _logger;

    public PagesController(ILogger<PagesController> logger)
    {
        _logger = logger;
    }

    [Route("/about")]
    public IActionResult about()
    {
        return View("about");
    }

    [Route("/addproduct")]
    public IActionResult addproduct()
    {
        return View("addproduct");
    }

    [Route("/blog")]
    public IActionResult blog()
    {
        return View("blog");
    }

    [Route("/blogdetails")]
    public IActionResult blogdetails()
    {
        return View("blogdetails");
    }

    [Route("/blogedit")]
    public IActionResult blogedit()
    {
        return View("blogedit");
    }
    
    [Route("/cart")]
    public IActionResult cart()
    {
        return View("cart");
    }

    [Route("/chat")]
    public IActionResult chat()
    {
        return View("chat");
    }

    [Route("/checkout")]
    public IActionResult checkout()
    {
        return View("checkout");
    }

    [Route("/contacts")]
    public IActionResult contacts()
    {
        return View("contacts");
    }

    [Route("/contactus")]
    public IActionResult contactus()
    {
        return View("contactus");
    }

    [Route("/editproduct")]
    public IActionResult editproduct()
    {
        return View("editproduct");
    }

    [Route("/emptypage")]
    public IActionResult emptypage()
    {
        return View("emptypage");
    }

    [Route("/faqs")]
    public IActionResult faqs()
    {
        return View("faqs");
    }

    [Route("/invoice")]
    public IActionResult invoice()
    {
        return View("invoice");
    }

    [Route("/invoicelist")]
    public IActionResult invoicelist()
    {
        return View("invoicelist");
    }

    [Route("/landing")]
    public IActionResult landing()
    {
        return View("landing","_Layout1");
    }

    [Route("/mailinbox")]
    public IActionResult mailinbox()
    {
        return View("mailinbox");
    }

    [Route("/mailsettings")]
    public IActionResult mailsettings()
    {
        return View("mailsettings");
    }

    [Route("/orders")]
    public IActionResult orders()
    {
        return View("orders");
    }

    [Route("/orderdetails")]
    public IActionResult orderdetails()
    {
        return View("orderdetails");
    }

    [Route("/pricing")]
    public IActionResult pricing()
    {
        return View("pricing");
    }
        
    [Route("/productlist")]
    public IActionResult productlist()
    {
        return View("productlist");
    }

    [Route("/products")]
    public IActionResult products()
    {
        return View("products");
    }

    [Route("/productsdetails")]
    public IActionResult productsdetails()
    {
        return View("productsdetails");
    }

    [Route("/profile")]
    public IActionResult profile()
    {
        return View("profile");
    }

    [Route("/profilesettings")]
    public IActionResult profilesettings()
    {
        return View("profilesettings");
    }

    [Route("/reviews")]
    public IActionResult reviews()
    {
        return View("reviews");
    }
    
    [Route("/tasks")]
    public IActionResult tasks()
    {
        return View("tasks");
    }

    [Route("/team")]
    public IActionResult team()
    {
        return View("team");
    }

    [Route("/terms")]
    public IActionResult terms()
    {
        return View("terms");
    }
    
    [Route("/timeline")]
    public IActionResult timeline()
    {
        return View("timeline");
    }

    [Route("/todo")]
    public IActionResult todo()
    {
        return View("todo");
    }

    [Route("/wishlist")]
    public IActionResult wishlist()
    {
        return View("wishlist");
    }
}
