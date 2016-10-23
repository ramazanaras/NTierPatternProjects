using ResimGalerisi.ORM.Facade;
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

namespace ResimGalerisi
{
    public partial class ResimlerForm : Form
    {
        public ResimlerForm()
        {
            InitializeComponent();
        }

        public int ProducId { get; set; }//form1den gelen veriyi alacaz

        DataTable ResimDoldur()
        {
            DataTable dt = ProductPictures.Listele(ProducId);//ürünidsine göre ProductPicture tablosundaki verileri aldık.

            return dt;
        }

        private void ResimlerForm_Load(object sender, EventArgs e)
        {

            DataTable dt = ResimDoldur();
            
            foreach (DataRow item in dt.Rows)//satırlarda gez.
            {
                //cast ettik.
                byte[] resim = (byte[])item.ItemArray[2];//3.kolonu al dedik.(yani byte[] dizisinin olduğu kolon) . byte[] resim=item[2] böylede yapılabilirdi.

                //byte[] dizisini tekrardan resme çevirmemiz gerekiyor.
                MemoryStream ms = new MemoryStream(resim, 0, resim.Length);//o'dan başla resim'in(byte[] dizisinin) boyutuna kadar oku.

                ms.Write(resim, 0, resim.Length);//o'dan başla resim'in(byte[] dizisinin) boyutuna kadar yaz.
                Image img = Image.FromStream(ms);//byte[] dizisinden resmi elde etmiş olduk artık.

                pictureBox1.BackgroundImage = img;//img'yi picturebox'a veriyoruz.

                //resmi yay.
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;// pictureBox1.BackgroundImageLayout bizden ImageLayout tipinde değer istiyordu bizde ImageLayout.Stretch bunu verdik. (ImageLayout sarı renkli yani bir enumdur.)


                pictureBox1.Tag = item.ItemArray[0];//item.ItemArray[0] id tutuyordu.//yani her bir resme bir id verdik.

                return;

            }
          

        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            int id = (int)pictureBox1.Tag;//yukarıdaki tag 

            DataTable dt = ResimDoldur();

            id++;
            foreach (DataRow item in dt.Rows)
            {
                //ilk kolondaki  id ile gelen yukarıdaki id eşitmi diye bakar.
                if ((int)item.ItemArray[0]==id)//bir sonraki resmi gösterebilmek için.
                {
                    //cast ettik.
                byte[] resim = (byte[])item.ItemArray[2];//3.kolonu al dedik.(yani byte[] dizisinin olduğu kolon) . byte[] resim=item[2] böylede yapılabilirdi.

                //byte[] dizisini tekrardan resme çevirmemiz gerekiyor.
                MemoryStream ms = new MemoryStream(resim, 0, resim.Length);//o'dan başla resim'in(byte[] dizisinin) boyutuna kadar oku.

                ms.Write(resim, 0, resim.Length);//o'dan başla resim'in(byte[] dizisinin) boyutuna kadar yaz.
                Image img = Image.FromStream(ms);//byte[] dizisinden resmi elde etmiş olduk artık.

                pictureBox1.BackgroundImage = img;//img'yi picturebox'a veriyoruz.

                //resmi yay.
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;// pictureBox1.BackgroundImageLayout bizden ImageLayout tipinde değer istiyordu bizde ImageLayout.Stretch bunu verdik. (ImageLayout sarı renkli yani bir enumdur.)


                pictureBox1.Tag = item.ItemArray[0];//item.ItemArray[0] id tutuyordu.

                return;
                }
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            int id = (int)pictureBox1.Tag;

            DataTable dt = ResimDoldur();

            id--;

            foreach (DataRow item in dt.Rows)
            {
                if ((int)item.ItemArray[0]==id)
                {
                    //cast ettik.
                byte[] resim = (byte[])item.ItemArray[2];//3.kolonu al dedik.(yani byte[] dizisinin olduğu kolon) . byte[] resim=item[2] böylede yapılabilirdi.

                //byte[] dizisini tekrardan resme çevirmemiz gerekiyor.
                MemoryStream ms = new MemoryStream(resim, 0, resim.Length);//o'dan başla resim'in(byte[] dizisinin) boyutuna kadar oku.

                ms.Write(resim, 0, resim.Length);//o'dan başla resim'in(byte[] dizisinin) boyutuna kadar yaz.
                Image img = Image.FromStream(ms);//byte[] dizisinden resmi elde etmiş olduk artık.

                pictureBox1.BackgroundImage = img;//img'yi picturebox'a veriyoruz.

                //resmi yay.
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;// pictureBox1.BackgroundImageLayout bizden ImageLayout tipinde değer istiyordu bizde ImageLayout.Stretch bunu verdik. (ImageLayout sarı renkli yani bir enumdur.)


                pictureBox1.Tag = item.ItemArray[0];//item.ItemArray[0] id tutuyordu.

                return;
                }
            }
        }
    }
}
