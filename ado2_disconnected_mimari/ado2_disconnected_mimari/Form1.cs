using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//SqlConnectionu için ekledik.(aşağıda ctrl . yaparakda buraya eklenmesini sağlayabiliriz.  )
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado2_disconnected_mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server=localhost;database=KuzeyYeli;Integrated Security=true");
        private void Form1_Load(object sender, EventArgs e)
        {


            UrunListesi();


        }

        private void UrunListesi()
        {
            //Disconnected Mimari yöntemi ile veri listeleme işlemidir.
            SqlDataAdapter adp = new SqlDataAdapter("select*from Urunler", baglanti);//verileri adp'ye koyduk.//Not:adp arka planda bağlantıyı kendi açıyor kendi kapatıyor.

            DataTable dt = new DataTable();//içerisinde tablo tutan bir yapıdır
            adp.Fill(dt);//DataTable'a verileri doldur.

            dataGridView1.DataSource = dt;//yukarıda dolan tabloyu(dt'yi) dataGridView'de görüntülemek için bu şekilde atadık.

            //dataGridView1 'deki aşağıdaki kolonları gizleyebiliriz.
            dataGridView1.Columns["UrunID"].Visible = false;
            dataGridView1.Columns["KategoriID"].Visible = false;
            dataGridView1.Columns["TedarikciID"].Visible = false;
        }

        private void bttnEkle_Click(object sender, EventArgs e)
        {
            string adi=txtUrunAdi.Text;
            decimal fiyat=nudFiyat.Value;
            decimal stok=nudStok.Value;
            if (adi=="" || fiyat==null|| stok==null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
                return;//direk metotdan(btnEkle_Click)'ten çık diyoruz.
            }

            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("insert Urunler(UrunAdi,Fiyat,Stok) values('{0}',{1},{2})", adi, fiyat, stok);//tek tırnak kullanmamızın sebebi string değer olduğunu belirttik yoksa hata veriyordu.
            komut.Connection = baglanti;

            baglanti.Open();

            //Not:select işleminde ExecuteReader kullanıyoruz,insert,update ve delete'de ExecuteNonQuery kullanacaz.
           int etkilenensatirsayisi=komut.ExecuteNonQuery();// komutu çalıştırıyor(insert komutu vermiştik)
            //etkilenensatirsayisi 0'dan büyük gelirse sorguda bir hata yoktur ve başarılı bir şekilde kayıt eklenmiştir anlamına geliyor.
           if (etkilenensatirsayisi>0)
           {
               MessageBox.Show("Ekleme başarılı");
               UrunListesi();
           }
           else
           {
               MessageBox.Show("Ekleme başarısız");
           }
            baglanti.Close();

        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            KategoriForm kf = new KategoriForm();
            kf.ShowDialog();
        }


        //hücre tıklandığında 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                 //datagridview'dan seçili satırı alma işlemi
          //  dataGridView1.CurrentRow;--seçili satır demek

            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();//.Cells koleksiyon olduğu için köşeli parantez açtık.
            txtUrunAdi.Tag = dataGridView1.CurrentRow.Cells["UrunID"].Value; //tag özelliği object alır kontrolün cebi gibi birşeydir.daha sonra bu değeri aşağıda kullanabilmek için değer atadık.

            nudFiyat.Value = (decimal)dataGridView1.CurrentRow.Cells["Fiyat"].Value;//objecti decimal'a cast ettik.

            nudStok.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Stok"].Value);//stok short tipinde olduğu için(veritabanında smallint'in karşılığı c#ta shorttur.oyüzden convert işlemi yaptık.)
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = string.Format("update Urunler set UrunAdi='{0}' , Fiyat={1} , Stok={2} where UrunID={3}", txtUrunAdi.Text, nudFiyat.Value, nudStok.Value, txtUrunAdi.Tag);

                komut.Connection = baglanti;

                baglanti.Open();

                int etkilenen = komut.ExecuteNonQuery();
                if (etkilenen > 0)
                {
                    MessageBox.Show("Kayıt Güncellendi");
                    UrunListesi();
                }
                else
                {
                    MessageBox.Show("Kayıt Güncellenemedi");
                }

                baglanti.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            finally //hata versede vermesede bu kod çalışır.
            {

                baglanti.Close();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)//doluysa(yani satır seçilmişse)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UrunID"].Value);

                SqlCommand cmd = new SqlCommand(string.Format("delete from Urunler where UrunID={0}",id),baglanti);
                baglanti.Open();

                int etkilenen = cmd.ExecuteNonQuery();
                if (etkilenen>0)
                {
                    MessageBox.Show("Kayıt silindi");
                    UrunListesi();
                }
                else
                {
                    MessageBox.Show("Kayıt silinemedi");
                }

                baglanti.Close();
                    
                    
            }
        }
    }
}
