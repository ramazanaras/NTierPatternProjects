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
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = Kategoriler.Select();//veri kaynağına dt yi verdik.dt içinde veriler barındırıyor. dataGridview1.datasource=dt diyorduk burdada comboba verdik bu kez.

            cmbKategori.DisplayMember = "KategoriAdi";//görünen değer
            cmbKategori.ValueMember = "KategoriID";//arka plandaki değer.


            cmbTedarikci.DataSource = Tedarikciler.Select();
            cmbTedarikci.DisplayMember = "SirketAdi";
            cmbTedarikci.ValueMember = "TedarikciID";

            dataGridView1.DataSource = Urunler.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunAdi = txtUrunAdi.Text;
            u.Fiyat = nudFiyat.Value;
            u.Stok = Convert.ToInt16(nudStok.Value); //short<-->int 16 çevirimi
            u.KategoriID = Convert.ToInt32(cmbKategori.SelectedValue);//cmbKategori.ValueMember = "KategoriID"; yapmıştık.seçilenin  değerini verir.
            u.TedarikciID = (int)cmbTedarikci.SelectedValue; //cast ettik yukarıdaki gibi convert olarak ta yapabilirdik.

            bool sonuc = Urunler.Insert(u);

            if (sonuc)//sonuc==true 'da diyebilirdik.
            {
                MessageBox.Show("Kayıt eklenmiştir");
                dataGridView1.DataSource = Urunler.Select();//listeyi yenile.
            }
            else
            {
                MessageBox.Show("Kayıt eklenirken hata meydana geldi");
            }

        }
    }
}
