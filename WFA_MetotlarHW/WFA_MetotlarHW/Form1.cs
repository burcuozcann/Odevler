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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Geriye Deger Dondurmeyen (parametre alan)

        //1
        void IsimSoyisimGetir (string isim,string soyisim)
        {
            try
            {
                MessageBox.Show($"{isim} {soyisim} basariyla kaydedildi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }
        //2
        void UrunHesapla(double sayi1,double sayi2)
        {
            
            double sonuc = sayi1 * sayi2;
            MessageBox.Show(sonuc.ToString());

        }

        //3
        
        void GirisYap(string kullaniciAdi,int Sifre)
        {
            switch (kullaniciAdi.ToLower())
            {
                case "burcu":
                    switch (Sifre)
                    {
                        case 123:
                            MessageBox.Show("Bilgiler Dogru..");
                            break;
                        default:
                            MessageBox.Show("Sifre Yanlis");
                            break;  
                    }
                    break;
                default:
                    MessageBox.Show("Kullanici Bulunamadi..");
                    break;
            }
            



        }

        //4 
        void SelamVer(Label lbl,string isim)
        {

            lbl.Text = $"Hosgeldin {isim}";
        
        }
        //5
        void CalculatorTopla(int sayi1,int sayi2)
        {

           int toplam= sayi1 + sayi2;
            MessageBox.Show(toplam.ToString());


        }
        //6
        void CalculatorCikar(int sayi1, int sayi2)
        {

            int cikar = sayi1 - sayi2;
            MessageBox.Show(cikar.ToString());


        }

        //7
        void CalculatorCarp(int sayi1, int sayi2)
        {

            int carp = sayi1 * sayi2;
            MessageBox.Show(carp.ToString());


        }
        //8
        void CalculatorBol(double sayi1, double sayi2)
        {

            double bol = sayi1 / sayi2;
            MessageBox.Show(bol.ToString());

        }
        //9
        void ButonMesaji(string mesaj)
        {

            MessageBox.Show($"{mesaj} isimli butona bastiniz...");

        }
        //10
        void Combo(ComboBox cmb)
        {

          
                if (cmb.SelectedIndex==0 || cmb.SelectedIndex == 1 || cmb.SelectedIndex == 2)
                {
                    MessageBox.Show($"{cmb.SelectedItem.ToString()} secmek istediginize emin misiniz ?");
                }
            
        }




        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IsimSoyisimGetir(txtIsim.Text,txtSoyisim.Text);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double urunAdedi = Convert.ToDouble(txtSayi1.Text);
                double fiyat = Convert.ToDouble(txtSayi2.Text);

                UrunHesapla(urunAdedi,fiyat);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                int password = Convert.ToInt32(txtPassword.Text);
                GirisYap(userName,password);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelamVer_Click(object sender, EventArgs e)
        {
            SelamVer(lblSelam,txtSelam.Text);
        }
       
        private void btnBol_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayiCal1.Text);
           double sayi2 = Convert.ToDouble(txtSayiCal2.Text);

            CalculatorBol(sayi1,sayi2);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayiCal1.Text);
            int sayi2 = Convert.ToInt32(txtSayiCal2.Text);

            CalculatorCarp(sayi1, sayi2);

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayiCal1.Text);
            int sayi2 = Convert.ToInt32(txtSayiCal2.Text);

            CalculatorCikar(sayi1, sayi2);
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayiCal1.Text);
            int sayi2 = Convert.ToInt32(txtSayiCal2.Text);

            CalculatorTopla(sayi1, sayi2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButonMesaji(button4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButonMesaji(button3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButonMesaji(button2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButonMesaji(button1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combo(comboBox1);
        }
    }
}
