using System.Windows.Forms;

namespace HangMan

   {

    public partial class Form1 : Form
    {
        string rastgeleIl; // Sınıf düzeyinde rastgele il değişkeni
        public Form1()
        {
            InitializeComponent();
        }
        int hak = 6;

        bool kelimeTamamlandi = false;
        // Bu tahmin edilen harfin olup olamam durununu bulan ve ona göre butonların renkini belirleyen metod
        private void HarfTahminEt(char harf, Button buton)
        {
            // Rastgele ilin içindeki harfleri kontrol et
            if (rastgeleIl.ToLower().Contains(harf.ToString().ToLower()))
            {
                // Harf bulunursa buton rengini yeşil yap
                buton.BackColor = System.Drawing.Color.Green;

                // Harfin bulunduğu TextBox'ları görünür yap
                for (int i = 0; i < rastgeleIl.Length; i++)
                {
                    TextBox textBox = (TextBox)this.Controls["textBox" + i];
                    if (rastgeleIl[i].ToString().ToLower() == harf.ToString().ToLower())
                    {
                        textBox.Visible = true;
                        textBox.Text = rastgeleIl[i].ToString();
                    }
                }

                // Kelime tamamlandı mı kontrolü
                kelimeTamamlandi = true;
                for (int i = 0; i < rastgeleIl.Length; i++)
                {
                    TextBox textBox = (TextBox)this.Controls["textBox" + i];
                    if (textBox.Text != rastgeleIl[i].ToString())
                    {
                        kelimeTamamlandi = false;
                        break;
                    }
                }

                if (kelimeTamamlandi)
                {
                    MessageBox.Show("Tebrikler! Kelimeyi buldunuz!", "Tebrikler!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Exit();
                }
            }
            else
            {
                // Harf bulunamazsa buton rengini kırmızı yap
                buton.BackColor = System.Drawing.Color.Red;
                hak--;
                lblHakSayı.Text = hak.ToString();

                // Hak değeri 0 ise
                if (hak == 0)
                {
                    // Önce resmi görünür yap
                    pictureBox7.Visible = true;

                    // Bir süre beklemeden sonra mesajı göster
                    MessageBox.Show("Maalesef kaybettiniz! Doğru kelime: " + rastgeleIl + "\nAdam asıldı!", "Üzgünüz!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit(); // Uygulamayı kapat
                }
                else if (hak == 1)
                {
                    // Hak 1 olduğunda son resmi göster
                    for (int i = 1; i <= 6; i++)
                    {
                        PictureBox pictureBox = (PictureBox)this.Controls["pictureBox" + i];
                        pictureBox.Visible = false; // Hepsini gizle
                    }
                    pictureBox6.Visible = true; // pictureBox6'yı görünür yap
                    MessageBox.Show("Son tahmin! Bir harf daha denemelisiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Hak 2 ile 6 arasında ise ilgili resmi görünür yap
                    for (int i = 1; i <= 6; i++)
                    {
                        PictureBox pictureBox = (PictureBox)this.Controls["pictureBox" + i];
                        pictureBox.Visible = false; // Hepsini gizle
                    }
                    PictureBox currentPictureBox = (PictureBox)this.Controls["pictureBox" + (7 - hak)];
                    currentPictureBox.Visible = true; // İlgili resmi görünür yap
                }
            }

            // Butonu devre dışı bırak
            buton.Enabled = false;
        }










        private void button1_Click(object sender, EventArgs e)
        {
            // Türkiye'deki 81 ili içeren bir dizi tanımlanıyor
            string[] iller = new string[]
            {
                "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya",
                "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik",
                "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
                "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ",
                "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
                "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir",
                "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri",
                "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya",
                "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş",
                "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya",
                "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat",
                "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yalova",
                "Yozgat", "Zonguldak"
            };

            // Rastgele sayı üretmek için Random sınıfından bir örnek oluşturuluyor
            Random rand = new Random();

            // Dizinin uzunluğu kadar rastgele bir indeks üretiliyor
            int index = rand.Next(0, iller.Length); // 0 ile iller.Length - 1 arasında rastgele bir sayı

            // Sınıf düzeyindeki rastgeleIl'e atama yapılıyor
            rastgeleIl = iller[index]; // Rastgele il seçildi

            int x = -2; // TextBox'ın x eksenindeki başlangıç konumu 
            for (int i = 0; i < rastgeleIl.Length; i++)
            {
                // TextBox oluşturma
                TextBox textBox = new TextBox();

                // TextBox'ın konumunu ayarlama
                textBox.Location = new System.Drawing.Point(x, 54);
                x += 43; // x koordinatını artır

                // TextBox'ın boyutunu ayarlama (isteğe bağlı)
                textBox.Size = new System.Drawing.Size(46, 38);

                // TextBox'ın adını ayarlama
                textBox.Name = "textBox" + i; // Örneğin: textBox0, textBox1, ...

                // TextBox'ı forma ekleme
                this.Controls.Add(textBox);
            }
            btnKelimeSeç.Enabled = false; // Kelime seçme butonunu devre dışı bırak
        }

        private void btntahmin_Click(object sender, EventArgs e)
        {
            string tahmin = textboxTahmin.Text; // Kullanıcı tahmini alınıyor
            if (tahmin.ToLower() == rastgeleIl.ToLower()) // Büyük-küçük harf kontrolü
            {
                MessageBox.Show("😊 Güler yüz! Kazandınız!");
                Application.Exit(); // Uygulamayı kapat
            }
            else
            {

                MessageBox.Show("😢 Maalesef kaybettiniz! Doğru Kelime : " + rastgeleIl);
                Application.Exit(); // Uygulamayı kapat
            }
        }

        private void textboxTahmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            HarfTahminEt('D', (Button)sender); // 'D' harfini tahmin et
        }

        private void button28_Click(object sender, EventArgs e)
        {
            HarfTahminEt('Y', (Button)sender); // 'Y' harfini tahmin et
        }

        private void btnŞ_Click(object sender, EventArgs e)
        {
            HarfTahminEt('Ş', (Button)sender); // 'Ş' harfini tahmin et
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HarfTahminEt('A', (Button)sender); // 'A' harfini tahmin et
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            HarfTahminEt('B', (Button)sender); // 'B' harfini tahmin et
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            HarfTahminEt('C', (Button)sender); // 'C' harfini tahmin et
        }

        private void btnÇ_Click(object sender, EventArgs e)
        {
            HarfTahminEt('Ç', (Button)sender); // 'Ç' harfini tahmin et
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            HarfTahminEt('E', (Button)sender); // 'E' harfini tahmin et
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            HarfTahminEt('F', (Button)sender); // 'F' harfini tahmin et
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            HarfTahminEt('G', (Button)sender); // 'G' harfini tahmin et
        }

        private void btnĞ_Click(object sender, EventArgs e)
        {
            HarfTahminEt('Ğ', (Button)sender); // 'Ğ' harfini tahmin et
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            HarfTahminEt('H', (Button)sender); // 'H' harfini tahmin et
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            HarfTahminEt('I', (Button)sender); // 'I' harfini tahmin et
        }

        private void btnİ_Click(object sender, EventArgs e)
        {
            HarfTahminEt('İ', (Button)sender); // 'İ' harfini tahmin et
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            HarfTahminEt('J', (Button)sender); // 'J' harfini tahmin et
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            HarfTahminEt('K', (Button)sender); // 'K' harfini tahmin et
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            HarfTahminEt('L', (Button)sender); // 'L' harfini tahmin et
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            HarfTahminEt('M', (Button)sender); // 'M' harfini tahmin et
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            HarfTahminEt('N', (Button)sender); // 'N' harfini tahmin et
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            HarfTahminEt('O', (Button)sender); // 'O' harfini tahmin et
        }

        private void btnÖ_Click(object sender, EventArgs e)
        {
            HarfTahminEt('Ö', (Button)sender); // 'Ö' harfini tahmin et
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            HarfTahminEt('P', (Button)sender); // 'P' harfini tahmin et
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            HarfTahminEt('R', (Button)sender); // 'R' harfini tahmin et
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            HarfTahminEt('S', (Button)sender); // 'S' harfini tahmin et
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            HarfTahminEt('T', (Button)sender); // 'T' harfini tahmin et
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            HarfTahminEt('U', (Button)sender); // 'U' harfini tahmin et
        }

        private void btnÜ_Click(object sender, EventArgs e)
        {
            HarfTahminEt('Ü', (Button)sender); // 'Ü' harfini tahmin et
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            HarfTahminEt('V', (Button)sender); // 'V' harfini tahmin et
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            HarfTahminEt('Z', (Button)sender); // 'Z' harfini tahmin et
        }

        private void lblHakSayı_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (hak == 6)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }
        }

        private void lblHak_Click(object sender, EventArgs e)
        {

        }
    }
}