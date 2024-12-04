using Birİşlem;
using OYUN.Oyunlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYUN
{
    public partial class OyunGirişEkranı : Form
    {



        public OyunGirişEkranı()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Birislemoyun birislem = new Birislemoyun();
            birislem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DusuktenYuksegeoyunu dusuktenYuksegeoyunu = new DusuktenYuksegeoyunu();
            dusuktenYuksegeoyunu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           Karteslestirmeoyun karteslestirmeoyun = new Karteslestirmeoyun();
            karteslestirmeoyun.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TicTakTooyunu ticTakTooyunu = new TicTakTooyunu();
            ticTakTooyunu.Show();
        }

        /*private void button8_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            Hafızaoyunu haf = new Hafızaoyunu();
            haf.Show();
        }
    }
}