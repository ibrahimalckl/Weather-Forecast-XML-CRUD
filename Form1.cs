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
using System.IO;

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

        public string eskiDosya = @"sonSOA.xml";
        public string yeniDosya = @"GuncelHavaDurumu.xml";
        public string karsilastirmaDosyasi = @"karsilastirma.xml";
        private void bYaz_Click(object sender, EventArgs e)
        {
            karsilastirma();
        }      
        private void bDownload_Click(object sender, EventArgs e)
        {
            indir();
            xmlKopyalama();
        }    
        private void indir()
        {
            string uzakBaglanti = "https://www.mgm.gov.tr/FTPDATA/analiz/";
            string dosyaAdi = "sonSOA.xml", xmlVeri = null;

            WebClient Site = new WebClient();

            xmlVeri = uzakBaglanti + dosyaAdi;

            Site.DownloadFile(xmlVeri, dosyaAdi);
        }
        private void xmlKopyalama()
        {
            XmlDocument dosya = new XmlDocument();
            dosya.Load(eskiDosya);

            if (File.Exists(yeniDosya))
            {
                File.Delete(yeniDosya);        
            }
            dosya.Save(yeniDosya);
            dosya.Save(karsilastirmaDosyasi);

        }
        private void karsilastirma()
        {
            FileStream ksAc = new FileStream(karsilastirmaDosyasi, FileMode.Open, FileAccess.Read);
            StreamReader Oku = new StreamReader(ksAc, Encoding.Default);
            string Okunan = "";

            FileStream ydAc = new FileStream(yeniDosya, FileMode.Open, FileAccess.Read);
            StreamReader Oku2 = new StreamReader(ydAc, Encoding.Default);
            string Okunan2 = "";

            while (!Oku.EndOfStream)
            {            
                Okunan += Oku.ReadLine() + "";                          
            }

            while (!Oku2.EndOfStream)
            {               
                Okunan2 += Oku2.ReadLine() + "";
            }

            if (Okunan == Okunan2)
            {
                MessageBox.Show("esit");
            }
            else
            {
                MessageBox.Show("degil");
            }

            Oku.Close();
            Oku2.Close();

        }


    }
}
