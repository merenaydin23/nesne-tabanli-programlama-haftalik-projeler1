namespace ArabaYarisi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSariAraba1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSariAraba3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSariAraba2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxKirmiziAraba = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSariAraba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSariAraba3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSariAraba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKirmiziAraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(182, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 107);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(182, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 107);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(182, 334);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 107);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxSariAraba1
            // 
            this.pictureBoxSariAraba1.Image = global::ArabaYarisi.Properties.Resources.indir;
            this.pictureBoxSariAraba1.Location = new System.Drawing.Point(60, 34);
            this.pictureBoxSariAraba1.Name = "pictureBoxSariAraba1";
            this.pictureBoxSariAraba1.Size = new System.Drawing.Size(41, 53);
            this.pictureBoxSariAraba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSariAraba1.TabIndex = 3;
            this.pictureBoxSariAraba1.TabStop = false;
            this.pictureBoxSariAraba1.Tag = "enemyCar";
            // 
            // pictureBoxSariAraba3
            // 
            this.pictureBoxSariAraba3.Image = global::ArabaYarisi.Properties.Resources.indir;
            this.pictureBoxSariAraba3.Location = new System.Drawing.Point(60, 222);
            this.pictureBoxSariAraba3.Name = "pictureBoxSariAraba3";
            this.pictureBoxSariAraba3.Size = new System.Drawing.Size(41, 53);
            this.pictureBoxSariAraba3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSariAraba3.TabIndex = 4;
            this.pictureBoxSariAraba3.TabStop = false;
            this.pictureBoxSariAraba3.Tag = "enemyCar";
            // 
            // pictureBoxSariAraba2
            // 
            this.pictureBoxSariAraba2.Image = global::ArabaYarisi.Properties.Resources.indir;
            this.pictureBoxSariAraba2.Location = new System.Drawing.Point(263, 34);
            this.pictureBoxSariAraba2.Name = "pictureBoxSariAraba2";
            this.pictureBoxSariAraba2.Size = new System.Drawing.Size(41, 53);
            this.pictureBoxSariAraba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSariAraba2.TabIndex = 5;
            this.pictureBoxSariAraba2.TabStop = false;
            this.pictureBoxSariAraba2.Tag = "enemyCar";
            // 
            // pictureBoxKirmiziAraba
            // 
            this.pictureBoxKirmiziAraba.Image = global::ArabaYarisi.Properties.Resources.png_transparent_sports_car_bird_s_eye_view_race_car_car_color_vehicle;
            this.pictureBoxKirmiziAraba.Location = new System.Drawing.Point(250, 334);
            this.pictureBoxKirmiziAraba.Name = "pictureBoxKirmiziAraba";
            this.pictureBoxKirmiziAraba.Size = new System.Drawing.Size(41, 53);
            this.pictureBoxKirmiziAraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKirmiziAraba.TabIndex = 7;
            this.pictureBoxKirmiziAraba.TabStop = false;
            // 
            // pictureBoxCoin1
            // 
            this.pictureBoxCoin1.Image = global::ArabaYarisi.Properties.Resources.game_coin_a_good_investment;
            this.pictureBoxCoin1.Location = new System.Drawing.Point(123, 125);
            this.pictureBoxCoin1.Name = "pictureBoxCoin1";
            this.pictureBoxCoin1.Size = new System.Drawing.Size(69, 50);
            this.pictureBoxCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCoin1.TabIndex = 8;
            this.pictureBoxCoin1.TabStop = false;
            this.pictureBoxCoin1.Tag = "coin";
            // 
            // pictureBoxCoin2
            // 
            this.pictureBoxCoin2.Image = global::ArabaYarisi.Properties.Resources.game_coin_a_good_investment;
            this.pictureBoxCoin2.Location = new System.Drawing.Point(255, 203);
            this.pictureBoxCoin2.Name = "pictureBoxCoin2";
            this.pictureBoxCoin2.Size = new System.Drawing.Size(69, 50);
            this.pictureBoxCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCoin2.TabIndex = 9;
            this.pictureBoxCoin2.TabStop = false;
            this.pictureBoxCoin2.Tag = "coin";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(304, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 17);
            this.lblScore.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBoxCoin2);
            this.Controls.Add(this.pictureBoxCoin1);
            this.Controls.Add(this.pictureBoxKirmiziAraba);
            this.Controls.Add(this.pictureBoxSariAraba2);
            this.Controls.Add(this.pictureBoxSariAraba3);
            this.Controls.Add(this.pictureBoxSariAraba1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSariAraba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSariAraba3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSariAraba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKirmiziAraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxSariAraba1;
        private System.Windows.Forms.PictureBox pictureBoxSariAraba3;
        private System.Windows.Forms.PictureBox pictureBoxSariAraba2;
        private System.Windows.Forms.PictureBox pictureBoxKirmiziAraba;
        private System.Windows.Forms.PictureBox pictureBoxCoin1;
        private System.Windows.Forms.PictureBox pictureBoxCoin2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timerGame;
    }
}

