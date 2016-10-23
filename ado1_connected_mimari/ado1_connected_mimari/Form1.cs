using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//Sqlconnection için
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado1_connected_mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            //sql authentication ile bağlanma
            //baglanti.ConnectionString = "server=localhost;database=KuzeyYeli;User=sa;Pwd=123";
            
            //windows authetication kullanarak
            baglanti.ConnectionString = "server=localhost;database=KuzeyYeli;Integrated Security=true";

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select*from Urunler";
            komut.Connection = baglanti;

            baglanti.Open();//bağlantıyı aç.

            SqlDataReader rdr = komut.ExecuteReader();//komutu çalıştır geriye dönen verileri rdr nesnesine at.

            while (rdr.Read())
            {
                string adi = rdr["UrunAdi"].ToString();
                string fiyat = rdr["Fiyat"].ToString();
                string stok = rdr["Stok"].ToString();

                listUrunler.Items.Add(String.Format("{0}-{1}-{2}",adi,fiyat,stok));
            }

            baglanti.Close();//bağlantıyı kapattık.

        }
    }
}
