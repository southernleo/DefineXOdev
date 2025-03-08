using DefinexAttributeOrnek;
using System.ComponentModel.DataAnnotations;
using Xunit;


namespace MVC.Models
{
    public class Ogrencim
    {
        [Required(ErrorMessage = "Adı alanı zorunludur.")]
        public string Adi { get; set; }

        [ZorunluAlan]
        public string Soyadi { get; set; }

        [ZorunluAlan]
        public string Bolum { get; set; }

      
    }
}
