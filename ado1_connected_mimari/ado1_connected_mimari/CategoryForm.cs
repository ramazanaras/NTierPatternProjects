using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//Sqlconnection için bu kütüphaneyi ekledik.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado1_connected_mimari
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti=new SqlConnection("server=localhost;database=KuzeyYeli;Integrated Security=true");

            SqlCommand komut=new SqlCommand("select*from Kategoriler",baglanti);

            baglanti.Open();

            SqlDataReader rdr = komut.ExecuteReader();

            while (rdr.Read())
            {
                string adi = rdr["KategoriAdi"].ToString();
                string tanimi = rdr["Tanimi"].ToString();
                listBox1.Items.Add(String.Format("{0}-{1}",adi,tanimi));
            }

            baglanti.Close();
        }

    }
}
