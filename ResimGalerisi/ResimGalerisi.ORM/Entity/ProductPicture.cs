using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;//bu kütüphaneyi getirtebilmek için referencelara System.Drawingi eklememiz lazım . Image tipini oluştururken hata vermemesi için.


namespace ResimGalerisi.ORM.Entity
{
   public class ProductPicture
    {
        public int Id { get; set; }
        public int ProductID { get; set; }

        public byte[] Picture { get; set; }//sqlde image tipi c#ta byte[] dizisi tipine karşılık geliyor. 

        public bool IsActive { get; set; }



    }
}
