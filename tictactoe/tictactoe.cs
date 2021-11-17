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
    public partial class tictactoe : Form
    {
        public tictactoe()
        {
            InitializeComponent();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            textBoxComorP2.Text = "Computer";
            textBoxComorP2.Enabled = false;
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            textBoxComorP2.Text = "Enter Name:";
            textBoxComorP2.Enabled = true;
        }
    }
}
