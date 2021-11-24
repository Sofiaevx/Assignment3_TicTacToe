using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool turns = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnonetonine(object sender, EventArgs e)
        {
         
            Button bt1to9 = (Button)sender;
            if (turns)
            {
                bt1to9.Text = "X";
            }
            else
            {
                bt1to9.Text = "O";
            }
            turns = !turns;
            bt1to9.Enabled = false;
            gamechecker();
        }
        private void gamechecker()
        { 
            //Vertical Line Combinations//
         if ((buttonone.Text == buttonFour.Text) && (buttonFour.Text == buttonSeven.Text)&&(!buttonone.Enabled)) 
            {
                MessageBox.Show("Winner!!");
            }
         if ((buttonTwo.Text == buttonFive.Text) && (buttonFive.Text == buttonEigth.Text)&&(!buttonTwo.Enabled))
            {
                MessageBox.Show("Winner!!");
            }
         if ((buttonThree.Text == buttonSix.Text) && (buttonSix.Text == buttonNine.Text) && (!buttonThree.Enabled))
            {
                MessageBox.Show("Winner!!");
            }

            //Horizontal Line Combinations//
         if ((buttonone.Text == buttonTwo.Text) && (buttonTwo.Text == buttonThree.Text) && (!buttonone.Enabled))
            {
                MessageBox.Show("Winner!!");
            }
         if ((buttonFour.Text == buttonFive.Text) && (buttonFive.Text == buttonSix.Text) && (!buttonFour.Enabled))
            {
                MessageBox.Show("Winner!!");
            }
         if ((buttonSeven.Text == buttonEigth.Text) && (buttonEigth.Text == buttonNine.Text) && (!buttonSeven.Enabled))
            {
                MessageBox.Show("Winner!!");
            }

            //Diagonal Line Combinations//
         if ((buttonone.Text == buttonFive.Text) && (buttonFive.Text == buttonNine.Text) && (!buttonone.Enabled))
            {
                MessageBox.Show("Winner!!");
            }
         if ((buttonThree.Text == buttonFive.Text) && (buttonFive.Text == buttonSeven.Text) && (!buttonThree.Enabled))
            {
                MessageBox.Show("Winner!!");
            }

        }
    }
}