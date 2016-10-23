using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;//Connection state için ekledik.
namespace B304Mimari.ORM
{
    public class Tools
    {
        //Singleton Pattern:new 'lenmiş bir şey varsa onu dönder.yoksa new'le
        private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get
            {
                if (baglanti == null)//baglanti daha önce new'lenmemişse(yani boşşa(null)) new'le diyoruz.
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalBaglanti"].ConnectionString);//B304Mimiari.ORM'de references kısmında System Configurationu eklememiz gerekiyor.
                }

                //  baglanti = baglanti ?? new SqlConnection();//bağlantı nullsa new'le demek yukarıdakinin kısa hali

                return baglanti;
            }
            set { baglanti = value; }
        }

        //--------

        public static bool ExecuteNonQuery(SqlCommand cmd)//static diyerek . ile bu metoda ulaşılmasını sağladık.
        {
            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }

                int etkilenen = cmd.ExecuteNonQuery();

                if (etkilenen > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {

                return false;
            }
            finally//program hata versede vermesede bu kod çalışır.
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
              
            }


        }

        //-----------
        //generic metod
        public static bool InsertUpdate<T>(string procType,T entity)
        {
            Type TipGetir = typeof(T);


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("prc_{0}_{1}", TipGetir.Name,procType);//TipGetir.Name=Urunler veya TipGetir.Name=Kategoriler diye sınıf ismini döndürür.
            cmd.Connection = Tools.Baglanti;
            cmd.CommandType = CommandType.StoredProcedure;

            //sınıf içindeki propertyleri getirir.
            PropertyInfo[] propertys = TipGetir.GetProperties();//TipGetir.GetProperties() bize PropertyInfo[] dizi tipinde değer döndürür.TipGetir.GetProperties() sınıfın içindeki yani TT'de ne gelmişse onun(sınıfın) içindeki propertyleri bize getirir.(Reflection konusu)

            foreach (PropertyInfo pi in propertys)
            {
                string prmAdi = "@" + pi.Name;//propertynin ismini verir.(mesela UrunAdi)
                object deger = pi.GetValue(entity);//o an UrunAdiysa UrunAdinin değerini getirir.(entity.UrunAdi gibi) //değeri al dedik.//object tipi içine her tipten veri alır.int tipindede değer alır,string tipindede değer alır.

                cmd.Parameters.AddWithValue(prmAdi, deger);

            }


            return Tools.ExecuteNonQuery(cmd);


        }
        //--------

    }
}
