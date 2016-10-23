using ResimGalerisi.ORM.Entity;
using ResimGalerisi.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimGalerisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Products.Listele();
        }

        //hücre seçildiği anda
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;//bir satır seçilmemişse direk metottan çık.

            int id = (int)dataGridView1.CurrentRow.Cells["ProductId"].Value;//seçili satırın idsini aldık.

            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpg|*.jpg|Png|*.png";
           DialogResult sonuc= openFileDialog1.ShowDialog();

           if (sonuc==DialogResult.OK)
           {
               //openFileDialog1.FileName seçilen dosyanın bulunduğu konumu verir.
               FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);//FileStream dosyayı okumayı sağlıyor.

               //okunan dosyayı byte[] dizisine dönüştürmemiz lazım
               BinaryReader br = new BinaryReader(fs);//bizde Stream tipinde değer istiyor.FileStreamde Stream sınıfından miras aldığı için fs'yi verebiliriz.

               byte[] resim = br.ReadBytes((int)fs.Length);//dosyayı boyutu kadar oku byte[] dizisine dönüştür.yani openfiledialog1 'den seçmiş olduğumuz resmi byte dizisine dönüştürdük.
               br.Close();
               fs.Close();



               ProductPicture pp = new ProductPicture();
               pp.ProductID = id;
               pp.Picture = resim; //byte dizisi verdik.
               if (ProductPictures.Ekle(pp))
               {
                   dataGridView1.DataSource = Products.Listele();
                   MessageBox.Show("Ürüne resim ekleme başarılı");
               }
               else
               {
                   MessageBox.Show("Ürüne resim ekleme başarısız.");
               }

           }

        }

        private void resimleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;//bir satır seçilmemişse direk metottan çık.


            int id =(int) dataGridView1.CurrentRow.Cells["ProductId"].Value;

            ResimlerForm rf = new ResimlerForm();
            rf.ProducId = id;//idyi ResimlerForm'a yolladık
            rf.ShowDialog();

        }
    }
}
