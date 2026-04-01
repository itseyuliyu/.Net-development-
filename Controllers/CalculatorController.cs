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

 public IActionResult Multiply (int a ,int b)
    {


        int result ;
result =a*b;
 ViewData["Multiply"]=result;
        
        return View();
    }

 public IActionResult Division (int a ,int b)
    {


        int result ;
result =a/b;
 ViewData["Division"]=result;
        
        return View();
    }

}