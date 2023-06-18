using System;
using System.Collections.Generic;

namespace FilmKutuphanesi
{
    class Film
    {
        public string Ad { get; set; }
        public string Yonetmen { get; set; }
        public int Yil { get; set; }

        public Film(string ad, string yonetmen, int yil)
        {
            Ad = ad;
            Yonetmen = yonetmen;
            Yil = yil;
        }

        public override string ToString()
        {
            return $"{Ad} ({Yil}), Yönetmen: {Yonetmen}";
        }
    }

    class Program
    {
        static List<Film> filmListesi = new List<Film>();

        static void Main(string[] args)
        {
            Console.WriteLine("Film Kütüphanesine Hoş Geldiniz!");

            bool devam = true;
            while (devam)
            {
                Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Film Ekle");
                Console.WriteLine("2. Filmleri Listele");
                Console.WriteLine("3. Çıkış");

                string secim = Console.ReadLine();
                Console.Clear();

                switch (secim)
                {
                    case "1":
                        FilmEkle();
                        break;
                    case "2":
                        FilmleriListele();
                        break;
                    case "3":
                        devam = false;
                        Console.WriteLine("Programdan çıkılıyor...");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek! Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        static void FilmEkle()
        {
            Console.Write("Film adını girin: ");
            string ad = Console.ReadLine();

            Console.Write("Yönetmen adını girin: ");
            string yonetmen = Console.ReadLine();

            Console.Write("Film yılını girin: ");
            int yil = Convert.ToInt32(Console.ReadLine());

            Film yeniFilm = new Film(ad, yonetmen, yil);
            filmListesi.Add(yeniFilm);

            Console.WriteLine("Film başarıyla eklendi.");
        }

        static void FilmleriListele()
        {
            Console.WriteLine("Film Listesi:");
            foreach (Film film in filmListesi)
            {
                Console.WriteLine(film.ToString());
            }
        }
    }
}
