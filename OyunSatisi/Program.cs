using System;

namespace OyunSatisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Customer1 = new Customer() {Id="1",Name="Emir",Surname="Kösekul" };
            IManager manageCustomer = new CustomerManager();
            manageCustomer.Save(Customer1);
            IKampanyaManager kampanya = new Kampanya();
            KampanyaBilgileri kampanyaBilgisi = new KampanyaBilgileri() { KampanyaAdi = "%30 off " };
            kampanya.Add(kampanyaBilgisi);
            ManageGameSelling manageSelling = new ManageGameSelling();
            manageSelling.Sell(Customer1,kampanyaBilgisi);
            
            
        }
    }
}
