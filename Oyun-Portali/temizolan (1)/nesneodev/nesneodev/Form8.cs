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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            
        }
        
        private void label67_MouseEnter(object sender, EventArgs e)
        {

            MessageBox.Show("Duvara Çarptınız !!!");
        }

        private void label64_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler !!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
