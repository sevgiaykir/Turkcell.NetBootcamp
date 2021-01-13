using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringMetotları
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****String.ToCharArray() Metodu*****");

            string örnek = "Sevgi";
            Console.WriteLine($"String: {örnek}");
            //String ifadenin 0. indexinden 3. indexine kadar olan karakterler char arrayine eklenir.
            char[] kelime = örnek.ToCharArray(0,3);
            //String ifadenin tüm karakterleri char arrayine eklenir.
            Console.WriteLine("Char Array: ");
            char[] kelimeler = örnek.ToCharArray();
            for (int i = 0; i < kelimeler.Length; i++)
            {
                Console.WriteLine(kelimeler[i]);
            }
            Console.WriteLine("\n");

            string cümle = "Turkcell Geleceği Yazacak Kadın Mühendisler";
            Console.WriteLine($"Cümle = {cümle}");
            Console.WriteLine("\n");
            //String ifadenin girilen değeri içerip içermediği kontrol edilir.
            Console.WriteLine("*****String.Contains() Metodu*****");
            string deger = "Kadın";
            if (cümle.Contains("Mühendis"))
            {
                Console.WriteLine($"'{cümle}' cümlesi {deger} kelimesini içerir.");
            }
            else
            {
                Console.WriteLine($"'{cümle}' cümlesi {deger} kelimesini içermez.");
            }

            Console.WriteLine("\n");
            //String ifadenin girilen değer ile başlayıp başlamadığı kontol edilir.
            Console.WriteLine("*****String.StartsWith() Metodu*****");
            string deger1 = "Turkcell";
            if (cümle.StartsWith(deger1))
            {
                Console.WriteLine($"'{cümle}' cümlesi {deger1} kelimesi ile başlar.");
            }
            else
            {
                Console.WriteLine($"'{cümle}' cümlesi {deger1} kelimesi ile başlamaz.");
            }

            Console.WriteLine("\n");
            //String ifadenin girilen değer ile sonlanıp sonlanmadığı kontol edilir.
            Console.WriteLine("*****String.EndsWith() Metodu*****");
            string deger2 = "Mühendisler";
            if (cümle.EndsWith(deger2))
            {
                Console.WriteLine($"'{cümle}' cümlesi {deger2} kelimesi ile biter.");
            }
            else
            {
                Console.WriteLine($"'{cümle}' cümlesi {deger2} kelimesi ile bitmez.");
            }

            Console.WriteLine("\n");
            //String ifadeyi verilen karakterin bulunduğu indexlerden parçalara böler ve string arraye ekler.
            Console.WriteLine("*****String.Split() Metodu*****");
            string sehir = "Manisa,Aydın,İzmir,Muğla,Afyonkarahisar,Uşak";
            string[] sehirler = sehir.Split(',');
            //Her bir parçayı yazdırıyoruz
            foreach (var isim in sehirler)
            {
                Console.WriteLine(isim);
            }

            Console.ReadLine();
        }
    }
}
