using Microsoft.AspNetCore.Mvc;

namespace Kolozsvari_Balint_Istvan_Lab1.Controllers
{
    public class ViewbController : Controller
    {
        public IActionResult Exer2()
        {
            ViewBag.Message = "Mesaj din Controller";
            ViewData["Time"] = DateTime.Now;

            return View();
        }
    }
}
