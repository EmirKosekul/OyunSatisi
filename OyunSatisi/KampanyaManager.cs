using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    interface IKampanyaManager
    {
        void Add(KampanyaBilgileri kampanyaBilgileri);
        void Delete(KampanyaBilgileri kampanyaBilgileri);
        void Update(KampanyaBilgileri kampanyaBilgileri);
    }
}
