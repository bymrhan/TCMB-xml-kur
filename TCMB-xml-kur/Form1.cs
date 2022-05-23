using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string TCMB_kur = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var TCMB_xml = new XmlDocument();
            String alış;
            String satış;
            
            if (comboBox1.Text == "USD - Amerikan Doları")
            { 
           
            TCMB_xml.Load(TCMB_kur);
            alış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexBuying").InnerXml;
            satış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
                label6.Text = alış;
                label7.Text = satış;
                label5.Text = comboBox1.SelectedItem.ToString();
                pictureBox2.ImageLocation = "https://www.merchantstronghold.com/currency/wp-content/uploads/2017/05/usd-1.png";
            }

            if (comboBox1.Text == "EUR - Euro")
            {
              
                TCMB_xml.Load(TCMB_kur);
                alış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexBuying").InnerXml;
                satış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
                label6.Text = alış;
                label7.Text = satış;
                label5.Text = comboBox1.SelectedItem.ToString();
                pictureBox2.ImageLocation = "http://www.flaginstitute.org/wp/wp-content/uploads/flags/EUUN0001.png";
            }

            if (comboBox1.Text == "GBP - İngiliz Sterlini")
            {
               
                TCMB_xml.Load(TCMB_kur);
                alış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexBuying").InnerXml;
                satış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
                label6.Text = alış;
                label7.Text = satış;
                label5.Text = comboBox1.SelectedItem.ToString();
                pictureBox2.ImageLocation = "https://cdn.britannica.com/25/4825-004-C11466B0/Flag-United-Kingdom.jpg";
            }

            if (comboBox1.Text == "CHF - İsviçre Frangı")
            {
                
                TCMB_xml.Load(TCMB_kur);
                alış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/ForexBuying").InnerXml;
                satış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/ForexSelling").InnerXml;
                label6.Text = alış;
                label7.Text = satış;
                label5.Text = comboBox1.SelectedItem.ToString();
                pictureBox2.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Flag_of_Switzerland.svg/1200px-Flag_of_Switzerland.svg.png";
            }

            if (comboBox1.Text == "CAD - Kanada Doları")
            {
               
                TCMB_xml.Load(TCMB_kur);
                alış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/ForexBuying").InnerXml;
                satış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/ForexSelling").InnerXml;
                label6.Text = alış;
                label7.Text = satış;
                label5.Text = comboBox1.SelectedItem.ToString();
                pictureBox2.ImageLocation = "https://dynamicmedia.zuza.com/zz/m/original_/9/4/94747413-5e9e-45f1-a73e-f5a42936126d/LIST_FlagfactsFeb15_Gallery.jpg";
            }

            if (comboBox1.Text == "RUB - Rus Rublesi")
            {
               
                TCMB_xml.Load(TCMB_kur);
                alış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/ForexBuying").InnerXml;
                satış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/ForexSelling").InnerXml;
                label6.Text = alış;
                label7.Text = satış;
                label5.Text = comboBox1.SelectedItem.ToString();
                pictureBox2.ImageLocation = "https://www.countryflags.com/wp-content/uploads/russia-flag-png-large.png";
            }

            if (comboBox1.Text == "KWD - Kuveyt Dinarı")
            {
               
                TCMB_xml.Load(TCMB_kur);
                alış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/ForexBuying").InnerXml;
                satış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/ForexSelling").InnerXml;
                label6.Text = alış;
                label7.Text = satış;
                label5.Text = comboBox1.SelectedItem.ToString();
                pictureBox2.ImageLocation = "https://cdn.britannica.com/70/5770-050-BD7FAEFD/Flag-Kuwait.jpg";
            }
        }
    }
}
