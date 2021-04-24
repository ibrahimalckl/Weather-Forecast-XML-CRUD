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
             
        public string guncelDosya = @"GuncelHavaDurumu.txt";      
        public int sayac;
        private void fHavaDurumu_Load(object sender, EventArgs e)
        {
            timer1.Start();
                          
            if (File.Exists(guncelDosya) == false)
            {
                baslangic();
            }
        }
        private void bYaz_Click(object sender, EventArgs e)
        {       

            DataSet veri = new DataSet();
            veri.ReadXml(@"GuncelHavaDurumu.txt");
            dVeri.DataSource = veri.Tables[1];

        }
        private void bDownload_Click(object sender, EventArgs e)
        {
            if (File.Exists(guncelDosya) == false)
            {
                baslangic();
                MessageBox.Show("Başarıyla indirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string url = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";

                WebRequest istek = HttpWebRequest.Create(url);
                WebResponse cevap = istek.GetResponse();
                StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());

                List<string> veri = new List<string>();

                veri.Add(donenBilgiler.ReadToEnd());
                File.WriteAllLines(@"GuncelHavaDurumu.txt", veri);

                MessageBox.Show("Başarıyla indirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }
        private void bGuncelleme_Click(object sender, EventArgs e)
        {
            karsilastirma();
        }
        //private void indir()
        //{
        //    string uzakBaglanti = "https://www.mgm.gov.tr/FTPDATA/analiz/";
        //    string dosyaAdi = "sonSOA.xml", xmlVeri = null;

        //    WebClient Site = new WebClient();

        //    xmlVeri = uzakBaglanti + dosyaAdi;

        //    Site.DownloadFile(xmlVeri, dosyaAdi);
        //}
        //private void xmlKopyalama()
        //{
        //    XmlDocument dosya = new XmlDocument();
        //    dosya.Load(yeniDosya);
        //    dosya.Save(karsilastirmaDosyasi);

        //    if (File.Exists(eskiDosya) == false)
        //    {
        //       dosya.Save(eskiDosya);
        //    }                                              
        //}
        //private void karsilastirma()
        //{
        //    XmlDocument dosya = new XmlDocument();

        //    FileStream ksAc = new FileStream(karsilastirmaDosyasi, FileMode.Open, FileAccess.Read);
        //    StreamReader Oku = new StreamReader(ksAc, Encoding.Default);
        //    string Okunan = "";

        //    FileStream edAc = new FileStream(eskiDosya, FileMode.Open, FileAccess.Read);
        //    StreamReader Oku2 = new StreamReader(edAc, Encoding.Default);
        //    string Okunan2 = "";

        //    while (!Oku.EndOfStream)
        //    {            
        //        Okunan += Oku.ReadLine() + "";                          
        //    }

        //    while (!Oku2.EndOfStream)
        //    {               
        //        Okunan2 += Oku2.ReadLine() + "";
        //    }          
            
        //    Oku.Close();
        //    Oku2.Close();

        //    if (Okunan == Okunan2)
        //    {
        //        MessageBox.Show("Verileriniz güncel.", "Bilgilendirme", MessageBoxButtons.OK ,MessageBoxIcon.Information);
        //    }
        //    else if(MessageBox.Show("Verileriniz güncel değil. Güncellemek ister misiniz?", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        //    {
        //        indir();
        //        xmlKopyalama();
        //        dosya.Load(karsilastirmaDosyasi);
        //        dosya.Save(eskiDosya);
        //    }
                
        //}
        //private void karsilastirma2()
        //{
        //    XmlDocument dosya = new XmlDocument();

        //    FileStream ksAc = new FileStream(karsilastirmaDosyasi, FileMode.Open, FileAccess.Read);
        //    StreamReader Oku = new StreamReader(ksAc, Encoding.Default);
        //    string Okunan = "";

        //    FileStream edAc = new FileStream(eskiDosya, FileMode.Open, FileAccess.Read);
        //    StreamReader Oku2 = new StreamReader(edAc, Encoding.Default);
        //    string Okunan2 = "";

        //    while (!Oku.EndOfStream)
        //    {
        //        Okunan += Oku.ReadLine() + "";
        //    }

        //    while (!Oku2.EndOfStream)
        //    {
        //        Okunan2 += Oku2.ReadLine() + "";
        //    }

        //    Oku.Close();
        //    Oku2.Close();

        //    if (Okunan != Okunan2)
        //    {
        //        if (MessageBox.Show("Verileriniz güncel değil. Güncellemek ister misiniz?", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        //        {
        //        indir();
        //        xmlKopyalama();
        //        dosya.Load(karsilastirmaDosyasi);
        //        dosya.Save(eskiDosya);
        //        }
        //    }
            
        //}
        private void lTarih_Click(object sender, EventArgs e)
        {
            lTarih.Text = DateTime.Now.ToLongDateString();
        }
        private void lSaat_Click(object sender, EventArgs e)
        {
            lSaat.Text = DateTime.Now.ToLongTimeString();     
        }
        private void lSayac_Click(object sender, EventArgs e)
        {        
            lSayac.Text = DateTime.Now.Second.ToString("");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lTarih.Text = DateTime.Now.ToLongDateString();
            lSaat.Text = DateTime.Now.ToLongTimeString();
            lSayac.Text = DateTime.Now.Second.ToString("");         
                        
            if (lSayac.Text == "10")
            {                
                sayac++;
                
                if (sayac == 5)
                {                   
                    karsilastirma();                    
                    sayac = 0;
                }
            }
            
        }
        public void baslangic()
        {
            string url = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";

            WebRequest istek = HttpWebRequest.Create(url);
            WebResponse cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());

            List<string> veri = new List<string>();

            veri.Add(donenBilgiler.ReadToEnd());

            FileStream fs = File.Create(guncelDosya);
            fs.Close();
            File.WriteAllLines(@"GuncelHavaDurumu.txt", veri);
        }     
        private void karsilastirma()
        {   
            string url = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";

            WebRequest istek = HttpWebRequest.Create(url);
            WebResponse cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());

            List<string> veri = new List<string>();
            veri.Add(donenBilgiler.ReadToEnd());
        
            List<string> gnclDosya = new List<string>();
            gnclDosya = File.ReadAllLines(guncelDosya).ToList();         

            if (gnclDosya[0] == veri[0])
            {
                MessageBox.Show("Verileriniz güncel.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Verileriniz güncel değil. Güncellemek ister misiniz?", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                File.WriteAllLines(@"GuncelHavaDurumu.txt", veri);
            }
        }
    }
}
