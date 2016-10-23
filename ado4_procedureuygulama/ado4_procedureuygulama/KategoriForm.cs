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
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)//satır seçilmişsse işlem yap
            {
                  SqlCommand cmd = new SqlCommand("prc_KategoriSil",baglanti);
                  cmd.CommandType = CommandType.StoredProcedure;
                
                int kategoriId=Convert.ToInt32(dataGridView1.CurrentRow.Cells["KategoriID"].Value);//kategori id hücresinin değerini değişkene attık.

                cmd.Parameters.AddWithValue("@kategoriId", kategoriId);

                baglanti.Open();

               int etkilenen= cmd.ExecuteNonQuery();
               if (etkilenen>0)
               {
                   MessageBox.Show("Kayıt Silindi");
                   KategoriListesi();
               }
               else
               {
                   MessageBox.Show("Kayıt Silinirken hata oluştu.");
               }

               baglanti.Close();
            }
        }

        SqlConnection baglanti = new SqlConnection("server=localhost;Database=KuzeyYeli;Integrated Security=true");
        private void KategoriForm_Load(object sender, EventArgs e)
        {
            KategoriListesi();
        }

        private void KategoriListesi() 
        {
          SqlDataAdapter adp = new SqlDataAdapter("prc_KategoriListele", baglanti);//procedure'ün ismini verdik.adp'ye veriler geldi
          adp.SelectCommand.CommandType = CommandType.StoredProcedure;//procedure olduğunu belirtmemiz lazım

          DataTable dt = new DataTable();//bir tablo oluşturduk sanal tablo gibi birşey içi boş şuan

          adp.Fill(dt);//tabloya verileri doldurduk.
          dataGridView1.DataSource = dt;//datagridview'de tabloyu gösterdik.


        
        
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("prc_KategoriEkle", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            //proceduredeki parametrelere değerleri atadık.
            cmd.Parameters.AddWithValue("@adi", txtAdi.Text);
            cmd.Parameters.AddWithValue("@tanim",txtTanim.Text);

            baglanti.Open();

            int etkilenen = cmd.ExecuteNonQuery();
            if (etkilenen>0)
            {
                MessageBox.Show("Kayıt başarılı şekilde eklendi");
                KategoriListesi();
            }
            else
            {
                MessageBox.Show("Kayıt eklenirken hata oluştu.");
            }

            baglanti.Close();
        }
        //hücrenin düzenlenmesi bittiğinde çalışır.
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
            //GÜNCELLEME İŞLEMLERİ
            SqlCommand cmd = new SqlCommand("prc_KategoriGuncelle", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;//procedure olduğunu belirttik

            DataGridViewRow row = dataGridView1.CurrentRow;//şuanki seçili satır

            //procedurelerin parametrelerine değerleri atadık. verdik.
            cmd.Parameters.AddWithValue("@id", row.Cells["KategoriID"].Value);
            cmd.Parameters.AddWithValue("@adi", row.Cells["KategoriAdi"].Value);
            cmd.Parameters.AddWithValue("@tanim", row.Cells["Tanimi"].Value);

            baglanti.Open();

            int etkilenen = cmd.ExecuteNonQuery();
            if (etkilenen > 0)
            {
                MessageBox.Show("Kayıt başarılı şekilde güncellendi");
                KategoriListesi();
            }
            else
            {
                MessageBox.Show("Kayıt güncellenirken hata oluştu.");
            }

            baglanti.Close();

           
          

            //Not:Additional information: String or binary data would be truncated. eğer böyle bir hata verirse bunun anlamı veritabanında belirtilen karakter sayısından fazla bir karakter girilmiş demektir.
        }
    }
}
