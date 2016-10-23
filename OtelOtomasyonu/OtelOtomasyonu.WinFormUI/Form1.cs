using OtelOtomasyonu.ORM.Entity;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kasaHareketToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        BirimTipForm bt = new BirimTipForm();
        private void birimTipleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //tekrar tıklayınca formu açmayı engellemek için 
            if (bt.IsDisposed)//ramden kaldırılmışsa tekrar new'le aç
            {
                bt = new BirimTipForm();
            }
            bt.MdiParent = this;
            bt.Show();
        }
        KasaForm kf = new KasaForm();
        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tekrar tıklayınca formu açmayı engellemek için 
            if (kf.IsDisposed)//ramden kaldırılmışsa tekrar new'le aç
            {
                kf = new KasaForm();
            }
            kf.MdiParent = this;
            kf.Show();
        }
        KategoriForm ktg = new KategoriForm();
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ktg.IsDisposed)
            {
                ktg = new KategoriForm();
            }
            ktg.MdiParent = this;
            ktg.Show();
        }
        UrunForm uf = new UrunForm();
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (uf.IsDisposed)
            {
                uf = new UrunForm();
            }
            uf.MdiParent = this;
            uf.Show();
        }
        OdaTurleriForm ot = new OdaTurleriForm();
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ot.IsDisposed)
            {
                ot = new OdaTurleriForm();
            }
            ot.MdiParent = this;
            ot.Show();
        }
        OdalarForm of = new OdalarForm();
        private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (of.IsDisposed)
            {
                of = new OdalarForm();
            }
            of.MdiParent = this;
            of.Show();
        }
        OdaOzellikForm ozellikForm = new OdaOzellikForm();
        private void odaÖzellikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ozellikForm.IsDisposed)
            {
                ozellikForm = new OdaOzellikForm();
            }
            ozellikForm.MdiParent = this;
            ozellikForm.Show();
        }

        OzelliklerForm ozf = new OzelliklerForm();
        private void özelliklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ozf.IsDisposed)
            {
                ozf = new OzelliklerForm();
            }
            ozf.MdiParent = this;
            ozf.Show();
        }
        MusteriForm mf = new MusteriForm();
        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mf.IsDisposed)
            {
                mf = new MusteriForm();
            }
            mf.MdiParent = this;
            mf.Show();
        }
        PersonellerForm pf = new PersonellerForm();
        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pf.IsDisposed)
            {
                pf = new PersonellerForm();
            }
            pf.MdiParent = this;
            pf.Show();
        }
        SatisForm sf = new SatisForm();
        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sf.IsDisposed)
            {
                sf = new SatisForm();
            }
            sf.MdiParent = this;
            sf.Show();
        }
    }
}
