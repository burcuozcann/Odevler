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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //geriye deger dondurmeyen parametre almayan
        //1
        void MesajGoster()
        {
            MessageBox.Show("Sayfamiza Hosgeldiniz..");

        }
        //2
        void MesajVer()
        {

            MessageBox.Show("Hosgeldiniz");
        }
        //3
        void ModAl()
        {
            int sayi = 100 % 2;
            MessageBox.Show(sayi.ToString());

        }
        //4 
        void TekCift()
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi%2==0)
            {
                MessageBox.Show("Cift");
            }
            else
            {
                MessageBox.Show("Tek");
            }
        
        
        }
        private void btnIsim_Click(object sender, EventArgs e)
        {
            MesajGoster();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MesajVer();
        }

        private void btnTekCift_Click(object sender, EventArgs e)
        {
            TekCift();
        }
    }
}
