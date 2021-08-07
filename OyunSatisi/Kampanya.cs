using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    class Kampanya : IKampanyaManager
    {
        public void Add(KampanyaBilgileri kampanyaBilgileri)
        {
            Console.WriteLine(kampanyaBilgileri.KampanyaAdi+" Kampanyası Sisteme Eklendi");
        }

        public void Delete(KampanyaBilgileri kampanyaBilgileri)
        {          
            Console.WriteLine(kampanyaBilgileri.KampanyaAdi + " Kampanyası Sistemden Silindi");
        }

        public void Update(KampanyaBilgileri kampanyaBilgileri)
        {
            Console.WriteLine(kampanyaBilgileri.KampanyaAdi + " Kampanyası Güncellendi");
        }
    }
}
