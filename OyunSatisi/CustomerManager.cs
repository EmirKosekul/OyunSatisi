using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    class CustomerManager : IManager
    {
        public void Save(Person person)
        {
            Console.WriteLine(person.Name + " " + person.Surname + " adlı kişi sisteme eklendi");
        }
        public void Delete(Person person)
        {
            Console.WriteLine(person.Name + " " + person.Surname + " adlı kişi sistemden silindi");
        }
        public void Update(Person person)
        {
            Console.WriteLine(person.Name + " " + person.Surname + " adlı kişinin bilgileri güncellendi");
        }
    }
}
