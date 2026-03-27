using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class EyuController : Controller
{
    // 
    // GET: /HelloWorld/
public String  Index()
{
  return "Hey eyu edet nesh ";
}
    // GET: /HelloWorld/Welcome/ 
    public string Eyu()
    {
        return "i will add another view for this one yeah maybe eyu";
    }
}