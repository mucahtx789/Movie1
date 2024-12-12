using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Movie1.Entities;
using Movie1.Models;

namespace Movie1.Controllers
{
    public class HomeController : Controller
    {

        DatabaseContext db;

        public HomeController(DatabaseContext db2)
        {
            db = db2;
        }

        public IActionResult Index()
        {
            var  model = db.Contents.ToList();
            return View(model);
        }

        
        
    }
}
