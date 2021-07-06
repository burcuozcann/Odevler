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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //Geriye Deger Donduren (Parametre Alan)

        //1
        int CarpimIslemi(int numara )
        {
            //int sayi = Convert.ToInt32(txtSayi.Text) ;
            int sonuc = numara * 2;
            return sonuc;



        }

        //2
        string MesajVer(string isim)
        {
            string deger = isim + " " + "Giris Yapti..";
            return deger;
        
        }
        //3
        int Faktoriyel(int sayi)
        {
            int fktryl = 1;
            for (int i = 1; i <= sayi; i++)
            {
                fktryl = fktryl * i;

            }
            return fktryl;
        
        }

        //4

        string cmbEkle(string deger)
        {
            string liste = txtEkle.Text;
            deger = liste;
            return liste;
        
        }
        private void btnIslem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(CarpimIslemi(Convert.ToInt32(txtSayi.Text)));
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MesajVer(txtIsim.Text));
        }

        private void btnFaktoriyel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Faktoriyel(Convert.ToInt32(txtFaktoriyel.Text)).ToString());
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cmbListe.Items.Add(txtEkle.Text);
        }
    }
}
