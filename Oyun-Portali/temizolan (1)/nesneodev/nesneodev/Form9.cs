using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesneodev
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        int araba1, araba2, araba3;

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            araba1 = rastgele.Next(4, 8);
            araba2 = rastgele.Next(4, 8);
            araba3 = rastgele.Next(4, 8);

            kirmizi.Left += araba1;
            siyah.Left += araba2;
            gri.Left += araba3;

            if (kirmizi.Right >= pictureBox4.Left)
            {
                timer1.Stop();
                MessageBox.Show("Kırmızı F1 KAZANDI !!!");
            }
            if (siyah.Right >= pictureBox4.Left)
            {
                timer1.Stop();
                MessageBox.Show("Siyah F1 KAZANDI !!!");
            }
            if (gri.Right >= pictureBox4.Left)
            {
                timer1.Stop();
                MessageBox.Show("Gri F1 KAZANDI !!!");
            }
        }

        

        

        
    }
}
