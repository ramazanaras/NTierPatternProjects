using System;
using System.Collections.Generic;
using System.Configuration;//Syste.Configurationu referencelara ekledik.//ConfigurationManager sınıfı bu kütüphane içiinde yer alıyor çünkü.
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResimGalerisi.ORM
{
   public  class Tools
    {
        private static SqlConnection baglanti=new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);//appconfig de yazdığımız ismi yazdık.

        public static SqlConnection Baglanti
        {
            get { return baglanti; }
            set { baglanti = value; }
        }

    }
}
