using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResimGalerisi.ORM.Facade
{
  public  class Products
    {
      public static DataTable Listele()
      {
          SqlDataAdapter adp = new SqlDataAdapter();

          //SqlCommand cmd = new SqlCommand("prc_UrunListele");
          //adp.SelectCommand = cmd;

          adp.SelectCommand = new SqlCommand("prc_UrunListele"); //SelectCommanda command nesnesi vermiş oluyoruz.yukarıdaki gibide yapabilirdik bu daha kısa hali.

          adp.SelectCommand.CommandType = CommandType.StoredProcedure;


          adp.SelectCommand.Connection = Tools.Baglanti;//static olduğu için new 'lemeden direk ulaştık.

          //DataTable dt = new DataTable();
          //adp.Fill(dt);//dt'nin içini doldurduk.

          //return dt;

          //yukarıdaki gibide yapabilirdik.
          DataSet ds = new DataSet();
          adp.Fill(ds,"Products");//ds'nin içindeki datatable'a isim verdik.aşağıdada o datatable'ı döndürdük.

          return ds.Tables["Products"];

      }
    }
}
