using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.ORM.Entity
{
   public class Kategori
    {
       //veritabanındaki kolonları buraya yazdık.tipleride dikkat ederek yazdık.
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string Tanimi { get; set; }

    }
}
