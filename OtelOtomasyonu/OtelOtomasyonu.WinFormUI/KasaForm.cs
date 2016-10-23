using OtelOtomasyonu.ORM.Entity;//references kısmına OtelOtomasyonu.ORM 'i ekleme yaptık.daha sonra burdaki kodu yazdık
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
    public partial class KasaForm : Form
    {
        public KasaForm()
        {
            InitializeComponent();
        }

        KasaORM kOrm = new KasaORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //references kısmına OtelOtomasyonu.ORM 'i ekleme yaptık.
            Kasa k = new Kasa();
            k.Adi = txtAdi.Text;
            k.Aciklama = txtAciklama.Text;


            bool sonuc = kOrm.Insert(k);

            if (sonuc)//sonuc==true 'da diyebilirdik.
            {
                MessageBox.Show("Kasa Ekleme Başarılı");
                dataGridView1.DataSource = kOrm.Select();//Select'ten dönen dtyi verdik.
            }
            else
            {
                MessageBox.Show("Kasa Ekleme Başarısız");
            }

        }

        private void KasaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kOrm.Select();//Select'ten dönen dtyi verdik.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////silme
            Kasa k = new Kasa();
            k.Id = 10;

            bool sonuc = kOrm.Delete(k);
            if (sonuc)//sonuc==true 'da diyebilirdik.
            {
                MessageBox.Show("Kasa silme Başarılı");
                dataGridView1.DataSource = kOrm.Select();//Select'ten dönen dtyi verdik.
            }
            else
            {
                MessageBox.Show("Kasa silme Başarısız");
            }

        }
    }
}
