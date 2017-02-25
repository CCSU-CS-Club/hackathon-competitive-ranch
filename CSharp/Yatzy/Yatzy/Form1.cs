using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {             
            rollBox.Visible = true;
            diceOne.Visible = false;
            diceTwo.Visible = false;
            diceThree.Visible = false;
            diceFour.Visible = false;
            diceFive.Visible = false;
            Task.Delay(2000);
            rollBox.Visible = false;
            diceOne.Visible = true;
            diceTwo.Visible = true;
            diceThree.Visible = true;
            diceFour.Visible = true;
            diceFive.Visible = true;

        }
    }
}
