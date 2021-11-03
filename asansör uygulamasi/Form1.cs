using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asansör_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");

            asansör1 = rastgele.Next(1, 5);
            asansör2 = rastgele.Next(1, 5);
            label4.Text = asansör1.ToString();
            label5.Text = asansör2.ToString();

        }
        int asansör1, asansör2, mevcutkat,fark1,fark2;
        Random rastgele = new Random();

        private void kat4_Click(object sender, EventArgs e)
        {
           
        }

        private void kat3_Click(object sender, EventArgs e)
        {

        }

        private void kat2_Click(object sender, EventArgs e)
        {

        }

        private void kat1_Click(object sender, EventArgs e)
        {   
            fark1 = mevcutkat - asansör1;
            fark2 = mevcutkat - asansör2;
            if (fark1 < fark2)
            {
                asansör1 = mevcutkat;
            }
            else if (fark2 < fark1)
            {
                asansör2 = mevcutkat;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fark1 = 0;
            fark2 = 0;
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen Kat Seçiniz");
            }
            else
            {
                mevcutkat = int.Parse(comboBox1.Text);
            }
            kat1.Enabled = true;
            kat2.Enabled = true;
            kat3.Enabled = true;
            kat4.Enabled = true;

            label4.Text = asansör1.ToString();
            label5.Text = asansör2.ToString();
            
            if (mevcutkat == 1)
            {
                kat1.Enabled = false;
            }
            if (mevcutkat == 2)
            {
                kat2.Enabled = false;
            }
            if (mevcutkat == 3)
            {
                kat3.Enabled = false;
            }
            if (mevcutkat == 4)
            {
                kat4.Enabled = false;
            }
            fark1 = mevcutkat - asansör1;
            fark2 = mevcutkat - asansör2;
            if (fark1 < fark2)
            {
                asansör1 = mevcutkat;
            }
            else if (fark2 < fark1)
            {
                asansör2 = mevcutkat;
            }
            else
            {
               int x = rastgele.Next(0,2);
                if (x==0)
                {
                    asansör1 = mevcutkat;
                }
                else
                {
                    asansör2 = mevcutkat;
                }
            }
        }

    }
}
