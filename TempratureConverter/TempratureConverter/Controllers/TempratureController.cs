using Microsoft.AspNetCore.Mvc;
using TempratureConverter.Models;

namespace TempratureConverter.Controllers
{
    public class TempratureController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new TempratreUnits());
        }

        [HttpPost]
        public async Task<IActionResult> Convert(TempratreUnits model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            // Conversion logic
            if (model.unit1)
            {
                // Convert from Celsius to Fahrenheit
                model.unit2ValueF = (model.unit1ValueF * 9 / 5) + 32;
            }
            else
            {
                // Convert from Fahrenheit to Celsius
                model.unit2ValueF = (model.unit1ValueF - 32) * 5 / 9;
            }

            return View("Index", model);
        }
    }
}
