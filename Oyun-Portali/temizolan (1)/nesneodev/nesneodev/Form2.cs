using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nesneodev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlbaglanti = new SqlConnection(" Data Source = ERAY; Initial Catalog = sorular; Integrated Security = True");//dosya nerde
        int soruno = -1, dogru = 0, yanlis = 0, zaman = 15,bos=1;


        private void button5_Click(object sender, EventArgs e)
        {
            sqlbaglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from soru order by NEWID() ", sqlbaglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                
                button1.Text = (oku["a"].ToString());
                button2.Text = (oku["b"].ToString());
                button3.Text = (oku["c"].ToString());
                button4.Text = (oku["d"].ToString());
                textBox1.Text= (oku["sorusutunu"].ToString());
                label2.Text = (oku["dogru"].ToString());
                
            }
                sqlbaglanti.Close();
            soruno++;
            if (soruno == 20)
            {

                MessageBox.Show("Yarışmamız Sonlanmıştır!");
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Hide();
            }

            timer1.Enabled = true;
            zaman = 15;
            label10.Text = zaman.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Text = "İLERİ";
            
           /* if (soruno == 1)
            {
                textBox1.Text = "Aşagıdakilerden Hangisi bir işletim sistemi değildir ?";
                
                button1.Text = "Ubuntu";
                button2.Text = "Windows";
                button3.Text = "Linux";
                button4.Text = "SQL Server";
                label13.Text = "SQL Server";
            }

            if (soruno == 2)
            {
                textBox1.Text = "Windows En son hangi sürümünü piyasaya sürmüştür ??";
                button1.Text = "Windows XP";
                button2.Text = "Windows 11";
                button3.Text = "Windows 10";
                button4.Text = "Windows Vista";
                label13.Text = "Windows 11";
            }

            if (soruno == 3)
            {
                textBox1.Text = "Aşağıdakilerden hangisi programlama dili değildir ?";
                button1.Text = "C#";
                button2.Text = "JAVA";
                button3.Text = "PHP";
                button4.Text = "LİNUX";
                label13.Text = "LİNUX";
            }

            if (soruno == 4)
            {
                textBox1.Text = "Türkçe hangi dil grubuna girmektedir?";
                button1.Text = "Ural – Altay";
                button2.Text = "Hami Dilleri";
                button3.Text = "Hint-İran Dilleri";
                button4.Text = "Roman Dilleri";
                label13.Text = "Ural – Altay";
            }

            if (soruno == 5)
            {
                textBox1.Text = "Pusulada ( N ) harfi hangi yönü ifade eder?";
                button1.Text = "Batı";
                button2.Text = "Güney";
                button3.Text = "Kuzey";
                button4.Text = "Doğu";
                label13.Text = "Kuzey";
            }

            if (soruno == 6)
            {
                textBox1.Text = "Maddenin ölçülemeyen özelliği hangisidir ?";
                button1.Text = "Koku";
                button2.Text = "Ağırlık";
                button3.Text = "Tat";
                button4.Text = "Boy";
                label13.Text = "Koku";
            }

            if (soruno == 7)
            {
                textBox1.Text = "Ülkemiz Avrupa Birliğine tam üyelik müzakerelerine hangi yılda başlamıştır?";
                button1.Text = "2005";
                button2.Text = "2006";
                button3.Text = "2007";
                button4.Text = "2008";
                label13.Text = "2005";
            }

            if (soruno == 8)
            {
                textBox1.Text = "İlk Türkçe sözlük hangisidir?";
                button1.Text = "Kamus-ı Türkî";
                button2.Text = "Divan-ı Lugat-it Türk";
                button3.Text = "Lehcetü’l-Lügat";
                button4.Text = "Müntahabât-ı Lügât-i Osmâniyye";
                label13.Text = "Divan-ı Lugat-it Türk";
            }

            if (soruno == 9)
            {
                textBox1.Text = "Cumhurbaşkanı kaç yılda bir seçilir?";
                button1.Text = "5";
                button2.Text = "4";
                button3.Text = "1";
                button4.Text = "3";
                label13.Text = "5";
            }

            if (soruno == 10)
            {
                textBox1.Text = "Titanik 15 Nisan'da Southampton'dan ilk yolculuğunda Atlantik Okyanusu'nda hangi yıl battı?";
                button1.Text = "1914";
                button2.Text = "1912";
                button3.Text = "1913";
                button4.Text = "1917";
                label13.Text = "1912";
            }

            if (soruno == 11)
            {
                textBox1.Text = "Yalnızlık Bakanlığı hangi ülkede kurulmuştur?";
                button1.Text = "İsveç";
                button2.Text = "İngiltere";
                button3.Text = "Rusya";
                button4.Text = "Norveç";
                label13.Text = "İngiltere";
            }

            if (soruno == 12)
            {
                textBox1.Text = "Ünlü F1 sürücüsü ayrton senna kaç defa dünya şampiyonu olmuştur?";
                button1.Text = "1";
                button2.Text = "2";
                button3.Text = "3";
                button4.Text = "4";
                label13.Text = "3";
            }

            if (soruno == 13)
            {
                textBox1.Text = "Hollywood tabelası 1923 yılında hangi sektörün tanıtımı için dikilmiştir?";
                button1.Text = "Turizm";
                button2.Text = "Sinema";
                button3.Text = "Sanayi";
                button4.Text = "Emlâk";
                label13.Text = "Emlâk";
            }

            if (soruno == 14)
            {
                textBox1.Text = "Demir Adam filminin yapımcısına göre, Demir Adam karakterinin yaratılması için kimden ilham alınmıştır?";
                button1.Text = "Bill Gates";
                button2.Text = "Elon Musk";
                button3.Text = "Steve Jobs";
                button4.Text = "Acun Ilıcalı";
                label13.Text = "Elon Musk";
            }

            if (soruno == 15)
            {
                textBox1.Text = "FIFA’ya göre futbolun doğduğu ülke hangisidir?";
                button1.Text = "İngiltere";
                button2.Text = "İspanya";
                button3.Text = "Çin";
                button4.Text = "Brezilya";
                label13.Text = "Çin";
            }

            if (soruno == 16)
            {
                textBox1.Text = "Eleğimsağma ne demektir?";
                button1.Text = "Gökyüzü";
                button2.Text = "Patlama";
                button3.Text = "Gökkuşağı";
                button4.Text = "Doğa olayı";
                label13.Text = "Gökkuşağı";
            }

            if (soruno == 17)
            {
                textBox1.Text = "Yüz ölçümü bakımından en büyük ülke hangisidir?";
                button1.Text = "Türkiye";
                button2.Text = "Çin";
                button3.Text = "ABD";
                button4.Text = "Rusya";
                label13.Text = "Rusya";
            }

            if (soruno == 18)
            {
                textBox1.Text = "Kırmızı ve sarı renklerinin karışımından hangi renk elde edilir?";
                button1.Text = "Mor";
                button2.Text = "Turuncu";
                button3.Text = "Yeşil";
                button4.Text = "Kırmızı";
                label13.Text = "Turuncu";
            }

            if (soruno == 19)
            {
                textBox1.Text = "Haita biliminin diğer adı nedir?";
                button1.Text = "Numizmatik";
                button2.Text = "Filoloji";
                button3.Text = "Kartografya";
                button4.Text = "Heraldik";
                label13.Text = "Kartografya";
            }

            if (soruno == 20)
            {
                textBox1.Text = "Albert Einstein hangi alanda Nobel ödülü almıştır?";
                button1.Text = "Fizik";
                button2.Text = "Matematik";
                button3.Text = "Kimya";
                button4.Text = "Simya";
                label13.Text = "Fizik";

                MessageBox.Show("Bilgi Yarısması Bitmiştir");
            }*/

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            zaman = Convert.ToInt32(label10.Text);
            zaman--;
            label10.Text = zaman.ToString();
            if (zaman == 0)
            {
                bos++;
                label12.Text = bos.ToString();
                timer1.Stop();
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                soruno++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {

            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label14.Visible = false;
            label13.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            /* label14.Text = button1.Text;*/
            if (button1.Text==label2.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }
            

            /*if (label14.Text == label13.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }*/

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            int a=bos++;
            label12.Text = a.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            //label14.Text = button2.Text;
            if (button2.Text==label2.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }
            

           /* if (label14.Text == label13.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }*/

    }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            // label14.Text = button3.Text;

            if (button3.Text == label2.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }

            /*if (label14.Text == label13.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }*/

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            //label14.Text = button4.Text;

            if (button4.Text == label2.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }

            /*if (label14.Text == label13.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }*/

        }
    }
}
