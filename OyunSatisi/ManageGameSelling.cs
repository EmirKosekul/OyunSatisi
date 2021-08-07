using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    class ManageGameSelling : IManageSelling
    {
        public void Sell(Person person, KampanyaBilgileri kampanyaBilgisi)
        {
            Console.WriteLine(person.Name + " " + person.Surname + " adlı kişi için oyun satıldı. "+kampanyaBilgisi.KampanyaAdi+"kampanyası kullanıldı.");
        }
    }
}
