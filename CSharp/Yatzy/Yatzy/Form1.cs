using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] Dices = new int[5];
        private int RollCount = 0;
        private int ScoreCount = 0;
        private Random random = new Random(Guid.NewGuid().GetHashCode());
        private void button1_Click(object sender, EventArgs e)
        {
            if (Roll.Text == "Roll")
            {
                pictureBox1.Visible = true;
                diceOne.Visible = false;
                diceTwo.Visible = false;
                diceThree.Visible = false;
                diceFour.Visible = false;
                diceFive.Visible = false;
                Roll.Text = "Stop";
            }
            else
            {
                pictureBox1.Visible = false;
                diceOne.Visible = true;
                diceTwo.Visible = true;
                diceThree.Visible = true;
                diceFour.Visible = true;
                diceFive.Visible = true;
                richTextBox1.Text = random.Next(1, 7).ToString();
                Dices[0] = Int32.Parse(richTextBox1.Text);
                richTextBox2.Text = random.Next(1, 7).ToString();
                Dices[1] = Int32.Parse(richTextBox2.Text);
                richTextBox3.Text = random.Next(1, 7).ToString();
                Dices[2] = Int32.Parse(richTextBox3.Text);
                richTextBox4.Text = random.Next(1, 7).ToString();
                Dices[3] = Int32.Parse(richTextBox4.Text);
                richTextBox5.Text = random.Next(1, 7).ToString();
                Dices[4] = Int32.Parse(richTextBox5.Text);
                Roll.Text = "Roll";
            }
            if (richTextBox1.Text == "1")
            {
                diceOne.Image = Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice1.png");
            }
            else if (richTextBox1.Text == "2")
            {
                diceOne.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice2.png");
            }
            else if (richTextBox1.Text == "3")
            {
                diceOne.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice3.png");
            }
            else if (richTextBox1.Text == "4")
            {
                diceOne.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice4.png");
            }
            else if (richTextBox1.Text == "5")
            {
                diceOne.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice5.png");
            }
            else if (richTextBox1.Text == "6")
            {
                diceOne.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice6.png");
            }


            if (richTextBox2.Text == "1")
            {
                diceTwo.Image = Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice1.png");
            }
            else if (richTextBox2.Text == "2")
            {
                diceTwo.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice2.png");
            }
            else if (richTextBox2.Text == "3")
            {
                diceTwo.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice3.png");
            }
            else if (richTextBox2.Text == "4")
            {
                diceTwo.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice4.png");
            }
            else if (richTextBox2.Text == "5")
            {
                diceTwo.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice5.png");
            }
            else if (richTextBox2.Text == "6")
            {
                diceTwo.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice6.png");
            }


            if (richTextBox3.Text == "1")
            {
                diceThree.Image = Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice1.png");
            }
            else if (richTextBox3.Text == "2")
            {
                diceThree.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice2.png");
            }
            else if (richTextBox3.Text == "3")
            {
                diceThree.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice3.png");
            }
            else if (richTextBox3.Text == "4")
            {
                diceThree.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice4.png");
            }
            else if (richTextBox3.Text == "5")
            {
                diceThree.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice5.png");
            }
            else if (richTextBox3.Text == "6")
            {
                diceThree.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice6.png");
            }


            if (richTextBox4.Text == "1")
            {
                diceFour.Image = Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice1.png");
            }
            else if (richTextBox4.Text == "2")
            {
                diceFour.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice2.png");
            }
            else if (richTextBox4.Text == "3")
            {
                diceFour.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice3.png");
            }
            else if (richTextBox4.Text == "4")
            {
                diceFour.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice4.png");
            }
            else if (richTextBox4.Text == "5")
            {
                diceFour.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice5.png");
            }
            else if (richTextBox4.Text == "6")
            {
                diceFour.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice6.png");
            }

            if (richTextBox5.Text == "1")
            {
                diceFive.Image = Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice1.png");
            }
            else if (richTextBox5.Text == "2")
            {
                diceFive.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice2.png");
            }
            else if (richTextBox5.Text == "3")
            {
                diceFive.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice3.png");
            }
            else if (richTextBox5.Text == "4")
            {
                diceFive.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice4.png");
            }
            else if (richTextBox5.Text == "5")
            {
                diceFive.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice5.png");
            }
            else if (richTextBox5.Text == "6")
            {
                diceFive.Image = (System.Drawing.Image)Image.FromFile(@"C:\Users\gatzakbob\Desktop\Hackathon\hackathon-competitive-ranch\CSharp\Yatzy\Yatzy\dice6.png");
            }
        }

        private void AcesButton_Click(object sender, EventArgs e)
        {
            if ((RollCount > 0) && (AcesScore.Text == ""))
            {
                int Score;// = TheScore.AddUpDice(1, Dices);

                string message = "The Total is " + Score.ToString() + ". Do you wish to accept this?";
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message,
                                  "Aces Total",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    AcesScore.Text = Score.ToString();
                    //TheScore.UpdateTotals(Score, true);
                    //Reset();
                }
            }
        }
       
    }

}