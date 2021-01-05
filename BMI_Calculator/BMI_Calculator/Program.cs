using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("******Vücut Kitle İndeksi Hesaplama******");
                Console.WriteLine("Boyunuzu cm cinsinden giriniz:");
                float boy = float.Parse(Console.ReadLine().Replace('.', ','));
                Console.WriteLine("Kilonuzu giriniz:");
                float kilo = float.Parse(Console.ReadLine().Replace('.', ','));
                double bmi = (kilo / (boy / 100 * boy / 100));
                bmi = Math.Round(bmi, 2);
                Console.WriteLine($"Vücut Kitle İndeksiniz: {bmi}");

                if (bmi < (18.5))
                {
                    Console.WriteLine("Kilo kategoriniz: Zayıf");
                }
                else if (bmi >= (18.5) && bmi <= (24.9))
                {
                    Console.WriteLine("Kilo kategoriniz: Normal");
                }
                else if (bmi > (24.9) && bmi <= (29.9))
                {
                    Console.WriteLine("Kilo kategoriniz: Fazla kilolu");
                }
                else if (bmi > (29.9) && bmi <= (34.9))
                {
                    Console.WriteLine("Kilo kategoriniz: Obez");
                }
                else if (bmi > (34.9))
                {
                    Console.WriteLine("Kilo kategoriniz: Aşırı Obez");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen sayısal bir değer giriniz!");
            }
            catch (Exception hata)
            {
                Console.WriteLine("Bir hata oluştu!" + hata.Message);
            }
            Console.ReadLine();
        }
    }
}