using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B304Mimari.Entity
{
    public class Urunler:EntityBase //tablo ismi ile burdaki isim(Urunler) birebir aynı olması lazım ve de aşağıdaki property isimleride  tablo kolonlarıyla aynı isimde olmasına dikkat et.tipleride veritabanındaki tiplere göre ayarla.(kesin yapın diye birşey yok ama genel manada böyle yapılır.)
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int TedarikciID { get; set; }
        public int KategoriID { get; set; }
        public string BirimdekiMiktar { get; set; }
        public decimal Fiyat { get; set; }  //veritabanındaki money c#ta decimal dır.
        public short Stok { get; set; }   //veritabanındaki smallint c#ta short tur.
        public short YeniSatis { get; set; }
        public short EnAzYenidenSatisMikatari { get; set; }
        public bool Sonlandi { get; set; }  //veritabanındaki bit c# ta booldur.




        public override string PrimaryColumn
        {
            get { return "UrunID"; }
        }
    }
}
