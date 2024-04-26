using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
  
    public class HomeController : Controller
    {
        public static List<string> Todos = new();
        public IActionResult Index()
        {
            return View(Todos);
        }
        [HttpGet]
        public IActionResult Save(string work)
        { //KAYIT 
            Todos.Add(work);
            return RedirectToAction("Index");
        }
    }
}
