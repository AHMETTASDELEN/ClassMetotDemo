using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("MÜŞTERİ LİSTESİ");
            Console.WriteLine("               ");

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Muhammed";
            musteri1.SoyAdi = "Özdemir";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Ahmet";
            musteri2.SoyAdi = "Taşdelen";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Berat";
            musteri3.SoyAdi = "Kılıç";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.SoyAdi);
                Console.WriteLine("              ");
            }


            Console.WriteLine("MÜŞTERİ İŞLEMLERİ");
            Console.WriteLine("                 ");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Güncelle(musteri3);

            Console.WriteLine("            ");

            musteriManager.Listele(musteriler);


        }
    }
}
