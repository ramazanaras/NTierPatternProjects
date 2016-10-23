using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.ORM.Entity
{
  public  class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int TedarikciID { get; set; }
        public int KategoriID { get; set; }
        public string BirimdekiMiktar { get; set; }
        public decimal Fiyat { get; set; }  //veritabanındaki money c#ta decimal dır.
        public short Stok { get; set; }   //veritabanındaki smallint c#ta short tur.
        public short YeniSatis { get; set; }
        public short EnAzYenidenSatisMiktari { get; set; }
        public bool Sonlandi { get; set; }  //veritabanındaki bit c# ta booldur.
    }
}
