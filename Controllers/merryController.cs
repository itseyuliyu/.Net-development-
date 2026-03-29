using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelController : Controller
{
    // 
    // GET: /HelloWorld/
public IActionResult Index()
{
    return View();
}
    // GET: /HelloWorld/Welcome/ 
    public string Merry()
    {
        return "i will add another or merry";
    }
}