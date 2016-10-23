using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B304Mimari.Entity
{
   public class Kategoriler:EntityBase
    {
        //veritabanındaki kolonları buraya yazdık.tipleride dikkat ederek yazdık.
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string Tanimi { get; set; }
        public byte[] Resim { get; set; }  //veritabanındaki Image tipini burda byte[] dizisi olarak tanımladık.çünkü byte dizisi yolluyoruz.

        public override string PrimaryColumn
        {
            get { return "KategoriID"; }
        }
    }
}
