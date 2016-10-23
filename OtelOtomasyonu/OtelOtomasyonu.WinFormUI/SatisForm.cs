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
    public partial class SatisForm : Form
    {
        public SatisForm()
        {
            InitializeComponent();
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            MusteriORM mOrm = new MusteriORM();
            cmbMusteri.DataSource = mOrm.Select();
            cmbMusteri.DisplayMember = "Adi";//dışta görünen yazı
            cmbMusteri.ValueMember = "Id";//arkadaki değer

            OdalarORM odaOrm = new OdalarORM();
            cmbOda.DataSource = odaOrm.Select();
            cmbOda.DisplayMember = "Adi";
            cmbOda.ValueMember = "Id";

            UrunORM uOrm = new UrunORM();
            dataGridView1.DataSource = uOrm.Select();

        }

        private void btnSatisaEkle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow==null)//seçili bir satır yoksa
            {
                MessageBox.Show("Lütfen satışa eklemek istediğiniz ürünü seçiniz");
                return;//click eventini sonlandır
            }

            
            ListViewItem lvi = new ListViewItem();
            lvi.Text = (listView1.Items.Count + 1).ToString();//ilk kolon
            lvi.SubItems.Add(dataGridView1.CurrentRow.Cells["Adi"].Value.ToString());//ikinci kolon
            lvi.SubItems.Add(nudUrunMiktari.Value.ToString());
            lvi.SubItems.Add(nudUrunFiyati.Value.ToString());
            lvi.SubItems.Add(nudIndirim.Value.ToString());
            lvi.Tag = dataGridView1.CurrentRow.Cells["Id"].Value;//ürünün idsini tuttuk.(tag özelliği kontrolün cebi gibidir.daha sonra bu değeri kullanabiliriz..object tipinde değer alır.yani herşeyi içine atabiliriz.)
            listView1.Items.Add(lvi);

        
        
        
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SatisORM sOrm = new SatisORM();

            Satis s = new Satis();
            s.MusteriID = Convert.ToInt32(cmbMusteri.SelectedValue);//yukarıda  cmbMusteri.ValueMember = "Id"; yapmıştık değeri aldık.
            s.OdaID = Convert.ToInt32(cmbOda.SelectedValue);
            //satış yapan personelin idsini aldık.
            s.PersonelID = PersonellerORM.AktifKullanici.Id;//PersonellerORM sınfında static eleman tanımlamıştık.ve giriş yaptığımızda giriş yapan kullanıcının bilgilerini burada tutmuştuk.static olarak tanımladığımız için global olmuş oluyordu ve heryerden erişebilmeyi sağladık.burdada zaten eriştik ve değeri aldık.
            s.OdaFiyati = nudOdaFiyati.Value;
            s.SatisTarihi = DateTime.Now;//şu anki zaman

            int sId = Convert.ToInt32(sOrm.InsertScalar(s));
           // int sId = (int)sOrm.InsertScalar(s);//geriye dönen değer Satış Idsidir. Satış idsini elde ediyoruz(Insert Scalardaki ExecScalardan identity değerini elde ediyorduk.)
            if (sId>0)//Satış eklenmiştir o zamanda bu idyi(SatışId) kullanarak Satış detayı eklicez.
            {
                SatisDetayORM sdOrm = new SatisDetayORM();

                //listviewdeki değerleri alıyoruz.
                foreach (ListViewItem lvi in listView1.Items)//listView1.Items içinde ListViewItem tipinde eleman vardır.zaten listView1.Items 'in üzerine geline ListViewItemColection yazar.yani listView1.Items bir ListViewItemColection dizisidir.içinde ListViewItem tipinde değerleri barındırır.//listview'i satır satır okuyoruz işte.
                {
                    SatisDetay sd = new SatisDetay();
                    sd.SatisID = sId;//Satış detayın idsine Satış idsini verdik.
                    sd.UrunID = (int)lvi.Tag;//her lvi itemin tagına atmıştık(tag obje tuttugundan dolayı cast ettik.)
                    sd.Fiyat = Convert.ToDecimal(lvi.SubItems[3].Text);
                    sd.Miktar = Convert.ToDouble(lvi.SubItems[2].Text);
                    sd.Indirim = Convert.ToDouble(lvi.SubItems[4].Text);

                    sdOrm.Insert(sd);//her bir satış detayı veritabanına ekliyoruz.

                }



            }



        }
    }
}
