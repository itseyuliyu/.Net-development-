using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class CalculatorController : Controller
{
    
    public IActionResult Adding (int a ,int b)
    {


        int result ;
result =a+b;
 ViewData["Adding"]=result;
        
        return View();
    }
}