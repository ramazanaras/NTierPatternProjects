using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B304Mimari.ORM
{
    //generic interface
  public  interface IORM<T>
    {
      //interface'i içindeki metotların yada propertylerin gövdesi olmaz
      DataTable Listele();
      bool Ekle(T entity);
      bool Guncelle(T entity);
      bool Sil(int id);

    }
}
