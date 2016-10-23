using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlYazma
{
    public partial class DbToXmlForm : Form
    {
        public DbToXmlForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=localhost;Database=KuzeyYeli;Integrated Security=true;");

        private void btnUrunXml_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("prc_Urunler_Select",baglanti);
            cmd.CommandType = CommandType.StoredProcedure;//commandın tipini veriyoruz
            adp.SelectCommand = cmd;//adapterın commandına bizim oluşturduğumuz commandı veriyoruz.

            //Not:DataTable içine tek bir tablo tutar.
            //DataSet ise içine birden fazla tablo alır.içinde tablo listesi tutar.//Dataset ve DataTable 'ın  xml 'e yazdır diye bir özelliği var .

            DataSet ds = new DataSet();

            adp.Fill(ds,"Urunler");//ds'yi doldur vede içindeki tablo(datatable) ismi Urunler olsun dedik.tabloyu çağırırken bu isme göre çağırıcaz.

            ds.WriteXml("Urunler.xml");//ds'nin içindeki verileri xml'e yazdırdık.


        }

        private void btnTedarikciXml_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("select*from Tedarikciler",baglanti);
            
            adp.SelectCommand = cmd;
            
            DataSet ds = new DataSet();
            adp.Fill(ds, "Tedarikciler");

            ds.WriteXml("Tedarikciler.xml");

        }

        private void btnUrunlerListele_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Urunler.xml");

            dataGridView1.DataSource = ds.Tables["Urunler"];  //ds.Tables DataTableCollection dır yani içinde birçok datatable barındırır.bizde köşeli parantez [] diyerek vede içindeki datatable'ın ismini vererek içindeki datatable'ı aldık 
        }

        private void btnTedarikciListele_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Tedarikciler.xml");

            dataGridView1.DataSource = ds.Tables["Tedarikciler"];
        }
    }
}
