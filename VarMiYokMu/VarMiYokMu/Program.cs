using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarMiYokMu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Eskişehir", "İstanbul", "Ankara", "İzmir", "Diyarbakır", "Sinop" };
            Console.WriteLine("Bir şehir giriniz: ");
            string girilenSehir = Console.ReadLine();
            bool varMi = false;
            int i = 0;
            foreach(string sehir in sehirler)
            {
                Console.Write(sehir + " * "); //alt satıra geçmeden yazdır
                if(sehir==girilenSehir)
                {
                    varMi = true; //flag
                    break;
                }
                i++;
            }
            Console.WriteLine();
            if(varMi)
            {
                Console.WriteLine($"{girilenSehir} array'de vardır ve {i}. indextedir.");
            }
            else
            {
                Console.WriteLine($"{girilenSehir} array'de yoktur.");
            }
            Console.ReadLine();
        }
    }
}
