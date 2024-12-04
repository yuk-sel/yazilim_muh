using System.Windows.Forms;
using System;

namespace OYUN
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(895, 715);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "OYUN SEÇ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(299, 715);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(377, 110);
            this.button2.TabIndex = 1;
            this.button2.Text = "SESLİ KİTAP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(600, 582);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(377, 110);
            this.button3.TabIndex = 2;
            this.button3.Text = "SUDOKU";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightBlue;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Bright", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(332, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(889, 480);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "   \n  Yaşlılara Yönelik \n   Oyun Tabanlı \n Öğrenme Programı ";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1575, 891);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion
        private Button button3;
        private Button button2;
        private Button button1;
        private RichTextBox richTextBox1;
    }

}