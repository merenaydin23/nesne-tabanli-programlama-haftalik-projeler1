namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Oyun mekani�ini kontrol etmek i�in sabitler ve de�i�kenler
        int boruHIZI = 8; // Borular�n h�z�
        int GRAVITY = 10; // Ku�un d�����n� etkileyen yer�ekimi
        int score = 0;    // Oyuncunun puan�

        public Form1()
        {
            InitializeComponent(); // Formu ve bile�enlerini ba�lat�r
        }

        private void gameTimmerEvent(object sender, EventArgs e)
        {
            // Ku�un konumunu yer�ekimine g�re g�ncelle
            FlappyBird.Top += GRAVITY;
            // Borular� sola hareket ettir
            BoruAlt.Left -= boruHIZI;
            boruUst.Left -= boruHIZI;

            // Puan bilgisini g�ncelle
            scoreText.Text = "Puan: " + score;

            // Alt borunun ekrandan ��kt���n� kontrol et
            if (BoruAlt.Left < -150)
            {
                BoruAlt.Left = 800; // Boru konumunu sa�a s�f�rla
                score++; // Puan� art�r
            }

            // �st borunun ekrandan ��kt���n� kontrol et
            if (boruUst.Left < -180)
            {
                boruUst.Left = 950; // Boru konumunu sa�a s�f�rla
                score++; // Puan� art�r
            }

            // �arp��malar� veya ku�un ekrandan ��kmas�n� kontrol et
            if (FlappyBird.Bounds.IntersectsWith(BoruAlt.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(boruUst.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(Zemin.Bounds) ||
                FlappyBird.Top < -25)
            {
                // �arp��ma varsa oyunu bitir
                endGame();
            }

            // Puan 5'i ge�ti�inde boru h�z�n� art�r
            if (score > 5)
            {
                boruHIZI = 12; // Borular�n h�z�n� art�r
            }

            // Ku�un belirli bir y�ksekli�in alt�na inmesi durumunda oyunu bitir
            if (FlappyBird.Top < 25)
            {
                endGame();
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            // Bo�luk tu�u b�rak�ld���nda yer�ekimini s�f�rla
            if (e.KeyCode == Keys.Space)
            {
                GRAVITY = 10; // Yer�ekimini normal seviyeye getir
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            // Bo�luk tu�una bas�ld���nda yukar� itme kuvveti uygula
            if (e.KeyCode == Keys.Space)
            {
                GRAVITY = -10; // Ku�un yukar� ��kmas�n� sa�la
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Oyun durumu gibi ba�latma kodlar�
        }

        private void scoreText_Click(object sender, EventArgs e)
        {
            // �ste�e ba�l�: Puan metni t�kland���nda yap�lacak i�lemler
        }

        private void endGame()
        {
            GameTimmer.Stop(); // Ana zamanlay�c�y� durdur
            scoreText.Text = "Oyun Bitti !!!!"; // Puan metninde oyun bitti mesaj�n� g�ster
            this.KeyDown += new KeyEventHandler(restartGame); // Space tu�unu dinle
        }

        private void restartGame(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                score = 0; // Puan� s�f�rla
                boruHIZI = 8; // H�z� ba�lang�� de�erine getir
                FlappyBird.Top = 100; // Ku�un ba�lang�� y�ksekli�i
                BoruAlt.Left = 800; // Boru konumlar�n� s�f�rla
                boruUst.Left = 950;
                scoreText.Text = "Puan: " + score; // Puan metnini g�ncelle
                GameTimmer.Start(); // Zamanlay�c�y� yeniden ba�lat
                this.KeyDown -= new KeyEventHandler(restartGame); // Tu� dinleyiciyi kald�r
            }
        }
    }
}
