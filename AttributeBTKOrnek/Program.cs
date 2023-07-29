// See https://aka.ms/new-console-template for more information
using AttributeBTKOrnek;

Console.WriteLine("Hello, World!");


Ogrenci ogrenci = new Ogrenci();
ogrenci.Bolum = "İşletme";
ogrenci.Adi = "İbrahim";
ogrenci.Soyadi = "Gökyar";


if (!ZorunluKontrol.Dogrula(ogrenci))
{
    Console.WriteLine("Öğrenci bilgileri doğrulamadan geçemedi!");
}
else
{
    Console.WriteLine("form başarılı");
}
