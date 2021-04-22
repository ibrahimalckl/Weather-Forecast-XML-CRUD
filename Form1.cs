using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Net;

namespace havadurumu_ia
{
    public partial class fHavaDurumu : Form
    {
        public fHavaDurumu()
        {
            InitializeComponent();
        }

        private void fHavaDurumu_Load(object sender, EventArgs e)
        {

        }

        private void bYaz_Click(object sender, EventArgs e)
        {
            string xmlDosya = "sonSOA.xml";
            XmlTextReader veri = new XmlTextReader(xmlDosya);

            while (veri.Read())
            {
                lVeri.Items.Add(veri.Name);
            }
        }

        private void bDownload_Click(object sender, EventArgs e)
        {
            indir();
        }

        private void indir()
        {
            string uzakBaglanti = "https://www.mgm.gov.tr/FTPDATA/analiz/";
            string dosyaAdi = "sonSOA.xml", xmlVeri = null;

            WebClient Site = new WebClient();

            xmlVeri = uzakBaglanti + dosyaAdi;

            Site.DownloadFile(xmlVeri, dosyaAdi);
        }
    }
}
