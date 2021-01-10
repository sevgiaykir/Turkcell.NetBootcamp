using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelirliAraliktakiAsalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 ile 10000 arasındaki asal sayılar
            Console.WriteLine("***2 ile 10000 arasındaki asal sayılar***");
            for (int i = 2; i < 10000; i++)
            {
                bool asalMi = true; //flag
                for (int bolen = 2; bolen < i; bolen++)
                {
                    if (i % bolen == 0)
                    {
                        asalMi = false;
                        break; //döngüden çık
                    }
                }
                if (asalMi == true)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
