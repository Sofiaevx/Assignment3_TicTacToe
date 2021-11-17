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
        public Form1()
        {
            InitializeComponent();
        }

        private void bntone_Click(object sender, EventArgs e)
        {

            this.buttonOne.Text = "X";
            this.buttonOne.Enabled = false;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            this.buttonTwo.Text = "X";
            this.buttonThree.Enabled = false;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            this.buttonThree.Text = "X";
            this.buttonThree.Enabled = false;
        }

      
    }
}
