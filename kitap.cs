using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYUN
{
    public partial class kitap : Form
    {
        public kitap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Yüksel\Downloads\Sırça-Köşk-Sabahattin-Ali-Kısa-Öykü.wav";
            player.Play();
        }
    }
}
