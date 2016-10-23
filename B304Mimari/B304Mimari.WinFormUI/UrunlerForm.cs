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
    public partial class UrunlerForm : Form
    {
        public UrunlerForm()
        {
            InitializeComponent();
        }
        UrunlerORM orm = new UrunlerORM();
        private void UrunlerForm_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = orm.Listele();//dtyi verdik.

            TedarikcilerORM tOrm = new TedarikcilerORM();
            cmbTedarikci.DataSource = tOrm.Listele();
            cmbTedarikci.DisplayMember = "SirketAdi";//dışta görünen değer
            cmbTedarikci.ValueMember = "TedarikciID";//arka plandaki değer

            KategoriORM kOrm=new KategoriORM();
            cmbKategori.DataSource=kOrm.Listele();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Urunler u=new Urunler();
            u.UrunAdi=txtUrunAdi.Text;
            u.Fiyat=nudFiyat.Value;
            u.Stok=Convert.ToInt16(nudStok.Value);
            u.KategoriID=(int)cmbKategori.SelectedValue;//object tipinde olduğu için cast işlemi  yaptık. //  cmbKategori.ValueMember = "KategoriID"; yapmıştık
            u.TedarikciID=(int)cmbTedarikci.SelectedValue;// cmbTedarikci.ValueMember = "TedarikciID" yapmıştık
            u.BirimdekiMiktar = "";//yoksa hata veriyordu.null değer veriyordu.bizde null değer vermesin diye boşluk verdik.
            orm.Ekle(u);
        }
    }
}
