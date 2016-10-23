using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entity
{
    class KasaHareket
    {
        public int Id { get; set; }
        public int KasaHareketID { get; set; }
        public decimal Tutar { get; set; }//veritabanındaki money c#ta decimal'a karşılık gelir.
        public DateTime Tarih { get; set; }
    }
}
