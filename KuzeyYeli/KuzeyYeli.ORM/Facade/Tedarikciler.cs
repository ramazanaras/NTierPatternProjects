using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.ORM.Facade
{
  public  class Tedarikciler
    {
        public static DataTable Select()//static yaptık bu metodu  Formda direk . ile erişebilmek için 
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_TedarikciListele",Tools.Baglanti);//veriler adp'ye aktarıldı
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();//sanal tablo gibi birşey 
            adp.Fill(dt);//tabloya verileri doldurduk

            return dt;



        }
    }
}
