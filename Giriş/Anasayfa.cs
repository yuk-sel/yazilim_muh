using FirstPlei;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYUN
{
    public partial class Anasayfa : Form
    {
        //private OyunGirişEkranı OyunGirişEkranıformu;
        private frm_Sudoku frm_Sudoku;

        public Anasayfa()
        {
            InitializeComponent();
            //   new OyunGirişEkranı();
            frm_Sudoku = new frm_Sudoku();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OyunGirişEkranı oyunGirişEkranı = new OyunGirişEkranı();
            oyunGirişEkranı.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Sudoku.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitap kitap = new kitap();
            kitap.Show();
        }
    }
}