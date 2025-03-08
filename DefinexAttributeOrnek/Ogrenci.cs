using System.ComponentModel.DataAnnotations;

namespace DefinexAttributeOrnek
{
    public class Ogrenci
        {
            [Required]
            public string Adi { get; set; }

            [ZorunluAlan]
            public string Soyadi { get; set; }

            [ZorunluAlan]
            public string Bolum { get; set; }
        }

}
