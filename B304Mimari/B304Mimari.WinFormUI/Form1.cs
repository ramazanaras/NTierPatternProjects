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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunlerForm uf = new UrunlerForm();
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tekrar tıklayınca formu açmayı engellemek için 
            if (uf.IsDisposed)//ramden kaldırılmışsa tekrar new'le aç
            {
                uf = new UrunlerForm();
            }
            uf.MdiParent = this;
            uf.Show();
        }
        KategorilerForm kf = new KategorilerForm();
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kf.IsDisposed)
            {
                kf = new KategorilerForm();
            }
            kf.MdiParent = this;
            kf.Show();
        }
    }
}
