namespace Quiz_Show
{
    partial class Form1
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
            this.btna = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblqnumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfalse = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltrue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnskip = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnd = new System.Windows.Forms.Button();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.pictureBoxfinish = new System.Windows.Forms.PictureBox();
            this.pictureBoxred = new System.Windows.Forms.PictureBox();
            this.pictureBoxgreen = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btna
            // 
            this.btna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btna.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btna.Location = new System.Drawing.Point(12, 251);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(153, 47);
            this.btna.TabIndex = 0;
            this.btna.Text = "A";
            this.btna.UseVisualStyleBackColor = false;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnc.Location = new System.Drawing.Point(12, 303);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(153, 47);
            this.btnc.TabIndex = 1;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnb
            // 
            this.btnb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnb.Location = new System.Drawing.Point(193, 251);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(153, 47);
            this.btnb.TabIndex = 2;
            this.btnb.Text = "B";
            this.btnb.UseVisualStyleBackColor = false;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Controls.Add(this.lblqnumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblfalse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbltrue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(397, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resaults";
            // 
            // lblqnumber
            // 
            this.lblqnumber.AutoSize = true;
            this.lblqnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblqnumber.Location = new System.Drawing.Point(229, 18);
            this.lblqnumber.Name = "lblqnumber";
            this.lblqnumber.Size = new System.Drawing.Size(30, 25);
            this.lblqnumber.TabIndex = 10;
            this.lblqnumber.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Question Number : ";
            // 
            // lblfalse
            // 
            this.lblfalse.AutoSize = true;
            this.lblfalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfalse.Location = new System.Drawing.Point(229, 92);
            this.lblfalse.Name = "lblfalse";
            this.lblfalse.Size = new System.Drawing.Size(24, 25);
            this.lblfalse.TabIndex = 8;
            this.lblfalse.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "False Number : ";
            // 
            // lbltrue
            // 
            this.lbltrue.AutoSize = true;
            this.lbltrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltrue.Location = new System.Drawing.Point(229, 53);
            this.lbltrue.Name = "lbltrue";
            this.lbltrue.Size = new System.Drawing.Size(24, 25);
            this.lbltrue.TabIndex = 6;
            this.lbltrue.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(55, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "True Number : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnskip);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(1, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 239);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Questions";
            // 
            // btnskip
            // 
            this.btnskip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnskip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnskip.Location = new System.Drawing.Point(76, 191);
            this.btnskip.Name = "btnskip";
            this.btnskip.Size = new System.Drawing.Size(173, 50);
            this.btnskip.TabIndex = 7;
            this.btnskip.Text = "Skip Question";
            this.btnskip.UseVisualStyleBackColor = false;
            this.btnskip.Click += new System.EventHandler(this.button5_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(339, 164);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnd
            // 
            this.btnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnd.Location = new System.Drawing.Point(193, 304);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(153, 47);
            this.btnd.TabIndex = 10;
            this.btnd.Text = "D";
            this.btnd.UseVisualStyleBackColor = false;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Image = global::Quiz_Show.Properties.Resources.start_21_5745;
            this.pictureBoxStart.Location = new System.Drawing.Point(397, 12);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(402, 215);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStart.TabIndex = 11;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxfinish
            // 
            this.pictureBoxfinish.Image = global::Quiz_Show.Properties.Resources.images;
            this.pictureBoxfinish.Location = new System.Drawing.Point(397, 13);
            this.pictureBoxfinish.Name = "pictureBoxfinish";
            this.pictureBoxfinish.Size = new System.Drawing.Size(396, 207);
            this.pictureBoxfinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxfinish.TabIndex = 12;
            this.pictureBoxfinish.TabStop = false;
            this.pictureBoxfinish.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxred
            // 
            this.pictureBoxred.Image = global::Quiz_Show.Properties.Resources.images__1_;
            this.pictureBoxred.Location = new System.Drawing.Point(397, 13);
            this.pictureBoxred.Name = "pictureBoxred";
            this.pictureBoxred.Size = new System.Drawing.Size(396, 206);
            this.pictureBoxred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxred.TabIndex = 9;
            this.pictureBoxred.TabStop = false;
            // 
            // pictureBoxgreen
            // 
            this.pictureBoxgreen.Image = global::Quiz_Show.Properties.Resources.images1;
            this.pictureBoxgreen.Location = new System.Drawing.Point(397, 13);
            this.pictureBoxgreen.Name = "pictureBoxgreen";
            this.pictureBoxgreen.Size = new System.Drawing.Size(396, 206);
            this.pictureBoxgreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxgreen.TabIndex = 8;
            this.pictureBoxgreen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(811, 360);
            this.Controls.Add(this.pictureBoxStart);
            this.Controls.Add(this.pictureBoxfinish);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.pictureBoxred);
            this.Controls.Add(this.pictureBoxgreen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btna);
            this.Name = "Form1";
            this.Text = "Quiz Show ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxgreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblfalse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltrue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnskip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxgreen;
        private System.Windows.Forms.PictureBox pictureBoxred;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Label lblqnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.PictureBox pictureBoxfinish;
    }
}

