using Microsoft.AspNetCore.Mvc;

namespace Kolozsvari_Balint_Istvan_Lab1.Controllers
{
    public class Metoda1Controller : Controller
    {
        public IActionResult Index2()
        {
            return Content("Hello World");
        }
    }
}
