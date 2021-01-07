using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBulmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool oyunaBasla = true;

            while (oyunaBasla)
            {
                Random rastgeleSayi = new Random();
                int uretilenSayi = rastgeleSayi.Next(1, 100);
                bool sayiBulunduMu = false;

                while (!sayiBulunduMu)
                {
                    Console.WriteLine("Bir sayı tahmin edin: (1-100 arasında)");
                    int tahmin = Convert.ToInt32(Console.ReadLine());

                    if (uretilenSayi > tahmin)
                    {
                        Console.WriteLine("Yukarı!");
                    }
                    else if (uretilenSayi < tahmin)
                    {
                        Console.WriteLine("Aşağı!");
                    }
                    else
                    {
                        Console.WriteLine("Eşittir!");
                        sayiBulunduMu = true;
                    }
                }

                Console.WriteLine("Bir kez daha oynamak ister misiniz?(evet,hayır)");
                string cevap = Console.ReadLine();

                if (cevap == "evet")
                {
                    oyunaBasla = true;
                    Console.WriteLine("***Yeni Oyun***");
                }
                else if (cevap == "hayır")
                {
                    oyunaBasla = false;
                    Console.WriteLine("Çıkış yapılıyor..");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Geçersiz bir değer girdiniz.. çıkış yapılıyor..");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);
                }
            }
            Console.ReadLine();
        }
    }
}
