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
    public partial class Form10 : Form
    {
        private const Keys yukari = Keys.Up;
        private const Keys saga = Keys.Right;
        private const Keys asagi = Keys.Down;
        private const Keys sola = Keys.Left;

        private int posX;
        private int posY;
        private const int xMax = 69;
        private const int xMin = 0;
        private const int yMax = 46;
        private const int yMin = 0;

        private bool lastKeyProcessed = true;
        private int multiplier = 11;
        private int puan = 0;
        private yonEnum yon;
        private Point bait;
        private List<Point> poizsyon = new List<Point>();
        public Form10()
        {
            InitializeComponent();
        }
        public enum yonEnum
        {
            tanimsiz,
            Yukari,
            Saga,
            Asagi,
            Sola
        }

        private void yilanCiz()
        {
            gameArea.Refresh();
            yemCiz();
            foreach (Point item in poizsyon)
            {
                int xVal = item.X * multiplier;
                int yVal = item.Y * multiplier;

                noktaCiz(xVal, yVal);
            }
        }
        private void hizAyarla()
        {
            switch (cmbHiz.SelectedIndex)
            {
                case 0:
                    gameTimer.Interval = 100;
                    break;
                case 1:
                    gameTimer.Interval = 75;
                    break;
                case 2:
                default:
                    gameTimer.Interval = 50;
                    break;
                case 3:
                    gameTimer.Interval = 40;
                    break;
                case 4:
                    gameTimer.Interval = 25;
                    break;
                case 5:
                    gameTimer.Interval = 10;
                    break;
            }
        }

        private void sifirla()
        {
            posX = 12;
            posY = 20;
            puan = 0;
            yon = yonEnum.Saga;
            cizim();
        }

        private void yeniOyun()
        {
            poizsyon.Clear();
            poizsyon.Add(new Point(12, 20));
            poizsyon.Add(new Point(11, 20));
            poizsyon.Add(new Point(10, 20));
        }
        private void pozisyonBelirle()
        {
            switch (yon)
            {
                case yonEnum.Asagi:
                    posY++;
                    break;
                case yonEnum.Yukari:
                    posY--;
                    break;
                case yonEnum.Sola:
                    posX--;
                    break;
                case yonEnum.Saga:
                default:
                    posX++;
                    break;
            }
        }

        private bool oyunBitti()
        {
            if (poizsyon.Any(t => t.X == posX && t.Y == posY))
            {
                return true;
            }

            return false;
        }

        private void yemOlustur()
        {
            Random random = new Random(DateTime.Now.TimeOfDay.Milliseconds);
            int x = 0;
            int y = 0;
            bool b = true;

            while (b)
            {
                x = random.Next(xMin, xMax + 1) * multiplier;
                y = random.Next(yMin, yMax + 1) * multiplier;

                b = poizsyon.Any(t => t.X == x && t.Y == y);
            }

            bait = new Point(x, y);
        }

        private void eatBait()
        {
            Point lastPoint = poizsyon[poizsyon.Count - 1];
            poizsyon.Add(new Point(lastPoint.X, lastPoint.Y));
            puan += (cmbHiz.SelectedIndex + 1) * 10;
            cizim();
            yemOlustur();
        }

        private void cizim()
        {
            //lbPuan.Text = puan.ToString();
            lbYem.Text = (poizsyon.Count - 3).ToString();
        }
        private void basla()
        {
            cmbHiz.Enabled = false;
            bntBasla.Enabled = false;
            hizAyarla();
            gameTimer.Enabled = true;
        }

        private void oyna()
        {
            pozisyonBelirle();
            bool isGameEnded = oyunBitti();

            if (isGameEnded)
            {
                gameTimer.Enabled = false;
                MessageBox.Show(String.Format("Oyun Bitti! ",puan),
                                "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (posY > yMax)
                posY = yMin;
            else if (posY < yMin)
                posY = yMax;

            if (posX > xMax)
                posX = xMin;
            else if (posX < xMin)
                posX = xMax;

            poizsyon.Insert(0, new Point(posX, posY));
            poizsyon.RemoveAt(poizsyon.Count - 1);

            if (bait.X == posX * multiplier && bait.Y == posY * multiplier)
            {
                eatBait();
            }

            yilanCiz();
            lastKeyProcessed = true;
        }

        private void oyunSifirla()
        {
            gameTimer.Enabled = false;
            bntBasla.Enabled = true;
            cmbHiz.Enabled = true;

            yeniOyun();
            sifirla();
            yemOlustur();
            yilanCiz();
        }

        private void bekle(Keys keyData)
        {
            if (keyData == Keys.P)
            {
                gameTimer.Enabled = !gameTimer.Enabled;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (gameTimer.Enabled && lastKeyProcessed && keyData != Keys.P)
            {
                lastKeyProcessed = false;
                pozisyonBelirle(keyData);
            }

            bekle(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void pozisyonBelirle(Keys keyData)
        {
            switch (keyData)
            {
                case yukari:
                    if (yon != yonEnum.Asagi)
                        yon = yonEnum.Yukari;
                    break;
                case asagi:
                    if (yon != yonEnum.Yukari)
                        yon = yonEnum.Asagi;
                    break;
                case sola:
                    if (yon != yonEnum.Saga)
                        yon = yonEnum.Sola;
                    break;
                case saga:
                default:
                    if (yon != yonEnum.Sola)
                        yon = yonEnum.Saga;
                    break;
            }
        }
        private void noktaCiz(int x, int y, bool isBlack = true)
        {
            using (Graphics g = this.gameArea.CreateGraphics())
            {
                Color penColor = isBlack ? Color.Green : Color.Red;
                Pen pen = new Pen(penColor, 5);
                g.DrawRectangle(pen, x, y, 5, 5);
                pen.Dispose();
            }
        }

        private void yemCiz()
        {
            noktaCiz(bait.X, bait.Y, false);
        }
        private void yilan_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
                cmbHiz.Items.Add(i + 1);
                cmbHiz.SelectedIndex = 2;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            cmbHiz.Visible = false;
        }

        private void bntBasla_Click(object sender, EventArgs e)
        {
            oyunSifirla();
            basla();
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            oyna();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            oyunSifirla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void gameArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbYem_Click(object sender, EventArgs e)
        {

        }
    }
}
