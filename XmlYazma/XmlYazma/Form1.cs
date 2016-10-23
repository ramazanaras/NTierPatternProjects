using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;//Xml kütüphanesini ekledik.

namespace XmlYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //kullanacağımız Xml sınıfını oluşturduk.
        XmlDocument xml = new XmlDocument();
        XmlElement filmler;
        private void Form1_Load(object sender, EventArgs e)
        {
           

            
            //Debug klasörünün içine bakacak böyle bir dosyanın olup olmadığına 
            if (!File.Exists("Filmler.xml"))//böyle bir dosya yoksa 
            {

                filmler = xml.CreateElement("filmler");//filmler elementi oluşturduk

                //fimler düğümünü ana düğüm olarak ekledik.
                xml.AppendChild(filmler);//Appenchild içerisine XmlNode tipinde değer alır ama biz XmlElement tipinde değer verdik.nasıl oldu bu.şöyle oldu XmlElement tipi XmlNode tipinden miras aldığı için bir sorun çıkmaz.


            }
            else//Dosya varsa
            {
                xml.Load("Filmler.xml");//xml dosyasını okur.

                //ilk node'u okuduk(ana node'u)
                filmler = (XmlElement)xml.SelectSingleNode("filmler");//cast ettik.//SelectSingleMode XmlNode tipinde bir değer dönderir.XmlElementte XmlNode'dan miras aldığı için XmlNode'u XmlElement'e cast edebiliriz.



                
                //BURDADA LİSTVİEW'E XMLDEKİ VERİLERİ YAZDIRIYORUZ

                XmlNodeList film = filmler.SelectNodes("film");//filmler node'unun içinde birden çok film node'u vardır.aşağıdada foreachle gezdik içinde.

                foreach (XmlNode f in film)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = f.Attributes["adi"].Value;//filmin adi attribute'nun değerini getir dedik.//ilk kolon //f.Attributes XmlAttributeCollection'dur yani içinde birçok XmlAttribute tipinde değer vardır.bizde koleksiyon olduğu için köşeli parantez [] ile değerini aldık.
                    lvi.SubItems.Add(f.Attributes["turu"].Value);//ikinci kolon
                    lvi.SubItems.Add(f.Attributes["yili"].Value);
                    lvi.SubItems.Add(f.Attributes["yonetmen"].Value);
                    lvi.SubItems.Add(f.Attributes["imdb"].Value);

                    listView1.Items.Add(lvi);//listView1 içersine ListViewItem tipinde değer alıyordu bizde değeri verdik.
                }


            }




        }
        
        private void btnFilmEkle_Click(object sender, EventArgs e)
        {

            //Not:attribute'un içine değer atamak istersek value kullanırız.elementin içine değer atayabilmek içinse inner text kullanırız.

            XmlElement film = xml.CreateElement("film");//film isminde bir node(dugum veya tag) olustur.

            XmlAttribute adi = xml.CreateAttribute("adi");//attribute oluşturduk 
            adi.Value = txtFilmAdi.Text;//Kuzuların sessizliği
            film.Attributes.Append(adi);//<film adi="Kuzuların Sessizligi"> </film>  


            XmlAttribute filmTuru = xml.CreateAttribute("turu");//attribute oluşturduk 
            filmTuru.Value = cmbFilmTuru.Text;//Macera
            film.Attributes.Append(filmTuru);//<film adi="Kuzuların Sessizligi" turu="Macera"> </film>  



            XmlAttribute yili = xml.CreateAttribute("yili");//attribute oluşturduk 
            yili.Value = dtpYapimYili.Value.Year.ToString();//1998
            film.Attributes.Append(yili);//<film adi="Kuzuların Sessizligi" turu="Macera" yili="1998"> </film> 



            XmlAttribute yonetmen = xml.CreateAttribute("yonetmen");//attribute oluşturduk 
            yonetmen.Value = txtYonetmen.Text;//Ramazan Aras
            film.Attributes.Append(yonetmen);//<film adi="Kuzuların Sessizligi" turu="Macera" yili="1998" yonetmen="Ramazan Aras"> </film> 


            XmlAttribute imdb = xml.CreateAttribute("imdb");//attribute oluşturduk 
            imdb.Value = txtImdbPuani.Text;//9.5
            film.Attributes.Append(imdb);//<film adi="Kuzuların Sessizligi" turu="Macera" yili="1998" yonetmen="Ramazan Aras" imdb="9.5"> </film> 


            //yeni bir element oluşturduk
            XmlElement oyuncular = xml.CreateElement("oyuncular");
            foreach (string oyuncu in listOyuncular.Items)//listOyuncular.Items içinde obje tipinde değerler barındıran bir koleksiyondur.
            {
                XmlElement o = xml.CreateElement("oyuncu");
                o.InnerText = oyuncu;

                oyuncular.AppendChild(o);//oyuncular elementinin içine o elementini ekle.(çoçuk olarak ekle.)


                /*
                 <oyuncular>
                 
                 * <oyuncu></oyuncu>
                 * <oyuncu></oyuncu>
                 * 
                 * 
                 </oyuncular>
                 
                 */
            }


            film.AppendChild(oyuncular);//film elementinin içine oyuncular elementini ekle.(çoçuk olarak ekle.)

            /*
             * <film>
                   <oyuncular>
                 
                   * <oyuncu></oyuncu>
                   * <oyuncu></oyuncu>
                   * 
                   * 
                   </oyuncular>
              </film>
               */


            filmler.AppendChild(film);//filmler ana düğümünede film attribute'nu ekle dedik.son hali aşağıda.



            /*
            * <filmler>
             * 
             *     <film  adi="Kuzuların Sessizligi" turu="Macera" yili="1998" yonetmen="Ramazan Aras" imdb="9.5">
                      <oyuncular>
                 
                          * <oyuncu></oyuncu>
                          * <oyuncu></oyuncu>
                      * 
                      * 
                      </oyuncular>
                   </film>     
             * 
             *      <film  adi="Kuzuların Sessizligi" turu="Macera" yili="1998" yonetmen="Ramazan Aras" imdb="9.5">
                      <oyuncular>
                 
                          * <oyuncu></oyuncu>
                          * <oyuncu></oyuncu>
                      * 
                      * 
                      </oyuncular>
                   </film>  
             * 
             * </filmler>
              */

            xml.Save("Filmler.xml");//xml'i Filmler.xml'e kaydet.////verdiğimiz dosya yoluna xml dosyasını oluşturacak.
        }

        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            listOyuncular.Items.Add(txtOyuncuAdi.Text);
            txtOyuncuAdi.Text = "";
        }

        private void btnDbToXml_Click(object sender, EventArgs e)
        {
            DbToXmlForm form = new DbToXmlForm();
            form.ShowDialog();
        }
    }
}
