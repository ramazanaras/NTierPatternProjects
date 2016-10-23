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

namespace ado2_disconnected_mimari
{
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=localhost;database=KuzeyYeli;Integrated Security=true");
        //IIntegrated Security:Windows authentication ile servera bağlanmayı sağlar.
        private void KategoriForm_Load(object sender, EventArgs e)
        {
            KategoriListesi();
        }

        private void KategoriListesi() 
        {
            SqlDataAdapter adp = new SqlDataAdapter("select*from Kategoriler", baglanti);//tablo çıktısı verir.
            DataTable dt = new DataTable();
            adp.Fill(dt);//tablo çıktısını dt'ye doldurur.

            dataGridView1.DataSource = dt;//tabloyuda datagridwievde gösteriyoruz.
            dataGridView1.Columns["KategoriID"].Visible = false;
        
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("insert into Kategoriler(KategoriAdi,Tanimi) values('{0}','{1}')", txtKategoriAdi.Text, txtTanimi.Text);
            cmd.Connection = baglanti;

            baglanti.Open();

            int etkilenen = cmd.ExecuteNonQuery();

            if (etkilenen>0)
            {
                MessageBox.Show("Ekleme başarılı");
                KategoriListesi();
            }
            else
            {
                MessageBox.Show("Ekleme başarısız");
            }

            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


    }
}
