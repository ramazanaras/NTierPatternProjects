using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entity
{
    public class Urunler
    {
        public Urunler()//constructor metot--sınıf tanımlandığında(instance alınırken --new'lenirken) çalışır
        {
            Aktif = true;
        }
        public int Id { get; set; }
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }//veritabanındaki money c# ta decimal'a karşılık geliyor.
        public double Miktar { get; set; } //veritabanındaki float c# ta double'a karşılık geliyor.
        public int KategoriID { get; set; }
        public int BirimTipID { get; set; }
        public bool Aktif { get; set; }//veritabanındaki bit c# ta bool'a karşılık geliyor.
    }
}
