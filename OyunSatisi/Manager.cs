using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    interface IManager
    {
        void Save(Person person);
        void Update(Person person);
        void Delete(Person person);

    }
}
