using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace B304Mimari.ORM
{
    public class ORMBase<TT> : IORM<TT>
    {
        //generic tipin ne olduğunu bulmak için
        Type TipGetir //geriye Type döndürür
        {
            get
            {
                return typeof(TT);// typeof geriye Type döndürür.TT'nin tipini algıla ve dönder.

            }
        }

        public DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = string.Format("prc_{0}_Select", TipGetir.Name);//TipGetir.Name=Urunler veya TipGetir.Name=Kategoriler diye sınıf ismini döndürür.(TT elemanı ne gelirse işte prc_Urunler_Select veya prc_Kategoriler_Select'i çalıştırıcak.)
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }
        //---------------------------------
        //public bool Ekle(TT entity)//Urunler sınıfındaki propertyi adlarıyla proceduredeki propertyi adlarını aynı yapmamız gerekiyor.
        //{

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = string.Format("prc_{0}_Insert", TipGetir.Name);//TipGetir.Name=Urunler veya TipGetir.Name=Kategoriler diye sınıf ismini döndürür.
        //    cmd.Connection = Tools.Baglanti;
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    //sınıf içindeki propertyleri getirir.
        //    PropertyInfo[] propertys = TipGetir.GetProperties();//TipGetir.GetProperties() bize PropertyInfo[] dizi tipinde değer döndürür.TipGetir.GetProperties() sınıfın içindeki yani TT'de ne gelmişse onun(sınıfın) içindeki propertyleri bize getirir.(Reflection konusu)

        //    foreach (PropertyInfo pi in propertys)
        //    {
        //        string prmAdi = "@"+pi.Name;//propertynin ismini verir.(mesela UrunAdi)
        //        object deger = pi.GetValue(entity);//o an UrunAdiysa UrunAdinin değerini getirir.(entity.UrunAdi gibi) //değeri al dedik.//object tipi içine her tipten veri alır.int tipindede değer alır,string tipindede değer alır.

        //        cmd.Parameters.AddWithValue(prmAdi,deger);

        //    }


        //    return Tools.ExecuteNonQuery(cmd);


        //}

        //public bool Guncelle(TT entity)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = string.Format("prc_{0}_Update", TipGetir.Name);
        //    cmd.Connection = Tools.Baglanti;
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    PropertyInfo[] propertys = TipGetir.GetProperties();

        //    foreach (PropertyInfo pi in propertys)
        //    {
        //        string prmAdi = "@" + pi.Name;
        //        object deger = pi.GetValue(entity);//object tipi her tipten(int,string tipi gibi) veri alır.
        //        cmd.Parameters.AddWithValue(prmAdi,deger);
        //    }
        //    return Tools.ExecuteNonQuery(cmd);
        //}
        //----------------------------------------------------------yukarıdakileri aşağıdaki gibi dahada kısaltabiliriz

        public bool Ekle(TT entity)
        {

            return Tools.InsertUpdate<TT>("Insert", entity);

        }


        public bool Guncelle(TT entity)
        {

            return Tools.InsertUpdate<TT>("Update", entity);

        }
        //----------


        public bool Sil(int id)
        {
            //bilinmeyen tipten instance üretmek
            TT ent = Activator.CreateInstance<TT>(); //verdiğimiz tipten(sınıftan Urunler sınıfından veya Kategoriler sınıfında) instance üretir.

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("prc_{0}_Delete", TipGetir.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Tools.Baglanti;

            PropertyInfo primaryColumn = TipGetir.GetProperty("PrimaryColumn"); //publi c override string PrimaryColumn { get { return "KategoriID"; } } } classlarda bu propertyiyi yazmıştık bunun değerini getir diyoruz.

           
            string prmAdi = "@"+primaryColumn.GetValue(ent);//@KategoriID veya @UrunID gibi değer//buradaki ent içinde constructor anında oluşturulmuş PrimaryColumn değerini tutuyor onun için bizde yukarıda instance aldık.vede buraya ekledik.


            cmd.Parameters.AddWithValue(prmAdi,id);

            return Tools.ExecuteNonQuery(cmd);
        }


        //----------

    }
}
