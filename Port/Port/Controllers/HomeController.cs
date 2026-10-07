using Microsoft.AspNetCore.Mvc;
using Port.Models;
using System.Diagnostics;

namespace Port.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Profile Profile1 = new Profile();
            
                Profile1.LastName = "Milabo";
                Profile1.FirstName = "Ernilyn";
                Profile1.Age = 19;
                Profile1.Email = "ernilynmilabo@gmail.com";
                Profile1.address = "Quezon City";
            

            return View(Profile1);
        }

        public IActionResult Ernilyn()
        {
            var Profile1 = new Profile
            {
                LastName = "Milabo",
                FirstName = "Ernilyn",
                Age = 19,
                Email = "ernilynmilabo@gmail.com",
                address = "Quezon City"
            };

            return View(Profile1);
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
    }
}
