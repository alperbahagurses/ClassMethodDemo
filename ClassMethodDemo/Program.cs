using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TcNo = "10000000000";
            musteri1.Ad = "Alper Baha";
            musteri1.Soyad = "GÜRSES";
            musteri1.Bakiye = 7500.53;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TcNo = "10000000000";
            musteri2.Ad = "Cemal";
            musteri2.Soyad = "ARSÖZ";
            musteri2.Bakiye = 1698.47;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.TcNo = "10000000000";
            musteri3.Ad = "İbrahim";
            musteri3.Soyad = "BAYRAM";
            musteri3.Bakiye = 12359.08;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriBakiye(musteri1);
            musteriManager.MusteriSil(musteri1);

            Console.WriteLine("\n-------------Müsteriler--------------\n");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri Bilgileri : " + musteri.Ad + " " + musteri.Soyad);
                Console.WriteLine("Bakiye : " + musteri.Bakiye + "\n");
            }
        
    }
    }
}
