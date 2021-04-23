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
using System.Timers;

namespace havadurumu_ia
{
    public partial class fHavaDurumu : Form
    {
        public fHavaDurumu()
        {
            InitializeComponent();
        }
        
        public string yeniDosya = @"sonSOA.xml";
        public string eskiDosya = @"GuncelHavaDurumu.xml";
        public string karsilastirmaDosyasi = @"karsilastirma.xml";
        private void fHavaDurumu_Load(object sender, EventArgs e)
        {
            timer1.Start();

            
            if (File.Exists(yeniDosya) == false)
            {
               indir();
               xmlKopyalama();
            }
        }      
        private void bYaz_Click(object sender, EventArgs e)
        {
            if (File.Exists(eskiDosya) && File.Exists(karsilastirmaDosyasi))
            {
                xmlKopyalama();
                karsilastirma();           
            }
            
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
            dosya.Load(yeniDosya);
            dosya.Save(karsilastirmaDosyasi);

            if (File.Exists(eskiDosya) == false)
            {
               dosya.Save(eskiDosya);
            }                            
            //else if (File.Exists(eskiDosya))
            //{
            //    karsilastirma();
            //}
                      
        }
        private void karsilastirma()
        {
            XmlDocument dosya = new XmlDocument();

            FileStream ksAc = new FileStream(karsilastirmaDosyasi, FileMode.Open, FileAccess.Read);
            StreamReader Oku = new StreamReader(ksAc, Encoding.Default);
            string Okunan = "";

            FileStream edAc = new FileStream(eskiDosya, FileMode.Open, FileAccess.Read);
            StreamReader Oku2 = new StreamReader(edAc, Encoding.Default);
            string Okunan2 = "";

            while (!Oku.EndOfStream)
            {            
                Okunan += Oku.ReadLine() + "";                          
            }

            while (!Oku2.EndOfStream)
            {               
                Okunan2 += Oku2.ReadLine() + "";
            }          
            
            Oku.Close();
            Oku2.Close();

            if (Okunan == Okunan2)
            {
                MessageBox.Show("esit");
            }
            else
            {
                MessageBox.Show("degil");
                
                dosya.Load(karsilastirmaDosyasi);
                dosya.Save(eskiDosya);
            }
                
        }
        private void lTarih_Click(object sender, EventArgs e)
        {
            lTarih.Text = DateTime.Now.ToLongDateString();
        }
        private void lSaat_Click(object sender, EventArgs e)
        {
            lSaat.Text = DateTime.Now.ToLongTimeString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lTarih.Text = DateTime.Now.ToLongDateString();
            lSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
