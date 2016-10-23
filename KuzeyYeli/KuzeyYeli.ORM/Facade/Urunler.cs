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
  public  class Urunler
    {
        //select metodu
        public static DataTable Select()
        {

            SqlDataAdapter adp = new SqlDataAdapter("UrunListele",Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }

         //insert metodu
        public static bool Insert(Urun u)//ctrl . diyerek yukarıda using KuzeyYeli.ORM.Entity; ekliyoruz
        { 
        SqlCommand cmd=new SqlCommand("UrunEkle",Tools.Baglanti);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@urunAdi", u.UrunAdi);
            cmd.Parameters.AddWithValue("@fiyat", u.Fiyat);
            cmd.Parameters.AddWithValue("@stok", u.Stok);
            cmd.Parameters.AddWithValue("@kId", u.KategoriID);
            cmd.Parameters.AddWithValue("@tId", u.TedarikciID);

            //if (cmd.Connection.State == ConnectionState.Closed)//kapalı ise aç diyoruz
            //{
            //    cmd.Connection.Open();//bağlantıyı açtık
            //}

            //int etkilenen = cmd.ExecuteNonQuery();//sorgu çalıştı.

            //if (cmd.Connection.State != ConnectionState.Closed)//kapalı değilse kapat.
            //{
            //    cmd.Connection.Close();//bağlantıyı kapattık.

            //}

            //return etkilenen > 0 ? true : false;//ternary if

            return Tools.ExecuteNonQuery(cmd);//yukarıdaki işlemler yerine bunu yaptık.


        }




    }
}
