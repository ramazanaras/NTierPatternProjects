using B304Mimari.Entity;
using B304Mimari.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B304Mimari.WinFormUI
{
    public partial class KategorilerForm : Form
    {
        public KategorilerForm()
        {
            InitializeComponent();
        }
        KategoriORM orm = new KategoriORM();
        private void KategorilerForm_Load(object sender, EventArgs e)
        {
            orm.Sil(18);
            dataGridView1.DataSource = orm.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.KategoriAdi = txtKategoriAdi.Text;
            k.Tanimi = txtTanimi.Text;
            k.Resim = new byte[0];//byte dizisi verdik.

            bool sonuc=orm.Ekle(k);
            if (sonuc)
            {
                MessageBox.Show("Kayıt eklenmiştir");
                dataGridView1.DataSource = orm.Listele();

            }
            else
            {
                MessageBox.Show("kayıt eklenirken hata meydana geldi");
            }
        }
    }
}
