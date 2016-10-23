using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entity
{
  public  class SatinAlmaDetay
    {
        public int SatinAlmaID { get; set; }
        public int UrunID { get; set; }
        public double Miktar { get; set; } //veritabanındaki float c# ta double'a karşılık geliyor.
        public decimal AlisFiyati { get; set; } //veritabanındaki money c# ta decimal'a karşılık geliyor.
       
       
    }
}
