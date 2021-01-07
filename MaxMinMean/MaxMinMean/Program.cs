using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinMean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı listesinin boyutunu giriniz: (pozitif değer olmalı) ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            List<int> sayilar = new List<int>();
            int max, min;
            double mean = 0;
            int toplam = 0;

            Console.WriteLine($"{boyut} adet sayı giriniz: ");
            for (int i = 0; i < boyut; i++)
            {
                try
                {
                    sayilar.Add(Convert.ToInt32(Console.ReadLine()));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen sayısal bir değer giriniz!");
                }
                catch (Exception hata)
                {
                    Console.WriteLine("Bir hata oluştu!" + hata.Message);
                }
            }

            //Max ve min değerlere listenin ilk elemanını atadık
            max = sayilar[0];
            min = sayilar[0];

            //döngü sayısını listenin boyutu kadar ayarlıyoruz
            for (int i = 0; i < boyut; i++)
            {
                //listedeki tüm sayıları max değer ile karşılaştırıp, max değerden büyük olan sayıyı yeni max değer olarak atıyoruz ve en büyük değeri buluyoruz
                if (max < sayilar[i])
                {
                    max = sayilar[i];
                }
                //listedeki tüm sayıları min değer ile karşılaştırıp, min değerden küçük olan sayıyı yeni min değer olarak atıyoruz ve en küçük değeri buluyoruz
                if (min > sayilar[i])
                {
                    min = sayilar[i];
                }
                //tüm sayıları topluyoruz
                toplam += sayilar[i];
            }
            //toplamı listenin boyutuna bölüp ortalamayı buluyoruz
            mean = Convert.ToDouble(toplam) / boyut;
            //virgülden sonraki 2 rakamı alıyoruz
            mean = Math.Round(mean, 2);

            //sonuçları yazdırıyoruz
            Console.WriteLine($"Maximum Değer: {max}");
            Console.WriteLine($"Minimum Değer: {min}");
            Console.WriteLine($"Ortalama Değer: {mean}");

            Console.ReadLine();
        }
    }
}
