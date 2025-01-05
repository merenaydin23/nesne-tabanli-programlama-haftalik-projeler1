using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Show
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int true_number = 0; // Counter for true answers
        int false_number = 0; // Counter for false answers
        int question_number = 0; // Current question number

        private void button5_Click(object sender, EventArgs e)
        {
            // Enable answer buttons and disable skip button
            btnskip.Enabled = false;
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;

            // Hide result indicators and start picture
            pictureBoxfinish.Visible = false;
            pictureBoxred.Visible = false;
            pictureBoxgreen.Visible = false;
            pictureBoxStart.Visible = false;

            // Show start picture for the first question
            if (question_number == 0)
            {
                pictureBoxStart.Visible = true;
            }

            question_number++; // Increment question number
            lblqnumber.Text = question_number.ToString(); // Update question number label

            // Set question and answer choices based on the current question number
            if (question_number == 1)
            {
                richTextBox1.Text = "Where is the capital of Turkey?";
                btnc.Text = "Ankara";
                btnb.Text = "Bursa";
                btna.Text = "Istanbul";
                btnd.Text = "Izmir";
            }
            if (question_number == 2)
            {
                richTextBox1.Text = "Where is the largest population country?";
                btnc.Text = "China";
                btnb.Text = "India";
                btna.Text = "Russia";
                btnd.Text = "America";
            }
            if (question_number == 3)
            {
                richTextBox1.Text = "Which is the largest ocean in the world?";
                btnc.Text = "Atlantic Ocean";
                btnb.Text = "Indian Ocean";
                btna.Text = "Arctic Ocean";
                btnd.Text = "Pacific Ocean";
            }
        }

        private void btna_Click(object sender, EventArgs e)
        {
            // Disable answer buttons and enable skip button
            btnskip.Enabled = true;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

            // Hide result indicators and start picture
            pictureBoxred.Visible = false;
            pictureBoxgreen.Visible = false;
            pictureBoxStart.Visible = false;

            // Check the answer based on the current question number and update results
            if (question_number == 1)
            {
                false_number++;
                lblfalse.Text = false_number.ToString();
                pictureBoxred.Visible = true; // Red light for false answer
            }
            if (question_number == 2)
            {
                false_number++;
                lblfalse.Text = false_number.ToString();
                pictureBoxred.Visible = true; // Red light for false answer
            }
            if (question_number == 3)
            {
                false_number++;
                lblfalse.Text = false_number.ToString();
                pictureBoxred.Visible = true; // Red light for false answer
                pictureBoxfinish.Visible = true; // Show finish screen
                MessageBox.Show("Question Show Finished " + "\n" + "True Number : " + true_number + "\n" + "False Number : " + false_number);
            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            // Disable answer buttons and enable skip button
            btnskip.Enabled = true;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

            // Hide result indicators and start picture
            pictureBoxred.Visible = false;
            pictureBoxgreen.Visible = false;
            pictureBoxStart.Visible = false;

            // Check the answer based on the current question number and update results
            if (question_number == 1)
            {
                false_number++;
                lblfalse.Text = false_number.ToString();
                pictureBoxred.Visible = true; // Red light for false answer
            }
            if (question_number == 2)
            {
                false_number++;
                lblfalse.Text = false_number.ToString();
                pictureBoxred.Visible = true; // Red light for false answer
            }
            if (question_number == 3)
            {
                false_number++;
                lblfalse.Text = false_number.ToString();
                pictureBoxred.Visible = true; // Red light for false answer
                pictureBoxfinish.Visible = true; // Show finish screen
                MessageBox.Show("Question Show Finished " + "\n" + "True Number : " + true_number + "\n" + "False Number : " + false_number);
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            // Disable answer buttons and enable skip button
            btnskip.Enabled = true;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

            // Hide result indicators and start picture
            pictureBoxred.Visible = false;
            pictureBoxgreen.Visible = false;
            pictureBoxStart.Visible = false;

            // Check the answer based on the current question number and update results
            if (question_number == 1)
            {
                true_number++;
                lbltrue.Text = true_number.ToString();
                pictureBoxgreen.Visible = true; // Green light for true answer
            }
            if (question_number == 2)
            {
                true_number++;
                lbltrue.Text = true_number.ToString();
                pictureBoxgreen.Visible = true; // Green light for true answer
            }
            if (question_number == 3)
            {
                false_number++;
                lblfalse.Text = false_number.ToString();
                pictureBoxred.Visible = true; // Red light for false answer
                pictureBoxfinish.Visible = true; // Show finish screen
                MessageBox.Show("Question Show Finished " + "\n" + "True Number : " + true_number + "\n" + "False Number : " + false_number);
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            // Disable answer buttons and enable skip button
            btnskip.Enabled = true;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

            // Hide result indicators and start picture
            pictureBoxStart.Visible = false;
            pictureBoxred.Visible = false;
            pictureBoxgreen.Visible = false;

            // Check the answer based on the current question number and update results
            if (question_number == 1)
            {
                false_number++;
                lblfalse.Text = false_number.ToString();
                pictureBoxred.Visible = true; // Red light for false answer
            }
            if (question_number == 2)
            {
                false_number++;
                lblfalse.Text = false_number.ToString();
                pictureBoxred.Visible = true; // Red light for false answer
            }
            if (question_number == 3)
            {
                true_number++;
                lbltrue.Text = true_number.ToString();
                pictureBoxgreen.Visible = true; // Green light for true answer
                pictureBoxfinish.Visible = true; // Show finish screen
                MessageBox.Show("Question Show Finished " + "\n" + "True Number : " + true_number + "\n" + "False Number : " + false_number);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
