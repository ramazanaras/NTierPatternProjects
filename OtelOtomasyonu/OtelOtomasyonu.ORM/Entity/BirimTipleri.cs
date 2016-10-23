using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entity
{
  public  class BirimTipleri
    {
      public BirimTipleri()//constructor metot--sınıf tanımlandığında(instance alınırken --new'lenirken) çalışır
      {
          Aktif = true;
      }
        public int Id { get; set; }
        public string Adi { get; set; }//veritabanındaki nvarchar,varchar,char gibi tipler c# ta stringtir.
        public bool Aktif { get; set; } //veritabanındaki bit c# ta bool'a karşılık gelir.
    }
}
