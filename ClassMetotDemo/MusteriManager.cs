using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Adi + " " + musteri.SoyAdi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Adi + " " + musteri.SoyAdi);
        }

        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri güncellendi : " + musteri.Adi + " " + musteri.SoyAdi);
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("MÜŞTERİ LİSTESİ DİĞER YÖNTEM");
            Console.WriteLine("                 ");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.SoyAdi);
                Console.WriteLine("            ");
            }
            Console.WriteLine("MÜŞTERİLER LİSTELENDİ");
        }
    }
}
