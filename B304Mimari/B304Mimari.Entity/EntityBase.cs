using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B304Mimari.Entity
{
  public abstract  class EntityBase//bu sınıftan instance alınamaz
    {

      public abstract string PrimaryColumn { get; } //bu propertyi bu sınıftan miras alan sınıflarda ezilmesi zorunludur dedik.
    }
}
