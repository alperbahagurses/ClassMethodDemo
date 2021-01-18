using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Yeni Musteri Eklendi : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void MusteriBakiye(Musteri musteri)
        {
            Console.WriteLine("Musteri bakiye : " + musteri.Bakiye);
        }
    }
}
