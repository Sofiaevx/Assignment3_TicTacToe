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
    public partial class Form2 : Form
    {
        public static string player1;
        public static string player2;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            player1 = Convert.ToString(textBoxPlayer1.Text);
            player2 = Convert.ToString(textBoxPlayer2.Text);
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
