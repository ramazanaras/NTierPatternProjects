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
    public partial class OdalarForm : Form
    {
        public OdalarForm()
        {
            InitializeComponent();
        }
        OdalarORM oOrm = new OdalarORM();
        OdaTurleriORM otOrm = new OdaTurleriORM();
        private void OdalarForm_Load(object sender, EventArgs e)
        {
            Listele();

            cmbOdaTuru.DataSource = otOrm.Select();//Select'ten gelen dtyi verdik.
            cmbOdaTuru.DisplayMember = "Adi";//dıştaki değer
            cmbOdaTuru.ValueMember = "Id";//arka plandaki değer


        }

        void Listele()
        {
            dataGridView1.DataSource = oOrm.Select();
        }
        //ekle butonu
        private void button1_Click(object sender, EventArgs e)
        {
            Odalar o = new Odalar();
            o.Aciklama = txtAciklama.Text;
            o.Adi = txtOdaAdi.Text;
            o.OdaTurID = (int)cmbOdaTuru.SelectedValue;//cast işlemi yaptık object tipini int'e çevirdik.//cmbOdaTuru.ValueMember = "Id"; yapmıştık.değeri burda kullanıyoruz

            bool sonuc = oOrm.Insert(o);
            if (sonuc)
            {
                MessageBox.Show("Oda Ekleme  işlemi başarılıdır.");
                Listele();
            }
            else
            {
                MessageBox.Show("Oda Ekleme  işlemi sırasında hata meydana geldi.");
            }

        }

    }
}
