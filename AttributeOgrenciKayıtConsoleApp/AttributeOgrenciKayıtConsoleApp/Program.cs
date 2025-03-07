// See https://aka.ms/new-console-template for more information
using AttributeClassLibrary;
using AttributeOgrenciKayıtConsoleApp;

Ogrenci ogrenci = new Ogrenci
{
    Adi = "Sevval",
    Soyadi = "Ates",
    Bolum = "Yazılım"
};

if (!ZorunlulukKontrolu.Dogrula(ogrenci))
{
    Console.WriteLine("Öğrenci bilgileri doğrulamadan geçemedi!");
}
else
{
    Console.WriteLine("Form başarılı!");
}