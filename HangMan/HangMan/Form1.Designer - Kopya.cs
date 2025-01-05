namespace HangMan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnKelimeSeç = new Button();
            btntahmin = new Button();
            textboxTahmin = new TextBox();
            lblHak = new Label();
            lblHakSayı = new Label();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnF = new Button();
            btnÇ = new Button();
            btnG = new Button();
            btnĞ = new Button();
            btnH = new Button();
            btnI = new Button();
            btnİ = new Button();
            btnJ = new Button();
            btnK = new Button();
            btnL = new Button();
            btnM = new Button();
            btnN = new Button();
            btnO = new Button();
            btnÖ = new Button();
            btnP = new Button();
            btnR = new Button();
            btnS = new Button();
            btnŞ = new Button();
            btnT = new Button();
            btnU = new Button();
            btnÜ = new Button();
            btnV = new Button();
            btnY = new Button();
            btnZ = new Button();
            btnE = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // btnKelimeSeç
            // 
            btnKelimeSeç.BackColor = Color.FromArgb(255, 185, 185);
            btnKelimeSeç.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnKelimeSeç.ForeColor = Color.DarkBlue;
            btnKelimeSeç.Location = new Point(-2, 104);
            btnKelimeSeç.Name = "btnKelimeSeç";
            btnKelimeSeç.Size = new Size(184, 52);
            btnKelimeSeç.TabIndex = 0;
            btnKelimeSeç.Text = "Kelime Seç : ";
            btnKelimeSeç.UseVisualStyleBackColor = false;
            btnKelimeSeç.Click += button1_Click;
            // 
            // btntahmin
            // 
            btntahmin.BackColor = Color.FromArgb(255, 185, 185);
            btntahmin.Font = new Font("Arial", 12F, FontStyle.Bold);
            btntahmin.ForeColor = Color.DarkBlue;
            btntahmin.Location = new Point(-2, 162);
            btntahmin.Name = "btntahmin";
            btntahmin.Size = new Size(184, 44);
            btntahmin.TabIndex = 2;
            btntahmin.Text = "Tahmin Et : ";
            btntahmin.UseVisualStyleBackColor = false;
            btntahmin.Click += btntahmin_Click;
            // 
            // textboxTahmin
            // 
            textboxTahmin.Location = new Point(188, 166);
            textboxTahmin.Name = "textboxTahmin";
            textboxTahmin.Size = new Size(172, 38);
            textboxTahmin.TabIndex = 3;
            textboxTahmin.TextChanged += textboxTahmin_TextChanged;
            // 
            // lblHak
            // 
            lblHak.AutoSize = true;
            lblHak.BackColor = Color.FromArgb(255, 94, 94);
            lblHak.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblHak.ForeColor = Color.White;
            lblHak.Location = new Point(-2, 9);
            lblHak.Name = "lblHak";
            lblHak.Size = new Size(184, 29);
            lblHak.TabIndex = 4;
            lblHak.Text = "Kalan Hakkın : ";
            lblHak.Click += lblHak_Click;
            // 
            // lblHakSayı
            // 
            lblHakSayı.AutoSize = true;
            lblHakSayı.BackColor = Color.FromArgb(255, 94, 94);
            lblHakSayı.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblHakSayı.ForeColor = Color.White;
            lblHakSayı.Location = new Point(188, 9);
            lblHakSayı.Name = "lblHakSayı";
            lblHakSayı.Size = new Size(26, 29);
            lblHakSayı.TabIndex = 5;
            lblHakSayı.Text = "6";
            lblHakSayı.Click += lblHakSayı_Click;
            // 
            // btnA
            // 
            btnA.BackColor = Color.Orange;
            btnA.ForeColor = Color.White;
            btnA.Location = new Point(-2, 212);
            btnA.Name = "btnA";
            btnA.Size = new Size(57, 40);
            btnA.TabIndex = 6;
            btnA.Text = "a";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += button1_Click_1;
            // 
            // btnB
            // 
            btnB.AutoEllipsis = true;
            btnB.BackColor = Color.Orange;
            btnB.ForeColor = Color.White;
            btnB.Location = new Point(61, 212);
            btnB.Name = "btnB";
            btnB.Size = new Size(57, 40);
            btnB.TabIndex = 7;
            btnB.Text = "b";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Orange;
            btnC.ForeColor = Color.White;
            btnC.Location = new Point(125, 212);
            btnC.Name = "btnC";
            btnC.Size = new Size(57, 40);
            btnC.TabIndex = 8;
            btnC.Text = "c";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.BackColor = Color.Orange;
            btnD.ForeColor = Color.White;
            btnD.Location = new Point(251, 212);
            btnD.Name = "btnD";
            btnD.Size = new Size(57, 40);
            btnD.TabIndex = 9;
            btnD.Text = "d";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            // 
            // btnF
            // 
            btnF.BackColor = Color.Orange;
            btnF.ForeColor = Color.White;
            btnF.Location = new Point(-2, 258);
            btnF.Name = "btnF";
            btnF.Size = new Size(57, 40);
            btnF.TabIndex = 11;
            btnF.Text = "f";
            btnF.UseVisualStyleBackColor = false;
            btnF.Click += btnF_Click;
            // 
            // btnÇ
            // 
            btnÇ.BackColor = Color.Orange;
            btnÇ.ForeColor = Color.White;
            btnÇ.Location = new Point(188, 212);
            btnÇ.Name = "btnÇ";
            btnÇ.Size = new Size(57, 40);
            btnÇ.TabIndex = 12;
            btnÇ.Text = "ç";
            btnÇ.UseVisualStyleBackColor = false;
            btnÇ.Click += btnÇ_Click;
            // 
            // btnG
            // 
            btnG.BackColor = Color.Orange;
            btnG.ForeColor = Color.White;
            btnG.Location = new Point(61, 258);
            btnG.Name = "btnG";
            btnG.Size = new Size(57, 40);
            btnG.TabIndex = 13;
            btnG.Text = "g";
            btnG.UseVisualStyleBackColor = false;
            btnG.Click += btnG_Click;
            // 
            // btnĞ
            // 
            btnĞ.AutoEllipsis = true;
            btnĞ.BackColor = Color.Orange;
            btnĞ.ForeColor = Color.White;
            btnĞ.Location = new Point(124, 258);
            btnĞ.Name = "btnĞ";
            btnĞ.Size = new Size(57, 40);
            btnĞ.TabIndex = 14;
            btnĞ.Text = "ğ";
            btnĞ.UseVisualStyleBackColor = false;
            btnĞ.Click += btnĞ_Click;
            // 
            // btnH
            // 
            btnH.BackColor = Color.Orange;
            btnH.ForeColor = Color.White;
            btnH.Location = new Point(187, 258);
            btnH.Name = "btnH";
            btnH.Size = new Size(57, 40);
            btnH.TabIndex = 15;
            btnH.Text = "h";
            btnH.UseVisualStyleBackColor = false;
            btnH.Click += btnH_Click;
            // 
            // btnI
            // 
            btnI.BackColor = Color.Orange;
            btnI.ForeColor = Color.White;
            btnI.Location = new Point(250, 258);
            btnI.Name = "btnI";
            btnI.Size = new Size(57, 40);
            btnI.TabIndex = 16;
            btnI.Text = "ı";
            btnI.UseVisualStyleBackColor = false;
            btnI.Click += btnI_Click;
            // 
            // btnİ
            // 
            btnİ.BackColor = Color.Orange;
            btnİ.ForeColor = Color.White;
            btnİ.Location = new Point(313, 258);
            btnİ.Name = "btnİ";
            btnİ.Size = new Size(57, 40);
            btnİ.TabIndex = 17;
            btnİ.Text = "i";
            btnİ.UseVisualStyleBackColor = false;
            btnİ.Click += btnİ_Click;
            // 
            // btnJ
            // 
            btnJ.BackColor = Color.Orange;
            btnJ.ForeColor = Color.White;
            btnJ.Location = new Point(-2, 304);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(57, 40);
            btnJ.TabIndex = 18;
            btnJ.Text = "j";
            btnJ.UseVisualStyleBackColor = false;
            btnJ.Click += btnJ_Click;
            // 
            // btnK
            // 
            btnK.BackColor = Color.Orange;
            btnK.ForeColor = Color.White;
            btnK.Location = new Point(61, 304);
            btnK.Name = "btnK";
            btnK.Size = new Size(57, 40);
            btnK.TabIndex = 19;
            btnK.Text = "k";
            btnK.UseVisualStyleBackColor = false;
            btnK.Click += btnK_Click;
            // 
            // btnL
            // 
            btnL.BackColor = Color.Orange;
            btnL.ForeColor = Color.White;
            btnL.Location = new Point(125, 304);
            btnL.Name = "btnL";
            btnL.Size = new Size(57, 40);
            btnL.TabIndex = 20;
            btnL.Text = "l";
            btnL.UseVisualStyleBackColor = false;
            btnL.Click += btnL_Click;
            // 
            // btnM
            // 
            btnM.BackColor = Color.Orange;
            btnM.ForeColor = Color.White;
            btnM.Location = new Point(188, 304);
            btnM.Name = "btnM";
            btnM.Size = new Size(57, 40);
            btnM.TabIndex = 21;
            btnM.Text = "m";
            btnM.UseVisualStyleBackColor = false;
            btnM.Click += btnM_Click;
            // 
            // btnN
            // 
            btnN.BackColor = Color.Orange;
            btnN.ForeColor = Color.White;
            btnN.Location = new Point(250, 304);
            btnN.Name = "btnN";
            btnN.Size = new Size(57, 40);
            btnN.TabIndex = 22;
            btnN.Text = "n";
            btnN.UseVisualStyleBackColor = false;
            btnN.Click += btnN_Click;
            // 
            // btnO
            // 
            btnO.BackColor = Color.Orange;
            btnO.ForeColor = Color.White;
            btnO.Location = new Point(314, 304);
            btnO.Name = "btnO";
            btnO.Size = new Size(57, 40);
            btnO.TabIndex = 23;
            btnO.Text = "o";
            btnO.UseVisualStyleBackColor = false;
            btnO.Click += btnO_Click;
            // 
            // btnÖ
            // 
            btnÖ.BackColor = Color.Orange;
            btnÖ.ForeColor = Color.White;
            btnÖ.Location = new Point(-2, 350);
            btnÖ.Name = "btnÖ";
            btnÖ.Size = new Size(57, 40);
            btnÖ.TabIndex = 24;
            btnÖ.Text = "ö";
            btnÖ.UseVisualStyleBackColor = false;
            btnÖ.Click += btnÖ_Click;
            // 
            // btnP
            // 
            btnP.BackColor = Color.Orange;
            btnP.ForeColor = Color.White;
            btnP.Location = new Point(62, 350);
            btnP.Name = "btnP";
            btnP.Size = new Size(57, 40);
            btnP.TabIndex = 25;
            btnP.Text = "p";
            btnP.UseVisualStyleBackColor = false;
            btnP.Click += btnP_Click;
            // 
            // btnR
            // 
            btnR.BackColor = Color.Orange;
            btnR.ForeColor = Color.White;
            btnR.Location = new Point(124, 350);
            btnR.Name = "btnR";
            btnR.Size = new Size(57, 40);
            btnR.TabIndex = 26;
            btnR.Text = "r";
            btnR.UseVisualStyleBackColor = false;
            btnR.Click += btnR_Click;
            // 
            // btnS
            // 
            btnS.BackColor = Color.Orange;
            btnS.ForeColor = Color.White;
            btnS.Location = new Point(188, 350);
            btnS.Name = "btnS";
            btnS.Size = new Size(57, 40);
            btnS.TabIndex = 27;
            btnS.Text = "s";
            btnS.UseVisualStyleBackColor = false;
            btnS.Click += btnS_Click;
            // 
            // btnŞ
            // 
            btnŞ.BackColor = Color.Orange;
            btnŞ.ForeColor = Color.White;
            btnŞ.Location = new Point(250, 350);
            btnŞ.Name = "btnŞ";
            btnŞ.Size = new Size(57, 40);
            btnŞ.TabIndex = 28;
            btnŞ.Text = "ş";
            btnŞ.UseVisualStyleBackColor = false;
            btnŞ.Click += btnŞ_Click;
            // 
            // btnT
            // 
            btnT.BackColor = Color.Orange;
            btnT.ForeColor = Color.White;
            btnT.Location = new Point(314, 350);
            btnT.Name = "btnT";
            btnT.Size = new Size(57, 40);
            btnT.TabIndex = 29;
            btnT.Text = "t";
            btnT.UseVisualStyleBackColor = false;
            btnT.Click += btnT_Click;
            // 
            // btnU
            // 
            btnU.BackColor = Color.Orange;
            btnU.ForeColor = Color.White;
            btnU.Location = new Point(-2, 396);
            btnU.Name = "btnU";
            btnU.Size = new Size(57, 40);
            btnU.TabIndex = 30;
            btnU.Text = "u";
            btnU.UseVisualStyleBackColor = false;
            btnU.Click += btnU_Click;
            // 
            // btnÜ
            // 
            btnÜ.BackColor = Color.Orange;
            btnÜ.ForeColor = Color.White;
            btnÜ.Location = new Point(62, 396);
            btnÜ.Name = "btnÜ";
            btnÜ.Size = new Size(57, 40);
            btnÜ.TabIndex = 31;
            btnÜ.Text = "ü";
            btnÜ.UseVisualStyleBackColor = false;
            btnÜ.Click += btnÜ_Click;
            // 
            // btnV
            // 
            btnV.BackColor = Color.Orange;
            btnV.ForeColor = Color.White;
            btnV.Location = new Point(124, 396);
            btnV.Name = "btnV";
            btnV.Size = new Size(57, 40);
            btnV.TabIndex = 32;
            btnV.Text = "v";
            btnV.UseVisualStyleBackColor = false;
            btnV.Click += btnV_Click;
            // 
            // btnY
            // 
            btnY.BackColor = Color.Orange;
            btnY.ForeColor = Color.White;
            btnY.Location = new Point(188, 396);
            btnY.Name = "btnY";
            btnY.Size = new Size(57, 40);
            btnY.TabIndex = 33;
            btnY.Text = "y";
            btnY.UseVisualStyleBackColor = false;
            btnY.Click += button28_Click;
            // 
            // btnZ
            // 
            btnZ.BackColor = Color.Orange;
            btnZ.ForeColor = Color.White;
            btnZ.Location = new Point(251, 396);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(57, 40);
            btnZ.TabIndex = 34;
            btnZ.Text = "z";
            btnZ.UseVisualStyleBackColor = false;
            btnZ.Click += btnZ_Click;
            // 
            // btnE
            // 
            btnE.BackColor = Color.Orange;
            btnE.ForeColor = Color.White;
            btnE.Location = new Point(314, 212);
            btnE.Name = "btnE";
            btnE.Size = new Size(57, 40);
            btnE.TabIndex = 10;
            btnE.Text = "e";
            btnE.UseVisualStyleBackColor = false;
            btnE.Click += btnE_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(458, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 440);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(458, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(431, 443);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(458, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(431, 443);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 37;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(458, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(431, 443);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 38;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(458, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(431, 443);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 39;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(458, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(431, 440);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 40;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(458, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(431, 440);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 41;
            pictureBox7.TabStop = false;
            pictureBox7.Visible = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(910, 450);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnZ);
            Controls.Add(btnY);
            Controls.Add(btnV);
            Controls.Add(btnÜ);
            Controls.Add(btnU);
            Controls.Add(btnT);
            Controls.Add(btnŞ);
            Controls.Add(btnS);
            Controls.Add(btnR);
            Controls.Add(btnP);
            Controls.Add(btnÖ);
            Controls.Add(btnO);
            Controls.Add(btnN);
            Controls.Add(btnM);
            Controls.Add(btnL);
            Controls.Add(btnK);
            Controls.Add(btnJ);
            Controls.Add(btnİ);
            Controls.Add(btnI);
            Controls.Add(btnH);
            Controls.Add(btnĞ);
            Controls.Add(btnG);
            Controls.Add(btnÇ);
            Controls.Add(btnF);
            Controls.Add(btnE);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(lblHakSayı);
            Controls.Add(lblHak);
            Controls.Add(textboxTahmin);
            Controls.Add(btntahmin);
            Controls.Add(btnKelimeSeç);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Hang Man";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button btnKelimeSeç;
        private Button btntahmin;
        private TextBox textboxTahmin;
        private Label lblHak;
        private Label lblHakSayı;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnF;
        private Button btnÇ;
        private Button btnG;
        private Button btnĞ;
        private Button btnH;
        private Button btnI;
        private Button btnİ;
        private Button btnJ;
        private Button btnK;
        private Button btnL;
        private Button btnM;
        private Button btnN;
        private Button btnO;
        private Button btnÖ;
        private Button btnP;
        private Button btnR;
        private Button btnS;
        private Button btnŞ;
        private Button btnT;
        private Button btnU;
        private Button btnÜ;
        private Button btnV;
        private Button btnY;
        private Button btnZ;
        private Button btnE;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}