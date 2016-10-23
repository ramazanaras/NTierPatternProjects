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
    public partial class OzelliklerForm : Form
    {
        public OzelliklerForm()
        {
            InitializeComponent();
        }
        OzelliklerORM ozl = new OzelliklerORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ozellikler ozz = new Ozellikler();
            ozz.Adi = txtAdi.Text;
            ozz.Aciklama = txtAciklama.Text;

            bool sonuc = ozl.Insert(ozz);
            if (sonuc)
            {
                MessageBox.Show("Kayıt eklenmiştir");
                dataGridView1.DataSource = ozl.Select();
            }
            else
            {
                MessageBox.Show("Kayıt ekleme başarısızdır");
            }
        }

        private void OzelliklerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ozl.Select();
        }
    }
}
