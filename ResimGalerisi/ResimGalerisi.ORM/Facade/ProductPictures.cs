using ResimGalerisi.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResimGalerisi.ORM.Facade
{
    public class ProductPictures
    {
        public static bool Ekle(ProductPicture pp)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "prc_ResimEkle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Tools.Baglanti;

            cmd.Parameters.AddWithValue("@pId", pp.ProductID);
            cmd.Parameters.AddWithValue("@picture", pp.Picture.Length).Value = pp.Picture; //byte[] dizisini parametre verirken bu şekilde veriyoruz.

            Tools.Baglanti.Open();

            int etkilenen = cmd.ExecuteNonQuery();
            if (etkilenen>0)
            {
                Tools.Baglanti.Close();
                return true;
               
            }
            else
            {
                Tools.Baglanti.Close();
                return false;
              
            }
          
        }


        public static DataTable Listele(int id)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand("prc_ResimGetir");
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.SelectCommand.Connection = Tools.Baglanti;

            adp.SelectCommand.Parameters.AddWithValue("@id",id);

            DataSet ds = new DataSet();
            adp.Fill(ds,"Resimler");

            return ds.Tables["Resimler"];

        }
    }
}
