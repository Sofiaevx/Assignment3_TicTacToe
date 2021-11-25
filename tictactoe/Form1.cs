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
        int P1 = 0;
        int P2 = 0;
        int drawcount = 0;
        public Form1()
        {
            InitializeComponent();
           label2.Text = Form2.player1;
            label3.Text = Form2.player2;
        }

        private void btnonetonine(object sender, EventArgs e)
        {
         
            Button bt1to9 = (Button)sender;
            if (turns)
            {
                bt1to9.Text = "X";
                drawcount++;
            }
            else
            {
                bt1to9.Text = "O";
            }
            turns = !turns;
            bt1to9.Enabled = false;
            bt1to9.ForeColor = System.Drawing.Color.Black;
            gamechecker();
        }
       
private void gamechecker()
        { 
            //Vertical Line Combinations//
         if ((buttonone.Text == buttonFour.Text) && (buttonFour.Text == buttonSeven.Text)&&(!buttonone.Enabled)) 
            {
                if (buttonone.Text == labelXo.Text)
                {
                    MessageBox.Show(label2.Text + " Winner!!!");
                    P1++;
                }
                else
                {
                    MessageBox.Show(label3.Text + " Winner!!!");
                    P2++;
                }
                newgamebutton.PerformClick();
            }
         if ((buttonTwo.Text == buttonFive.Text) && (buttonFive.Text == buttonEigth.Text)&&(!buttonTwo.Enabled))
            {
                if (buttonTwo.Text == labelXo.Text)
                {
                    MessageBox.Show(label2.Text + " Winner!!!");
                    P1++;
                }
                else
                {
                    MessageBox.Show(label3.Text + " Winner!!!");
                    P2++;
                }
                newgamebutton.PerformClick();
            }
            if ((buttonThree.Text == buttonSix.Text) && (buttonSix.Text == buttonNine.Text) && (!buttonThree.Enabled))
            {
                if (buttonThree.Text == labelXo.Text)
                {
                    MessageBox.Show(label2.Text + " Winner!!!");
                    P1++;
                }
                else
                {
                    MessageBox.Show(label3.Text + " Winner!!!");
                    P2++;
                }
                newgamebutton.PerformClick();
            }

            //Horizontal Line Combinations//
            if ((buttonone.Text == buttonTwo.Text) && (buttonTwo.Text == buttonThree.Text) && (!buttonone.Enabled))
            {
                if (buttonone.Text == labelXo.Text)
                {
                    MessageBox.Show(label2.Text + " Winner!!!");
                    P1++;
                }
                else
                {
                    MessageBox.Show(label3.Text + " Winner!!!");
                    P2++;
                }
                newgamebutton.PerformClick();
            }
            if ((buttonFour.Text == buttonFive.Text) && (buttonFive.Text == buttonSix.Text) && (!buttonFour.Enabled))
            {
                if (buttonFour.Text == labelXo.Text)
                {
                    MessageBox.Show(label2.Text + " Winner!!!");
                    P1++;
                }
                else
                {
                    MessageBox.Show(label3.Text + " Winner!!!");
                    P2++;
                }
                newgamebutton.PerformClick();
            }
            if ((buttonSeven.Text == buttonEigth.Text) && (buttonEigth.Text == buttonNine.Text) && (!buttonSeven.Enabled))
            {
                if (buttonSeven.Text == labelXo.Text)
                {
                    MessageBox.Show(label2.Text + " Winner!!!");
                    P1++;
                }
                else
                {
                    MessageBox.Show(label3.Text + " Winner!!!");
                    P2++;
                }
                newgamebutton.PerformClick();
            }

            //Diagonal Line Combinations//
            if ((buttonone.Text == buttonFive.Text) && (buttonFive.Text == buttonNine.Text) && (!buttonone.Enabled))
            {
                if (buttonone.Text == labelXo.Text)
                {
                    MessageBox.Show(label2.Text + " Winner!!!");
                    P1++;
                }
                else
                {
                    MessageBox.Show(label3.Text + " Winner!!!");
                    P2++;
                }
                newgamebutton.PerformClick();
            }
            if ((buttonThree.Text == buttonFive.Text) && (buttonFive.Text == buttonSeven.Text) && (!buttonThree.Enabled))
            {
                if (buttonThree.Text == labelXo.Text)
                {
                    MessageBox.Show(label2.Text + " Winner!!!");
                    P1++;
                }
                else
                {
                    MessageBox.Show(label3.Text + " Winner!!!");
                    P2++;
                }
                newgamebutton.PerformClick();
            }
            if (drawcount == 5)
            {
                MessageBox.Show(" Draw ");
                newgamebutton.PerformClick();
            }
           
        }

        private void picker()
        {
            Random rnd1 = new Random();
            int randNum = rnd1.Next(1, 100);
            if (randNum % 2 == 0)
            {
                labelXo.Text = "X";
                labelOx.Text = "O";
               
            }
            else
            {
                labelXo.Text = "O";
                labelOx.Text = "X";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picker();
        }

        private void newgamebutton_Click(object sender, EventArgs e)
        {
            buttonone.Enabled = true;
            buttonTwo.Enabled = true;
            buttonThree.Enabled = true;
            buttonFour.Enabled = true;
            buttonFive.Enabled = true;
            buttonSix.Enabled = true;
            buttonSeven.Enabled = true;
            buttonEigth.Enabled = true;
            buttonNine.Enabled = true;

            buttonone.Text = "";
            buttonTwo.Text = "";
            buttonThree.Text = "";
            buttonFour.Text = "";
            buttonFive.Text = "";
            buttonSix.Text = "";
            buttonSeven.Text = "";
            buttonEigth.Text = "";
            buttonNine.Text = "";
            turns = true;
            drawcount = 0;
            P1score.Text = Convert.ToString(P1);
            P2score.Text = Convert.ToString(P2);
            picker();
        }

        private void P1score_Click(object sender, EventArgs e)
        {

        }
    }
}