using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYarisi
{
    public partial class Form1 : Form
    {
        private int score = 0;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            this.KeyDown += Form1_KeyDown_1;

            timerGame.Interval = 20; // Daha yavaş bir hız
            timerGame.Tick += TimerGame_Tick;

            StartNewGame();
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            MoveCars();
            MoveCoins();
            CheckCollision();
        }

        private void StartNewGame()
        {
            // Puanı sıfırla ve ekrana yansıt
            score = 0;
            lblScore.Text = $"Puan: {score}";

            // Arabaların ve coinlerin başlangıç pozisyonlarını sıfırla
            ResetPositions();

            // Kırmızı arabayı başlangıç noktasına getir
            pictureBoxKirmiziAraba.Left = (this.Width / 2) - (pictureBoxKirmiziAraba.Width / 2);
            pictureBoxKirmiziAraba.Top = this.Height - pictureBoxKirmiziAraba.Height - 60; // Alt tarafa yakın ama biraz yukarıda

            // Timer'ı başlat
            timerGame.Start();
        }

        private void ResetPositions()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox && (control.Tag == "enemyCar" || control.Tag == "coin"))
                {
                    int newTop = random.Next(-300, -100); // Üstten aşağıya doğru rastgele başlasın
                    int newLeft;

                    // Çakışma kontrolü ile pozisyon belirle
                    do
                    {
                        newLeft = random.Next(50, this.Width - 100);
                    } while (IsOverlappingWithOthers(control, newLeft, newTop));

                    control.Top = newTop;
                    control.Left = newLeft;
                }
            }
        }

        private bool IsOverlappingWithOthers(Control currentControl, int newLeft, int newTop)
        {
            foreach (Control control in Controls)
            {
                if (control != currentControl && control is PictureBox &&
                    (control.Tag == "enemyCar" || control.Tag == "coin"))
                {
                    Rectangle newBounds = new Rectangle(newLeft, newTop, currentControl.Width, currentControl.Height);
                    if (newBounds.IntersectsWith(control.Bounds))
                    {
                        return true; // Çakışma varsa true döner
                    }
                }
            }
            return false; // Çakışma yoksa false döner
        }

        private void MoveCars()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag == "enemyCar")
                {
                    control.Top += 4; // Sarı arabaların hareket hızı
                    if (control.Top > this.Height)
                    {
                        int newTop = random.Next(-200, -100);
                        int newLeft;

                        // Çakışma kontrolü ile pozisyon belirle
                        do
                        {
                            newLeft = random.Next(50, this.Width - 100);
                        } while (IsOverlappingWithOthers(control, newLeft, newTop));

                        control.Top = newTop;
                        control.Left = newLeft;
                    }
                }
            }
        }

        private void MoveCoins()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag == "coin")
                {
                    control.Top += 3; // Coin hareket hızı
                    if (control.Top > this.Height)
                    {
                        int newTop = random.Next(-200, -100);
                        int newLeft;

                        // Çakışma kontrolü ile pozisyon belirle
                        do
                        {
                            newLeft = random.Next(50, this.Width - 100);
                        } while (IsOverlappingWithOthers(control, newLeft, newTop));

                        control.Top = newTop;
                        control.Left = newLeft;
                    }
                }
            }
        }

        private void CheckCollision()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag == "enemyCar")
                {
                    if (pictureBoxKirmiziAraba.Bounds.IntersectsWith(control.Bounds))
                    {
                        timerGame.Stop();
                        MessageBox.Show($"Oyun bitti! Toplam Puanınız: {score}");
                        RestartGame();
                        return;
                    }
                }

                if (control is PictureBox && control.Tag == "coin")
                {
                    if (pictureBoxKirmiziAraba.Bounds.IntersectsWith(control.Bounds))
                    {
                        score++;
                        lblScore.Text = $"Puan: {score}";
                        control.Top = random.Next(-200, -100);
                        control.Left = random.Next(50, this.Width - 100);
                    }
                }
            }

            // Kenar çarpışması kontrolü (daha hassas sınır kontrolü)
            if (pictureBoxKirmiziAraba.Left <= 0 || pictureBoxKirmiziAraba.Right >= this.ClientSize.Width)
            {
                timerGame.Stop();
                MessageBox.Show($"Oyun bitti! Toplam Puanınız: {score}");
                RestartGame();
            }
        }


        private void RestartGame()
        {
            DialogResult result = MessageBox.Show("Yeni oyun başlatmak istiyor musunuz?", "Oyun Bitti", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                StartNewGame();
            }
            else
            {
                Application.Exit();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            int moveDistance = 15;
            if (e.KeyCode == Keys.Left && pictureBoxKirmiziAraba.Left > 0)
            {
                pictureBoxKirmiziAraba.Left -= moveDistance;
            }
            else if (e.KeyCode == Keys.Right && pictureBoxKirmiziAraba.Right < this.Width)
            {
                pictureBoxKirmiziAraba.Left += moveDistance;
            }
        }
    }
}
