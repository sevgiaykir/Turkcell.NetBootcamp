using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charMetotları
{
    class Program
    {
        static void Main(string[] args)
        {
            string örnek = "2+2 işlemi 4 sonucunu verir.";
            Console.WriteLine($"Cümle: {örnek}");
            // Bir stringteki var olan rakamları ve indexlerini bulma
            Console.WriteLine("\n*****char.IsDigit() Metodu*****");
            //verilen char değerinin rakam olup olmadığını kontrol eder.           
            for (int i = 0; i < örnek.Length; i++)
            {
                if(char.IsDigit(örnek,i))
                Console.WriteLine($"{i}. indexte {örnek[i]} rakamı vardır.");
            }

            // Bir stringteki var olan harfleri ve indexlerini bulma
            Console.WriteLine("\n*****char.IsLetter() Metodu*****");
            //verilen char değerinin harf olup olmadığını kontrol eder.        
            for (int i = 0; i < örnek.Length; i++)
            {
                if (char.IsLetter(örnek, i))
                    Console.WriteLine($"{i}. indexte {örnek[i]} harfi ardır.");
            }

            // Bir stringteki var olan boşluk karakterlerini bulma
            Console.WriteLine("\n*****char.IsWhiteSpace() Metodu*****");
            //verilen char değerinin boşluk karakteri olup olmadığını kontrol eder.        
            for (int i = 0; i < örnek.Length; i++)
            {
                if (char.IsWhiteSpace(örnek, i))
                    Console.WriteLine($"{i}. indexte boşluk karakteri vardır.");
            }
            Console.ReadLine();
        }
    }
}
