using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.ORM
{
   public class Tools
    {
       //Bu yöntem iyi bir yöntem değil .çünkü connection stringi değiştirmeye çalıştığımızda her yerde tek tek değiştirmemiz gerekecek.
       //private static SqlConnection baglanti = new SqlConnection("server=localhost;database=KuzeyYeli;Integrated Security=true;");

       // public  static SqlConnection Baglanti
       // {
       //     get { return baglanti; }
           
       // }


       //WinForm.UI 'da app confige connection stringi yazarız vede KuzeyYeli.ORM'deki references kısmındada config oalrak arayıp System.Configurationı referans olarak eklememiz lazım.
       private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);//connection stringi bu şekilde çektik.
       

        public static SqlConnection Baglanti
        {
            get { return baglanti; }

        }



       //----------------

       public static bool ExecuteNonQuery(SqlCommand cmd)
        {

            try
            {

                if (cmd.Connection.State == ConnectionState.Closed)//kapalı ise aç diyoruz
                {
                    cmd.Connection.Open();//bağlantıyı açtık
                }

                int etkilenen = cmd.ExecuteNonQuery();//sorgu çalıştı.

               

                return etkilenen > 0 ? true : false;//ternary if
            }

            catch (Exception)
            {

                return false;
            }

           finally//hata versede vermesede program buradaki kod çalışır.
            {
                if (cmd.Connection.State != ConnectionState.Closed)//kapalı değilse kapat.
                {
                    cmd.Connection.Close();//bağlantıyı kapattık.

                }
            }

        }

       //----------------

        
    }
}
