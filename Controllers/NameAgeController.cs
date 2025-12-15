using Microsoft.AspNetCore.Mvc;

namespace Kolozsvari_Balint_Istvan_Lab1.Controllers
{
    public class NameAgeController : Controller
    {
        public IActionResult Greet(string name, int age)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Guest";
            }


            string greeting = $"Hello {name}, you are {age} old!";


            return Content(greeting);
        }
    }
}