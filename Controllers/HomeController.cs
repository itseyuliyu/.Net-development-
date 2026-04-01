using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
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
   public IActionResult CheckAge(int age)
{
    string result;

    if (age < 13)
    {
        result = "You are a Child";
    }
    else if (age < 18)
    {
        result = "You are a Teen";
    }
    else
    {
        result = "You are an Adult";
    }

    ViewData["Result"] = result;

    return View();
}

    
}

