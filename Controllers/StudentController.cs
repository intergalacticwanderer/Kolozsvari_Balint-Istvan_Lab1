using Microsoft.AspNetCore.Mvc;

namespace Kolozsvari_Balint_Istvan_Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult info()
        {
            var student = new Student { Name = "Ana", Age = 21 };
            return View(student);
        }
    }
}
