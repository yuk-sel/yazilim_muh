using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OYUN.Oyunlar
{
    public partial class Hafızaoyunu : Form
    {
        public Hafızaoyunu()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int sure = 5;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            int sayı1, sayı2, sayı3, sayı4, sayı5, sayı6, sayı7, sayı8, sayı9, sayı10, sayı11, sayı12;

            sayı1 = rastgele.Next(0, 50);
            sayı2 = rastgele.Next(0, 50);
            sayı3 = rastgele.Next(0, 50);
            sayı4 = rastgele.Next(0, 50);
            sayı5 = rastgele.Next(0, 50);
            sayı6 = rastgele.Next(0, 50);
            sayı7 = rastgele.Next(0, 50);
            sayı8 = rastgele.Next(0, 50);
            sayı9 = rastgele.Next(0, 50);
            sayı10 = rastgele.Next(0, 50);
            sayı11 = rastgele.Next(0, 50);
            sayı12 = rastgele.Next(0, 50);

            label1.Text = sayı1.ToString();
            label2.Text = sayı2.ToString();
            label3.Text = sayı3.ToString();
            label4.Text = sayı4.ToString();
            label5.Text = sayı5.ToString();
            label6.Text = sayı6.ToString();
            label7.Text = sayı7.ToString();
            label8.Text = sayı8.ToString();
            label9.Text = sayı9.ToString();
            label10.Text = sayı10.ToString();
            label11.Text = sayı11.ToString();
            label12.Text = sayı12.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text && label2.Text == textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text && label6.Text == textBox6.Text && label7.Text == textBox7.Text && label8.Text == textBox8.Text && label9.Text == textBox9.Text && label10.Text == textBox10.Text && label11.Text == textBox11.Text && label12.Text == textBox12.Text)
            {
                MessageBox.Show("Tebrikler oyunu kazandınız hafızanız kuvvetli :) ");
            }
            else
            {
                MessageBox.Show("Üzgünüm oyunu kaybettiniz daha güçlü bir hafıza ile yeniden deneyiniz :( ");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label13.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Stop();
                groupBox1.Visible = false;
                label13.Text = "5"; // kaldırabılırsın 
                sure = 5;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            timer1.Start();
            button3.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}