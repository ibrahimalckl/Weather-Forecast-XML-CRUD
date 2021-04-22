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

namespace havadurumu_ia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bYaz_Click(object sender, EventArgs e)
        {
            string xmlDosya = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
            XmlTextReader veri = new XmlTextReader(xmlDosya);

            while (veri.Read())
            {
                lVeri.Items.Add(veri.Name);
            }
        }

    }
}
