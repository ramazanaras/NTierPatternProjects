using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado4_procedureuygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=localhost;database=KuzeyYeli;Integrated Security=true");
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //normal ekleme
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "insert Urunler(UrunAdi,Fiyat,Stok) values(@adi,@fiyat,@stok)";
            ////Not:parametreli yapınca sqlinjection dan kurtuluyoruz.güvvenlik açığını kapatıyoruz
            ////yukarıdaki parametrelere değerleri atadık
            //cmd.Parameters.AddWithValue("@adi", txtUrunAdi.Text);
            //cmd.Parameters.AddWithValue("@fiyat", nudFiyat.Value);
            //cmd.Parameters.AddWithValue("@stok", nudStok.Value);
            //cmd.Connection = baglanti;
            //-------------------------------------------------
            //procedure yapısı ile ekleme
            SqlCommand cmd = new SqlCommand("UrunEkle", baglanti);//procedure'un ismini verdik
            cmd.CommandType = CommandType.StoredProcedure;//procedure olduğunu belirttik.

            //proceduredeki parametrelere aşağıda değerleri verdik.
            cmd.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
            cmd.Parameters.AddWithValue("@fiyat", nudFiyat.Value);
            cmd.Parameters.AddWithValue("@stok", nudStok.Value);


            baglanti.Open();//bağlantıyı açtıktan sonra komutu çalıştırıyoruz.
            int etkilenen = cmd.ExecuteNonQuery();



            if (etkilenen > 0)
            {
                MessageBox.Show("Kayıt Eklendi");
                UrunListesi();//ürün eklendikten sonra listeyi tekrar çağır.
            }
            else
            {
                MessageBox.Show("Kayıt eklenirken hata oluştu");
            }

            baglanti.Close();
        }

        private void UrunListesi()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select*from Urunler where Sonlandi=0", baglanti);//verileri adp'ye aktardık

            DataTable dt = new DataTable();//bir tablo oluşturduk sanal gibi birşey

            adp.Fill(dt);//adp'deki verileri tabloya doldurduk
            dataGridView1.DataSource = dt; //datagridviewdede tabloyu gösterdik.



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)//yani datagridview'de bir satır seçilmişse işlemleri yap.
            {
                SqlCommand cmd = new SqlCommand("UrunSil", baglanti);//stored proceduren ismini verdik
                cmd.CommandType = CommandType.StoredProcedure;//procedure olduğunu belirttik.

                cmd.Parameters.AddWithValue("@urunId", dataGridView1.CurrentRow.Cells["UrunID"].Value);

                baglanti.Open();//bağlantıyı açtık

                int etkilenen = cmd.ExecuteNonQuery();

                if (etkilenen > 0)
                {
                    MessageBox.Show("Kayıt silindi");
                    UrunListesi();
                }
                else
                {
                    MessageBox.Show("Kayıt silinirken hata oluştu");
                }

            }
            baglanti.Close();
        }

    }
}