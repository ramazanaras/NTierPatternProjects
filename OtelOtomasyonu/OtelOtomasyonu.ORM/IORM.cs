using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM
{
    //generic interface
  public  interface IORM<T> where T:class //T elemanı class olmak zorundadır dedik
    {
      //interface içinde gövdeler olmaz vede başına falan public yazılmaz
      DataTable Select();
      bool Insert(T entity);
      object InsertScalar(T entity);
      bool Update(T entity);
      bool Delete(T entity);   

    }
}
