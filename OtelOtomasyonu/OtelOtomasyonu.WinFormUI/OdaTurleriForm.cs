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
    public partial class OdaTurleriForm : Form
    {
        public OdaTurleriForm()
        {
            InitializeComponent();
        }
        OdaTurleriORM otOrm = new OdaTurleriORM();
        private void OdaTurleriForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = otOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OdaTurleri ot = new OdaTurleri 
            {
            Adi=txtAdi.Text,
            Aciklama=txtAciklama.Text,
            Aktif=true
            
            };

            bool sonuc = otOrm.Insert(ot);
            if (sonuc)
            {
                MessageBox.Show("Başarılı");
                dataGridView1.DataSource = otOrm.Select();
            }
            else
            {
                MessageBox.Show("Başarısız");
            }

        }
    }
}
