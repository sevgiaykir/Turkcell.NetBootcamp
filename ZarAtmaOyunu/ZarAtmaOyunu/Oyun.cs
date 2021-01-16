using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    class Oyun
    {
        public Oyuncu BirinciOyuncu { get; set; }
        public Oyuncu IkinciOyuncu { get; set; }

        public void IlkOyuncuZarAt()
        {
            BirinciOyuncu.Oyna();
        }

        public void IkinciOyuncuZarAt()
        {
            IkinciOyuncu.Oyna();
        }

        public void IlkOyuncuBahisGir(int miktar)
        {
            BirinciOyuncu.Bahis = miktar;
            BirinciOyuncu.Bakiye = BirinciOyuncu.Bakiye - BirinciOyuncu.Bahis;
        }

        public void IkinciOyuncuBahisGir(int miktar)
        {
            IkinciOyuncu.Bahis = miktar;
            IkinciOyuncu.Bakiye = IkinciOyuncu.Bakiye - IkinciOyuncu.Bahis;
        }

        public Oyuncu Karsilastir()
        {
            if (BirinciOyuncu.OyuncununZari.Deger > IkinciOyuncu.OyuncununZari.Deger)
            {
                BirinciOyuncu.Bakiye += BirinciOyuncu.Bahis + IkinciOyuncu.Bahis;
                return BirinciOyuncu;
            }

            else if (BirinciOyuncu.OyuncununZari.Deger < IkinciOyuncu.OyuncununZari.Deger)
            {
                IkinciOyuncu.Bakiye += IkinciOyuncu.Bahis + IkinciOyuncu.Bahis;
                return IkinciOyuncu;
            }
            else
            {
                return null;
            }
        }
    }
}

