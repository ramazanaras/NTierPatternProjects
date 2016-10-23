using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM
{
    public class ORMBase<T> : IORM<T> where T : class //ORMBase dışardan aldığı tipi IORM'e verir.
    {
        ////generic tipin ne olduğunu(Kategoriler mi Urunler mi Satis mi oldugunu) bulmak için(Sınıfın adını bulmak için)
        //Type TipGetir //geriye Type döndürür
        //{
        //    get
        //    {
        //        return typeof(T);// typeof geriye Type döndürür.T'nin tipini algıla ve dönder.

        //    }
        //}

        //yukarıdaki gibide bulabilirdik.ama aşağıdaki gibi yaptık biz.(Reflection)
        //Reflection:Tipi belli olmayan tipler üzerinde çalışma işlemidir.
        private string ClassName
        {
            get
            {

                //typeof:Tipi belli olmayan(generic bir) elemanın tipini belirlemeyi sağlar.
                return typeof(T).Name;//gelen tipin sınıf ismini dönderir.(Kategoriler mi Urunler mi Satis mi oldugunu)(Reflection)
                //Name özelliği T tipinin(sınfıının ) adını verir.
            }
        }

        //--------

        public DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("prc_{0}_Select", ClassName), Tools.Baglanti);//verileri adp'ye doldurduk

            adp.SelectCommand.CommandType = CommandType.StoredProcedure;//procedure olduğunu belirttik
            DataTable dt = new DataTable();//sanal tablo gibi birşey oluşturduk 
            adp.Fill(dt);//vede tabloya(dt) verileri doldurduk

            return dt;//tabloyu dönderdik(içinde veriler var)
        }
        //---------
        //public bool Insert(T entity)
        //{
        //    SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Baglanti);
        //    cmd.CommandType = CommandType.StoredProcedure;


        //    //propertyler PropertyInfo tipindedir.
        //    PropertyInfo[] propertys = typeof(T).GetProperties();//Kasa sınıfındaki veya Urun sınıfındaki propertileri getir.//GetProperties:T elemanı içindeki propertileri bir dizi olarak dönderen metottur.


        //    foreach (PropertyInfo pi in propertys)
        //    {
        //        //pi.Name:Property'nin adını verir.
        //        string name = pi.Name;//propertynin ismini verir.(mesela UrunAdi)
        //        if (name.ToLower() == "id" || name.ToLower()=="ıd")//Id'leri almıyoruz çünkü onlar identity değeri olduğu için
        //        {
        //            continue;//burayı atla bir sonrakine geç
        //        }

        //        //bu propertynin dolu hali(entity) ordan kendisine göre değeri alır.(GetValues:Yani benim değerimi entity'i içinden getir.)
        //        object value = pi.GetValue(entity);//o an UrunAdiysa UrunAdinin değerini getirir.(entity.UrunAdi gibi) //değeri al dedik.//object tipi içine her tipten veri alır.int tipindede değer alır,string tipindede değer alır.

        //        cmd.Parameters.AddWithValue("@" + name, value);
        //    }

        //        return Tools.Exec(cmd);

        //}

        //yukarıdakinin daha kısa hali
        public bool Insert(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlustur<T>(cmd, KomutTip.Insert, entity);


            return Tools.Exec(cmd);

        }

        //--------
        public object InsertScalar(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlustur<T>(cmd, KomutTip.Insert, entity);

            return Tools.ExecScalar(cmd); //bize ExecScalar'dan id gelecek (object tipinde)
        }

        //-----------

        public bool Update(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Update", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlustur<T>(cmd, KomutTip.Update, entity);


            return Tools.Exec(cmd);


        }

        public bool Delete(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Delete", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlustur<T>(cmd, KomutTip.Delete, entity);

            return Tools.Exec(cmd);




        }








    }
}
