using DefinexAttributeOrnek;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;


namespace MVC.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View(new Ogrencim());
        }

        [HttpPost]
        public IActionResult Index(Ogrencim model)
        {


            if (!ModelState.IsValid)
            {
                ViewBag.Message = "Lütfen tüm alanları eksiksiz doldurun!";
                return View(model);
            }

            if (!ZorunlulukKontrolu.Dogrula(model))
            {
                ModelState.AddModelError("", "Zorunlu alanları doldurunuz.");
                return View(model);
            }


            ViewBag.Message = "Öğrenci  kaydedildi.";


            return View(model);
        }

      


    }
}
