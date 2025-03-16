using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma_ornek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            tbSayi.Clear();

        }



        int tektoplam = 0;
        int cifttoplam = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int s;
            s = Convert.ToInt32(tbSayi.Text); 
            
            if (s % 2 == 0)
            {
                cifttoplam = s + cifttoplam;
                lblCiftSayi.Text = cifttoplam.ToString();
                temizle();

            }

            if (s % 2 != 0) 
            {
                tektoplam = s + tektoplam;
                lblTekSayi.Text = tektoplam.ToString();
                temizle();
            
            }

        }
    }
}
