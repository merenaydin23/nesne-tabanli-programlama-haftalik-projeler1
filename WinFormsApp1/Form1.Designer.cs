namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BoruAlt = new PictureBox();
            FlappyBird = new PictureBox();
            Zemin = new PictureBox();
            boruUst = new PictureBox();
            scoreText = new Label();
            GameTimmer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)BoruAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FlappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boruUst).BeginInit();
            SuspendLayout();
            // 
            // BoruAlt
            // 
            BoruAlt.Image = (Image)resources.GetObject("BoruAlt.Image");
            BoruAlt.Location = new Point(563, 212);
            BoruAlt.Name = "BoruAlt";
            BoruAlt.Size = new Size(52, 160);
            BoruAlt.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruAlt.TabIndex = 0;
            BoruAlt.TabStop = false;
            // 
            // FlappyBird
            // 
            FlappyBird.Image = (Image)resources.GetObject("FlappyBird.Image");
            FlappyBird.Location = new Point(12, 57);
            FlappyBird.Name = "FlappyBird";
            FlappyBird.Size = new Size(65, 51);
            FlappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            FlappyBird.TabIndex = 1;
            FlappyBird.TabStop = false;
            // 
            // Zemin
            // 
            Zemin.Image = (Image)resources.GetObject("Zemin.Image");
            Zemin.Location = new Point(-16, 360);
            Zemin.Name = "Zemin";
            Zemin.Size = new Size(886, 62);
            Zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            Zemin.TabIndex = 2;
            Zemin.TabStop = false;
            // 
            // boruUst
            // 
            boruUst.Image = (Image)resources.GetObject("boruUst.Image");
            boruUst.Location = new Point(687, 0);
            boruUst.Name = "boruUst";
            boruUst.Size = new Size(55, 87);
            boruUst.SizeMode = PictureBoxSizeMode.StretchImage;
            boruUst.TabIndex = 3;
            boruUst.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(12, 385);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(166, 37);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score : 0 ";
            scoreText.Click += scoreText_Click;
            // 
            // GameTimmer
            // 
            GameTimmer.Enabled = true;
            GameTimmer.Interval = 20;
            GameTimmer.Tick += gameTimmerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(858, 421);
            Controls.Add(FlappyBird);
            Controls.Add(scoreText);
            Controls.Add(boruUst);
            Controls.Add(Zemin);
            Controls.Add(BoruAlt);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            ((System.ComponentModel.ISupportInitialize)BoruAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)FlappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)boruUst).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BoruAlt;
        private PictureBox FlappyBird;
        private PictureBox Zemin;
        private PictureBox boruUst;
        private Label scoreText;
        private System.Windows.Forms.Timer GameTimmer;
    }
}
