using System;
using DefinexAttributeOrnek;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Öğrenci bilgilerini giriniz:");

        Console.Write("Adı: ");
        string adi = Console.ReadLine();

        Console.Write("Soyadı: ");
        string soyadi = Console.ReadLine();

        Console.Write("Bölüm: ");
        string bolum = Console.ReadLine();

        // Ogrenci nesnesi oluşturuluyor
        Ogrenci ogrenci = new Ogrenci
        {
            Adi = adi,
            Soyadi = soyadi,
            Bolum = bolum
        };

        // Doğrulama işlemi
        if (!ZorunlulukKontrolu.Dogrula(ogrenci))
        {
            
            Console.WriteLine("\nÖğrenci bilgileri doğrulamadan geçemedi!");
        }
        else
        {
            Console.WriteLine("\nForm başarılı!");
        }

        Console.WriteLine("\nÇıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
