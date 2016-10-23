using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entity
{
  public  class Personeller
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Tckn { get; set; }
        public string TelNo { get; set; }
        public string Adres { get; set; }
        public DateTime DogumTarihi { get; set; }//veritabanındaki date veya datetime c3 DateTime 'a karşılık gelir.
        public DateTime IseGirisTarihi { get; set; }
        public decimal Maas { get; set; }//veritabanındaki money alanı c# ta  decimal'a karşılık gelir
        public bool Aktif { get; set; }//veritabanındaki bit alanı c# ta bool'a karşılık gelir.

        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }

    }
}
