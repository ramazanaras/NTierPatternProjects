using OtelOtomasyonu.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Facade
{
    public  class PersonellerORM:ORMBase<Personeller>
    {
        public static Personeller AktifKullanici;//static yaptıkki ortak bir yerde dursun heryerden erişilsin.(sanal veritabanı gibi birşey burda değer saklanır başka yerlerdende erişiriz.)giriş yapan kullanıcıyı burda tuttuk.giriş yapan kullanıcının bilgileri var burada.Başka bir yerden PersonellerORM.AktifKullanici diyerek giriş yapmış kullanıcıya erişebiliriz.ve bilgilerini okuyabiliriz.Static elemanlar global oluyor .global olarak bunu kullancaz.Veritabanı gibi birşey.//Satış veya satışdetayda hagi personel satış yapmış işlem olarak yapabileceğiz

        public Personeller GirisYap(Personeller p)
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Personeller_Giris",Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.AddWithValue("@ka",p.KullaniciAdi);
            adp.SelectCommand.Parameters.AddWithValue("@prl",p.Parola);

            DataTable dt = new DataTable();
            adp.Fill(dt);//verileri dt 'ye doldurduk.

            //
            if (dt.Rows.Count==0)//eğer hiç veri gelmemişse(yani kullanıcı adı ve parola yanlış girilmiş demektir.) null dönder.()(yani metottdan çık)
            {
                return null;//return demek  değeri dönder ve metottan çık demek.
            }

            //kullanıcı adı ve parola doğru girilmişse(yani kullanıcı giriş yapmışssa)aşağıdaki işlemleri yap.
            Personeller aktif = new Personeller();
            foreach (DataRow dr in dt.Rows) //dt.rows geriye DataRow tipinde eleman dönderir.(dt.Rows DataRowCollection'ıdır. )//bir satır gelecek ama biz yinede foreach'le dönderdik.
            {
                //giriş yapmış kullanıcının bilgileri
                aktif.Id = (int)dr["Id"];
                aktif.Adi = dr["Adi"].ToString();
                aktif.Soyadi = dr["Soyadi"].ToString();
                aktif.KullaniciAdi = dr["KullaniciAdi"].ToString();
                aktif.Parola = dr["Parola"].ToString();
            }
            return aktif;//aktif personeli(bilgileriyle beraber) dönderdik.
            //Satış veya satışdetayda hagi personel satış yapmış işlem olarak yapabileceğiz
        }


    }
}
