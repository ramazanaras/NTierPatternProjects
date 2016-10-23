using KuzeyYeli.ORM.Entity;
using KuzeyYeli.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYeli.WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KategoriListele()
        {
            dataGridView1.DataSource = Kategoriler.Select();
            dataGridView1.Columns["KategoriID"].Visible = false;//KategoriID kolonunu gizledik.

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategori ktg = new Kategori();
            ktg.KategoriAdi = txtAdi.Text;
            ktg.Tanimi = txtTanim.Text;

            bool sonuc = Kategoriler.Insert(ktg);

            if (sonuc)
            {
                MessageBox.Show("Kayıt başarılı bir şekilde eklenmiştir");
                KategoriListele();
            }
            else
            {
                MessageBox.Show("Kayıt eklerken hata meydana geldi.");
            }
        }
    }
}
