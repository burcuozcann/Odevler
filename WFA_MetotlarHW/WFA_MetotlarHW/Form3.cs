using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MetotlarHW
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
         
        //Geriye Deger Donduren( Parametre Almayan)
        //1
        string item()
        {
           string deger = txtYazi.Text;
            string bilgi = deger;
            return bilgi;
        }
        //2
        int BankaMatik()
        { 
            int bakiye=Convert.ToInt32(txtCekilenPara.Text);
            int bakiyeGoster = 1000-bakiye;
            return bakiyeGoster;
 
        }
        //3
        int Hesapla()
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int topla = sayi1 + sayi2;
            return topla;
        
        }
        //4
        string SelamVer()
        {
            string isim = txtSelam.Text;
            return "Hosgeldin "+ isim;

        
        }
        //5
        double VizeFinal()
        {

            double vize = Convert.ToInt32(txtVize.Text);
            double final = Convert.ToInt32(txtFinal.Text);
            double hesapla = ((vize * 0.30) + (final*0.70));
            return hesapla;
        
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(item());
            cmbText.Items.Add(item());
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" Kalan Bakiye => {BankaMatik().ToString()}");
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Hesapla().ToString());
        }

        private void btnSelamla_Click(object sender, EventArgs e)
        {
            Text = SelamVer();
        }

        private void btnVizeFinal_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Sinav Sonucu => {VizeFinal().ToString()}");
        }
    }
}
