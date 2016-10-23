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
    public partial class GirisYapForm : Form
    {
        public GirisYapForm()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            PersonellerORM orm = new PersonellerORM();
            Personeller p = new Personeller();
            p.KullaniciAdi = txtKullaniciAdi.Text;
            p.Parola = txtParola.Text;

            Personeller aktif = orm.GirisYap(p);//kullanıcı adı ve parola yanlışsa aktif=null olacak eğer doğru girilmişse aktif=giriş yapan kullanıcı olacak ve içinde bilgileri olacak.

            if (aktif==null)
            {
                MessageBox.Show("Kullanici Adı veya parola yanlış");
            }
            else//kullanıcı varsa(yani kullanıcı giriş yapabilmişsse)
            {
                PersonellerORM.AktifKullanici = aktif;//static olan değere(ortak bir yerde duran duran değere atadık..)
                Form1 f = new Form1();
                this.Hide();
                f.Show();

            }



        }
    }
}
