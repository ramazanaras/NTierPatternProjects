using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM
{
    public class Tools
    {
        //OtelOtomasyonu.ORM 'de references kısmına System.Configutarionu eklememiz gerekiyor.

        //Singleton Pattern:new 'lenmiş bir şey varsa onu dönder.yoksa new'le
        //tanımlamış olduğum elemanın propertysinin  get anında geriye fieldın değerini döndermeden önce null mı diye bakarım nullsa new 'le değilse var olan değeri döndeririz.(Mülakat sorusu olabilir.)
        private static SqlConnection baglanti;

        public static SqlConnection Baglanti //Tools. diyerek ulaşabilmek için static yaptık.
        {
            get
            {
                if (baglanti == null)//baglanti daha önce new'lenmemişse(yani boşşa(null)) new'le diyoruz.
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);//OtelOtomasyonu.ORM'de references kısmında System Configurationu eklememiz gerekiyor.
                }

                //  baglanti = baglanti ?? new SqlConnection();//bağlantı nullsa new'le demek yukarıdakinin kısa hali

                return baglanti;
            }

        }

        //--------------
        public static bool Exec(SqlCommand cmd)//static yapınca Tools. diyerek bu metoda ulaşabiliriz.
        {

            try
            {
                if (cmd.Connection.State!=ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false; //ternary if 



            }
            catch (Exception)
            {

                return false;
            }

            finally//program hata versede vermesede her halükarda burası  çalışır.(bağlantıyı kapatıyoruz burda)
            {
                if (cmd.Connection.State != ConnectionState.Closed)//yani açıksa
                {
                    cmd.Connection.Close();//bağlantıyı kapat.
                }


            }


        }

        //-----------------
        public static object ExecScalar(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State!=ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                object deger = cmd.ExecuteScalar();//eklenen kaydın idsini döndereceğiz.(bize tek satır tek sutunlu veri dönderir.)(object tipinde)object:içinde her tipten veri  bulunabilen bir tiptir.
                 
                return deger;

            }
            catch (Exception)
            {

                return 0;
            }
            finally
            {
                if (cmd.Connection.State!=ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }

            }



        }

        //-----------------


        //generic metod
      public static  void ParametreOlustur<T>(SqlCommand cmd,KomutTip kt,T ent)//kt enum tipinde 
        {

            PropertyInfo[] propertys = typeof(T).GetProperties();

            foreach (PropertyInfo pi in propertys)
            {



                //pi.Name:Property'nin adını verir.
                string name = pi.Name;//propertynin ismini verir.(mesela UrunAdi)
                if (name.ToLower() == "id" || name.ToLower() == "ıd" && kt==KomutTip.Insert)//Id'leri almıyoruz çünkü onlar identity değeri olduğu için. Inserte göre işlem yapacağımızda burası atlasın dedik ayrıca.Update 'de bütün parametreleri alıyor.
                {
                    continue;//burayı atla bir sonrakine geç
                }
                else if (kt==KomutTip.Delete && (name.ToLower()!="ıd" && name.ToLower()!="id"))//delete işlemi için(yani sadece id değerini alsın diyoruz..)
                {
                    continue;   
                }

                //bu propertynin dolu hali(entity) ordan kendisine göre değeri alır.(GetValues:Yani benim değerimi entity'i içinden getir.)
                object value = pi.GetValue(ent);//o an UrunAdiysa UrunAdinin değerini getirir.(entity.UrunAdi gibi) //değeri al dedik.//object tipi içine her tipten veri alır.int tipindede değer alır,string tipindede değer alır.

                cmd.Parameters.AddWithValue("@" + name, value);
            }


        }
        //-----------------


    }
}
