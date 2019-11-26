using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_TheGame
{
    public partial class Form2 : Form
    {
        public Form2() => InitializeComponent();

        private void Accept_button_Click(object sender, EventArgs e)
        {
            Form1.SetPlayersName(p1_textBox.Text, p2_textBox.Text);
            this.Close();
        }
    }
}
