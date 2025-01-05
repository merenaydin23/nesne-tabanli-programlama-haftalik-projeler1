using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayın_Tarlası_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MayınDoldur(30, 30);
        }
        int skor = 0;
        void MayınDoldur(int mayin,int boyut)
        {
            int[] mayınlar = new int[mayin];
            flowLayoutPanel1.Controls.Clear(); // control panellerini temizleyerek yeniden oynamayı sağlar..
            Random rnd = new Random();
            for (int i = 0; i < mayin; i++)
            {
                int seçilen = rnd.Next(0, boyut * boyut); // mayın seçiyoruz rastgele..
                if (mayınlar.Contains(seçilen)) // seçilen mayını içeriyor mu contains ile
                {
                    i--;
                    continue;
                }
                mayınlar[i] = seçilen;
            }

            for (int i = 0; i < boyut*boyut ; i++)
            {
                Button btn = new Button();
                btn.Width = 30; // pikseli belirledik.
                btn.Height = 30;
                btn.Tag = mayınlar.Contains(i); // değer tutmayı sağlar true veya false şeklinde..
                btn.Click+= btn_Click;         
              //  btn.Margin = new Padding(0);// butonlar arası boşluğu yok eder..

                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button tıklanan = (Button)sender;
            bool durum = (bool)tıklanan.Tag;
            if (durum == true)
            {
                tıklanan.BackColor = Color.Blue;
                OyunBitir();
            }
            else
            {
                tıklanan.BackColor = Color.Yellow;
                skor++;
                textBox1.Text = skor.ToString();
            }
        }

        void OyunBitir()
        {
            skor = 0;
            foreach (Button item in flowLayoutPanel1.Controls)
            {
                bool durum = (bool)item.Tag;
                if (durum)
                {
                    item.BackColor = Color.Blue;
                }
                else
                {
                    item.BackColor = Color.Yellow;
                }
            }

            MessageBox.Show("Oyun Bitti Yeniden Oynamak ister misin ");
        }
    }
}
