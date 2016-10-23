using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B304Mimari.Entity
{
  public  class Tedarikciler:EntityBase
    {
        public int TedarikciID { get; set; }
        public string SirketAdi { get; set; }  //veritabanındaki nvarchar veya ntext'i c#ta string olarak ayarladık.
        public string MusteriAdi { get; set; }
        public string MusteriUnvani { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Bolge { get; set; }
        public string PostaKodu { get; set; }
        public string Ulke { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }
        public string WebSayfasi { get; set; }

        public override string PrimaryColumn
        {
            get { return "TedarikciID"; }
        }
    }
}
