using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;//Xml kütüphanesini ekledik.

namespace XmlOkuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            //doc nesnesine verdiğimiz path'deki(yol) xml dosyasını okuyor ve doc nesnesine bilgileri aktarıyor.
           // doc.Load("Haberler.xml");//Sadece xml dosyası ismi ile çekmek istiyorsak Xml dosyası projenin exe dosyası ile aynı klasörde yani debug klasöründe olmalı.


            doc.Load("..\\..\\Haberler.xml");//iki üst klasöre çık ordaki  Haberler.xml dosyası var git onu diyoruz.( debug klasörünü referans olarak  alıyoruz.).yani bu projenin exe dosyasının bulunduğu klasörden iki üst klasöre çık  o klasörde Haberler.xml var diyoruz.

            //Select Single Node bir tane düğüm seçer.
           XmlNode haberler= doc.SelectSingleNode("haberler");//haberler node u tek bir tane olduğu için SelectSingle Node ile seçtik.

           this.Text = haberler.SelectSingleNode("baslik").InnerText;//haberler node'undaki baslik node'u al ve içindeki değeri oku dedik.formun başlığını değiştirdik.


           lblAciklama.Text = string.Format("{0}-{1}", haberler.SelectSingleNode("aciklama").InnerText, haberler.SelectSingleNode("tarih").InnerText);




           XmlNodeList haberlist = haberler.SelectNodes("haber");//haberler node'una git içinde bir sürü haber node'u var ve onları seç  dedik. SelectNodes geriye bir NodeList dönderir.

           foreach (XmlNode haber in haberlist)
           {
               listBasliklar.Items.Add(haber.SelectSingleNode("baslik").InnerText);//herbir haber node'unun içinde bir tane baslik node'u var onun içindeki değeri oku dedik.
           }


        }

        private void listBasliklar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string baslik = listBasliklar.SelectedItem.ToString();//listboxtaki seçili baslik'i aldık


            XmlDocument doc = new XmlDocument();

            doc.Load("..\\..\\Haberler.xml");

            XmlNode haberler = doc.SelectSingleNode("haberler");

            XmlNodeList haberlist = haberler.SelectNodes("haber");//haber nodeları çek dedik.


            foreach (XmlNode hbr in haberlist)
            {
                string bsl = hbr.SelectSingleNode("baslik").InnerText;//haber node'unun içindeki baslik node'unun içindeki yazıyı al.

                if (bsl==baslik)
                {
                    listAciklamalar.Items.Add(hbr.SelectSingleNode("aciklama").InnerText);
                }


            }

        }
    }
}
