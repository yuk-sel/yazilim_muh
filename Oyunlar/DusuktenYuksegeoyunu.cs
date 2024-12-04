using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OYUN.Oyunlar
{
    public partial class DusuktenYuksegeoyunu : Form
    {
        public DusuktenYuksegeoyunu()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int sure = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            // timer1.Interval = 1000;
            // label6.Text = sure.ToString();
            button1.Enabled = false;
            int sayı1, sayı2, sayı3;

            sayı1 = rastgele.Next(0, 50);
            sayı2 = rastgele.Next(0, 50);
            sayı3 = rastgele.Next(0, 50);

            label3.Text = sayı1.ToString();
            label4.Text = sayı2.ToString();
            label5.Text = sayı3.ToString();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            sure--;
            label6.Text = sure.ToString();
            if (sure == 0)
            {
                timer2.Stop();
                panel1.Visible = false;
                label6.Text = "5"; // kaldırabılırsın 
                sure = 5;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int deger1, deger2, deger3;

            // TextBox'ların içindeki değerleri sayıya dönüştür ve kontrol et
            if (int.TryParse(textBox1.Text, out deger1) && int.TryParse(textBox2.Text, out deger2) && int.TryParse(textBox3.Text, out deger3))
            {
                if (deger1 < deger2 && deger2 < deger3)
                {
                    MessageBox.Show("Tebrikler oyunu kazandınız :)");
                }
                else
                {
                    MessageBox.Show("Üzgünüm oyunu kaybettiniz :(");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayılar girin!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}