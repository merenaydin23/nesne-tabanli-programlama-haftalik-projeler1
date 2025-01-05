namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Oyun mekaniðini kontrol etmek için sabitler ve deðiþkenler
        int boruHIZI = 8; // Borularýn hýzý
        int GRAVITY = 10; // Kuþun düþüþünü etkileyen yerçekimi
        int score = 0;    // Oyuncunun puaný

        public Form1()
        {
            InitializeComponent(); // Formu ve bileþenlerini baþlatýr
        }

        private void gameTimmerEvent(object sender, EventArgs e)
        {
            // Kuþun konumunu yerçekimine göre güncelle
            FlappyBird.Top += GRAVITY;
            // Borularý sola hareket ettir
            BoruAlt.Left -= boruHIZI;
            boruUst.Left -= boruHIZI;

            // Puan bilgisini güncelle
            scoreText.Text = "Puan: " + score;

            // Alt borunun ekrandan çýktýðýný kontrol et
            if (BoruAlt.Left < -150)
            {
                BoruAlt.Left = 800; // Boru konumunu saða sýfýrla
                score++; // Puaný artýr
            }

            // Üst borunun ekrandan çýktýðýný kontrol et
            if (boruUst.Left < -180)
            {
                boruUst.Left = 950; // Boru konumunu saða sýfýrla
                score++; // Puaný artýr
            }

            // Çarpýþmalarý veya kuþun ekrandan çýkmasýný kontrol et
            if (FlappyBird.Bounds.IntersectsWith(BoruAlt.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(boruUst.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(Zemin.Bounds) ||
                FlappyBird.Top < -25)
            {
                // Çarpýþma varsa oyunu bitir
                endGame();
            }

            // Puan 5'i geçtiðinde boru hýzýný artýr
            if (score > 5)
            {
                boruHIZI = 12; // Borularýn hýzýný artýr
            }

            // Kuþun belirli bir yüksekliðin altýna inmesi durumunda oyunu bitir
            if (FlappyBird.Top < 25)
            {
                endGame();
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            // Boþluk tuþu býrakýldýðýnda yerçekimini sýfýrla
            if (e.KeyCode == Keys.Space)
            {
                GRAVITY = 10; // Yerçekimini normal seviyeye getir
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            // Boþluk tuþuna basýldýðýnda yukarý itme kuvveti uygula
            if (e.KeyCode == Keys.Space)
            {
                GRAVITY = -10; // Kuþun yukarý çýkmasýný saðla
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Oyun durumu gibi baþlatma kodlarý
        }

        private void scoreText_Click(object sender, EventArgs e)
        {
            // Ýsteðe baðlý: Puan metni týklandýðýnda yapýlacak iþlemler
        }

        private void endGame()
        {
            GameTimmer.Stop(); // Ana zamanlayýcýyý durdur
            scoreText.Text = "Oyun Bitti !!!!"; // Puan metninde oyun bitti mesajýný göster
            this.KeyDown += new KeyEventHandler(restartGame); // Space tuþunu dinle
        }

        private void restartGame(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                score = 0; // Puaný sýfýrla
                boruHIZI = 8; // Hýzý baþlangýç deðerine getir
                FlappyBird.Top = 100; // Kuþun baþlangýç yüksekliði
                BoruAlt.Left = 800; // Boru konumlarýný sýfýrla
                boruUst.Left = 950;
                scoreText.Text = "Puan: " + score; // Puan metnini güncelle
                GameTimmer.Start(); // Zamanlayýcýyý yeniden baþlat
                this.KeyDown -= new KeyEventHandler(restartGame); // Tuþ dinleyiciyi kaldýr
            }
        }
    }
}
