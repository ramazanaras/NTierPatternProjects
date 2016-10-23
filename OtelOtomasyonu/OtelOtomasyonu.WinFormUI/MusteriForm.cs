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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        MusteriORM orm = new MusteriORM();
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orm.Select();
            cmbMedeniDurum.DataSource = Enum.GetNames(typeof(MedeniDurumTip));//MedeniDurumTip enum'undaki değerleri string dizisi olarak dönderir.(yani içinde Bekar ve Evli değerleri var )

            cmbCinsiyet.DataSource = Enum.GetNames(typeof(Cinsiyet));//(içinde Erkek ve Kadın var)
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.Adi = txtAdi.Text;
            m.Soyadi = txtSoyadi.Text;
            m.SirketAdi = txtSirketAdi.Text;
            m.Tckn = mskdTckn.Text;
            m.TelNo = mskdTelefon.Text;
            m.DogumTarihi = dtpDogumTarihi.Value;
            m.MedeniDurum = (MedeniDurumTip)Enum.Parse(typeof(MedeniDurumTip), cmbMedeniDurum.SelectedItem.ToString());//Enum.Parse cmbMedeniDurum 'daki değeri(string bir değerdi=Evli yada Bekar) MedeniDurumTip'ine dönüştürür.Ensondada Parse metodu object döndürüyordu onuda MedeniDurumTip olarak cast ettik.

            m.Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString());

            bool sonuc = orm.Insert(m);
            if (sonuc)
            {
                dataGridView1.DataSource = orm.Select();
                MessageBox.Show("Müşteri Eklenmiştir");
            }
            else
            {
                MessageBox.Show("Müşteri ekleme sırasında hata oluştu");
            }
        }
    }
}
