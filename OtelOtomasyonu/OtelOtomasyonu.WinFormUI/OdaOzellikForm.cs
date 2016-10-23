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
    public partial class OdaOzellikForm : Form
    {
        public OdaOzellikForm()
        {
            InitializeComponent();
        }
        
        private void OdaOzellikForm_Load(object sender, EventArgs e)
        {
            OdalarORM odaOrm = new OdalarORM();
            cmbOdalar.DataSource=odaOrm.Select();
            cmbOdalar.DisplayMember = "Adi";//görünen yazı
            cmbOdalar.ValueMember = "Id";//arka plandaki değer

            OzelliklerORM ozellikOrm = new OzelliklerORM();
            listOzellikler.DataSource = ozellikOrm.Select();
            listOzellikler.DisplayMember = "Adi";
            listOzellikler.ValueMember = "Id";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OdaOzellikleriORM odaOzelOrm = new OdaOzellikleriORM();

            OdaOzellikleri oz = new OdaOzellikleri();
            oz.OdaID = (int)cmbOdalar.SelectedValue;//objecti int'e cast ettik.
            oz.OzellikID = (int)listOzellikler.SelectedValue;//objecti int'e cast ettik.

            short deger;
            if (short.TryParse(txtDeger.Text,out deger))//parse etmeyi dene parse edebilirsen değer, deger değişkenine at
            {
                oz.Deger = deger;
            }
            //oz.Deger = Convert.ToInt16(txtDeger.Text); //short <-->int16 olarak çevrim yaptık

            bool sonuc = odaOzelOrm.Insert(oz);
            if (sonuc)
            {
                MessageBox.Show("Odaya seçilen özellik eklenmiştir.");
            
            }
            else
            {
                MessageBox.Show("Özellik atama sırasında bir hata oluştu");
            }
        }
    }
}
