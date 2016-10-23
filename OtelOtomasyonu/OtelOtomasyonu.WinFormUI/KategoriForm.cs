using OtelOtomasyonu.ORM.Entity;
using OtelOtomasyonu.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.WinFormUI
{
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }
        KategoriORM orm = new KategoriORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.Adi = textBox1.Text;
            bool sonuc = orm.Insert(k);

            if (sonuc)
            {
                MessageBox.Show("Kayıt eklenmiştir");
                dataGridView1.DataSource = orm.Select();
            }
            else
            {
                MessageBox.Show("Kategori Eklenirken hata oluştu!");
            }


        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orm.Select();
        }

       
    }
}
