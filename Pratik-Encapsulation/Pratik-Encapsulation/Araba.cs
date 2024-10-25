using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Encapsulation
{
    public class Araba
    {
        public string Marka = "Corvette";
        public string Model = "C8";
        public string Renk = "Kırmızı";

        private int _kapiSayisi = 4;

        public int KapiSayisi
        {
            get { return _kapiSayisi; }
            set 
            {   
                if (_kapiSayisi == 2 || _kapiSayisi == 4)
                {
                    _kapiSayisi = value;
                }
                // 2 vey 4 dışında değer atanırsa olacaklar
                else
                {
                    Console.WriteLine("Kapı sayısı 2 veya 4 olmalı");
                    _kapiSayisi = -1;
                }
            }
        }

        public void OzellikleriYazdir()
        {
            Console.WriteLine($"Arabanın Markası: {Marka}\nModeli: {Model}\nRengi:{Renk}\nKapı Sayisi: {KapiSayisi} ");
        }


    }
}
