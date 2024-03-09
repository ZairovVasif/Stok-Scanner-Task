using System;
using System.Collections.Generic;

namespace StokYonetimprogrami
{
    class Program
    {
        static List<Mehsul> mehsullar = new List<Mehsul>();

        static void Main(string[] args)
        {
            bool devamEdilsin = true;
            while (devamEdilsin)
            {
                Console.WriteLine("1. Məhsul Əlavə Et");
                Console.WriteLine("2. Məhsulları Siyahılaşdır");
                Console.WriteLine("3. Məhsulu Yenilə");
                Console.WriteLine("4. Məhsulu Sil");
                Console.WriteLine("5. Çıxış");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        MehsulElaveEt();
                        break;
                    case 2:
                        MehsullariSiyahilasdir();
                        break;
                    case 3:
                        MehsulYenile();
                        break;
                    case 4:
                        MehsulSil();
                        break;
                    case 5:
                        devamEdilsin = false;
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim! Zəhmət olmasa yenidən cəhd edin.");
                        break;
                }
            }
        }

        static void MehsulElaveEt()
        {
            Console.WriteLine("Məhsulun adını daxil edin:");
            string ad = Console.ReadLine();
            Console.WriteLine("Məhsulun qiymətini daxil edin:");
            double qiymet = Convert.ToDouble(Console.ReadLine());

            Mehsul mehsul = new Mehsul(ad, qiymet);
            mehsullar.Add(mehsul);

            Console.WriteLine("Məhsul uğurla əlavə olundu.");
        }

        static void MehsullariSiyahilasdir()
        {
            foreach (var mehsul in mehsullar)
            {
                Console.WriteLine($"Məhsulun adı: {mehsul.Ad}, Qiyməti: {mehsul.Qiymet}");
            }
        }

        static void MehsulYenile()
        {
            Console.WriteLine("Yenilənəcək məhsulun adını daxil edin:");
            string ad = Console.ReadLine();

            Mehsul yenilenecekMehsul = mehsullar.Find(u => u.Ad == ad);
            if (yenilenecekMehsul != null)
            {
                Console.WriteLine("Yeni qiyməti daxil edin:");
                double yeniQiymet = Convert.ToDouble(Console.ReadLine());

                yenilenecekMehsul.Qiymet = yeniQiymet;
                Console.WriteLine("Məhsul uğurla yeniləndi.");
            }
            else
            {
                Console.WriteLine("Məhsul tapılmadı!");
            }
        }

        static void MehsulSil()
        {
            Console.WriteLine("Silinecək məhsulun adını daxil edin:");
            string ad = Console.ReadLine();

            Mehsul silinecekMehsul = mehsullar.Find(u => u.Ad == ad);
            if (silinecekMehsul != null)
            {
                mehsullar.Remove(silinecekMehsul);
                Console.WriteLine("Məhsul uğurla silindi.");
            }
            else
            {
                Console.WriteLine("Məhsul tapılmadı!");
            }
        }
    }

    class Mehsul
    {
        public string Ad { get; set; }
        public double Qiymet { get; set; }

        public Mehsul(string ad, double qiymet)
        {
            Ad = ad;
            Qiymet = qiymet;
        }
    }
}
