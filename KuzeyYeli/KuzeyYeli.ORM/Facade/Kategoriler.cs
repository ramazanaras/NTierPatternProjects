using KuzeyYeli.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.ORM.Facade
{
  public  class Kategoriler
    {

      //select metoddu
      //DataTable tipinde bir metod oluşturduk.
      public static DataTable Select() //static olarak yaptık bu metoda dışardan erişmek için Kategoriler.Select  diyerek erişebileceğiz
      {
          SqlDataAdapter adp = new SqlDataAdapter("prc_KategoriListele",Tools.Baglanti);//Tools sınıfında propertyi static yaptığımız için . diyerek ulaşım sağladık direk.

          adp.SelectCommand.CommandType = CommandType.StoredProcedure;//procedure olduğunu söyledik.

          DataTable dt = new DataTable();
          adp.Fill(dt);

          return dt;
      
      
      }



      //insert metodu

      public static bool Insert(Kategori k)//k Kategoriler nesnesidir.
      {
          SqlCommand cmd = new SqlCommand("prc_KategoriEkle", Tools.Baglanti);
          cmd.CommandType = CommandType.StoredProcedure;

          cmd.Parameters.AddWithValue("@adi", k.KategoriAdi);
          cmd.Parameters.AddWithValue("@tanim", k.Tanimi);

          //if (cmd.Connection.State==ConnectionState.Closed)//kapalı ise aç diyoruz
          //{
          //    cmd.Connection.Open();//bağlantıyı açtık
          //}

          //int etkilenen = cmd.ExecuteNonQuery();//sorgu çalıştı.

          //if (cmd.Connection.State != ConnectionState.Closed)//kapalı değilse kapat.
          //{
          //    cmd.Connection.Close();//bağlantıyı kapattık.

          //}

          //if (etkilenen>0)
          //{
          //    return true;// true döner ve metottan(Insert) direk çıkar
          //}
          //else
          //{
          //    return false;// false döner ve metottan(Insert) direk çıkar
          //}
          ////return etkilenen > 0 ? true : false;//tek satırdada yapabilirdik. //ternary if

          return Tools.ExecuteNonQuery(cmd);//yukarıdaki işlemler yerine bunu yaptık.

      }

      //update metodu
      //delete metodu

    }
}
