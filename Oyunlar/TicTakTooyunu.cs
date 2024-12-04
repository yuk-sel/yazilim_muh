using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OYUN.Oyunlar
{
    public partial class TicTakTooyunu : Form
    {
        public TicTakTooyunu()
        {
            InitializeComponent();
            this.Load += TicTakTooyunu_Load;
        }

        public enum oyuncular
        {
            X, O
        }

        public oyuncular oyuncuX;
        int oyuncu = 0;
        int bilgisayar = 0;
        Random random = new Random();
        List<Button> butonlar;

        private void TicTakTooyunu_Load(object sender, EventArgs e)
        {
            foreach (var button in new[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 })
            {
                button.Click += oyuncuTikla;
            }
            pcZaman.Tick += OyuncuSure;
            pcZaman.Interval = 1000;
            yenile();
        }

        private void OyuncuSure(object sender, EventArgs e)
        {
            if (butonlar.Count > 0)
            {
                int index = random.Next(butonlar.Count);
                var button = butonlar[index];
                button.Enabled = false;
                oyuncuX = oyuncular.O;
                button.Text = oyuncuX.ToString();
                button.BackColor = Color.DarkSalmon;
                butonlar.RemoveAt(index);
                pcZaman.Stop();
                oyunKontrol();
            }
        }

        private void oyuncuTikla(object sender, EventArgs e)
        {
            var button = (Button)sender;
            oyuncuX = oyuncular.X;
            button.Text = oyuncuX.ToString();
            button.Enabled = false;
            button.BackColor = Color.Cyan;
            butonlar.Remove(button);
            pcZaman.Start();
            oyunKontrol();
        }

        private void yenile()
        {
            butonlar = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button x in butonlar)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = DefaultBackColor;
            }
        }

        private void oyunKontrol()
        {
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
                (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                pcZaman.Stop();
                MessageBox.Show("Kazanan Oyuncu!");
                oyuncu++;
                label1.Text = "Oyuncu: " + oyuncu;
                yenile();
            }
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                     (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                     (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                     (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                     (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                     (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
                     (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                     (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                pcZaman.Stop();
                MessageBox.Show("Kazanan Bilgisayar!");
                bilgisayar++;
                label2.Text = "Bilgisayar: " + bilgisayar;
                yenile();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}