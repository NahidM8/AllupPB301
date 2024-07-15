using AllupPB301.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AllupPB301.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
