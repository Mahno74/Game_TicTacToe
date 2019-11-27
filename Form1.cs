using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe_TheGame
{
    public partial class Form1 : Form
    {
        static string player1_name, player2_name;
        int x_win_count = 0, o_win_count = 0, draw_count = 0;
        bool turn = true; //ehen true - X turn, false - 0 turn
        bool against_computer = false;
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
            player1_select.PerformClick();
        }

        private void AboutMenuItem(object sender, EventArgs e) => MessageBox.Show("By SlavY Yurasov 2019", "Tic-Tac-Toe About");
        private void ExitMenuItem(object sender, EventArgs e) => Application.Exit();

        private void Button_click(object sender, EventArgs e) //clicking on any button in the game field

        {
            turnCount++;
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            b.Enabled = false; //turn off the "used" button

            if (CheckForWinner()) //check if there is a winner
            {
                foreach (var button in Controls.OfType<Button>()) //turn off all buttons
                    button.Enabled = false;

                if (turn) //show the winner
                {
                    MessageBox.Show($"{player1_name} Win!", "Yea!!");
                    X_WinCount_label.Text = $"{player1_name} wins = {++x_win_count}";
                }
                else
                {
                    MessageBox.Show($"{player2_name} Win!", "Yea!");
                    O_WinCount_label.Text = $"{player2_name} wins = {++o_win_count}";
                }

                return;
            }
            if (turnCount == 9)
            {
                MessageBox.Show("Draw!", "Ouch!"); //draw
                Draw_Count_label.Text = $"Draws = {++draw_count}";
                return;
            }
            turn = !turn; //next turn
            if ((!turn) && (against_computer))
            {
                Computer_make_move();
            }
        }
        private void Computer_make_move()
        {
            // priority 1: collect your row and win
            // priority 2: block the row with "X"
            // priority 3: set center
            // priority 4: occupy corners
            // priority 5: take up free space
            Button move = null;
            // Search for opportunities
            move = Look_for_win_or_block("O"); // 1
            if (move == null)
            {
                move = Look_for_win_or_block("X"); // 2
                if (move == null)
                {
                    move = Look_for_center(); // 3
                    if (move == null)
                    {
                        move = Look_for_corner(); //4
                        if (move == null)
                        {
                            move = Look_for_open_space(); //5
                        }
                    }
                }
            }
            move.PerformClick();
        }

        private Button Look_for_win_or_block(string v)
        {
            //Horizontal seek
            if ((A1.Text == v) && (A2.Text == v) && (A3.Text == "")) return A3;
            if ((A1.Text == v) && (A2.Text == "") && (A3.Text == v)) return A2;
            if ((A1.Text == "") && (A2.Text == v) && (A3.Text == v)) return A1;

            if ((B1.Text == v) && (B2.Text == v) && (B3.Text == "")) return B3;
            if ((B1.Text == v) && (B2.Text == "") && (B3.Text == v)) return B2;
            if ((B1.Text == "") && (B2.Text == v) && (B3.Text == v)) return B1;

            if ((C1.Text == v) && (C2.Text == v) && (C3.Text == "")) return C3;
            if ((C1.Text == v) && (C2.Text == "") && (C3.Text == v)) return C2;
            if ((C1.Text == "") && (C2.Text == v) && (C3.Text == v)) return C1;

            //Vertical seek
            if ((A1.Text == v) && (B1.Text == v) && (C1.Text == "")) return C1;
            if ((A1.Text == v) && (B1.Text == "") && (C1.Text == v)) return B1;
            if ((A1.Text == "") && (B1.Text == v) && (C1.Text == v)) return A1;

            if ((A2.Text == v) && (B2.Text == v) && (C2.Text == "")) return C2;
            if ((A2.Text == v) && (B2.Text == "") && (C2.Text == v)) return B2;
            if ((A2.Text == "") && (B2.Text == v) && (C2.Text == v)) return A2;

            if ((A3.Text == v) && (B3.Text == v) && (C3.Text == "")) return C3;
            if ((A3.Text == v) && (B3.Text == "") && (C3.Text == v)) return B3;
            if ((A3.Text == "") && (B3.Text == v) && (C3.Text == v)) return A3;

            // Diagonal seek
            if ((A1.Text == v) && (B2.Text == v) && (C3.Text == "")) return C3;
            if ((A1.Text == v) && (B2.Text == "") && (C3.Text == v)) return B2;
            if ((A1.Text == "") && (B2.Text == v) && (C3.Text == v)) return A1;

            if ((A3.Text == v) && (B2.Text == v) && (C1.Text == "")) return C1;
            if ((A3.Text == v) && (B2.Text == "") && (C1.Text == v)) return B2;
            if ((A3.Text == "") && (B2.Text == v) && (C1.Text == v)) return A3;

            return null;
        }
        private Button Look_for_center()
        {
            if (B2.Text == "") return B2;
            return null;
        }
        private Button Look_for_corner()
        {
            //return priority corner (oppozite)
            if (A1.Text == "O")
            {
                if (A3.Text == "") return A3;
                if (C1.Text == "") return C1;
                if (C3.Text == "") return C3;
            }
            if (A3.Text == "O")
            {
                if (A1.Text == "") return A1;
                if (C1.Text == "") return C1;
                if (C3.Text == "") return C3;
            }
            if (C1.Text == "O")
            {
                if (A1.Text == "") return A1;
                if (A3.Text == "") return A3;
                if (C3.Text == "") return C3;
            }
            if (C3.Text == "O")
            {
                if (A1.Text == "") return A1;
                if (A3.Text == "") return A3;
                if (C1.Text == "") return C1;
            }

            // or return any space corner
            if (A1.Text == "") return A1;
            if (A3.Text == "") return A3;
            if (C1.Text == "") return C1;
            if (C3.Text == "") return C3;

            return null;
        }
        private Button Look_for_open_space()
        {
            foreach (var button in Controls.OfType<Button>())
            {
                if (button.Text == "") return button;
            }
            return null;
        }

        private void Mouse_enter(object sender, EventArgs e) // show whose move X or O on the button
        {
            Button b = (Button)sender;
            if (!b.Enabled) return; // if the button is already enabled, then do nothing
            b.Text = turn ? "X" : "O";
        }
        private void Mouse_leave(object sender, EventArgs e) //when leaving the mouse, we return everything back
        {
            Button b = (Button)sender;
            if (b.Enabled) b.Text = "";
        }
        private void Reset_win_counts(object sender, EventArgs e) // reset score
        {
            x_win_count = o_win_count = draw_count = 0;
            Draw_Count_label.Text = $"Draws = {draw_count}";
            p1_score.Text = (x_win_count).ToString();
            p2_score.Text = (o_win_count).ToString();
            newGameToolStripMenuItem.PerformClick();
        }

        private void Player2_select_Click(object sender, EventArgs e)
        {
            player1_select.Checked = false; player2_select.Checked = true;
            p2_name.Text = "Player 2"; p2_name.Enabled = true; against_computer = false;
        }

        private void Player1_select_Click(object sender, EventArgs e)
        {
            player1_select.Checked = true; player2_select.Checked = false;
            p2_name.Text = "COMPUTER"; p2_name.Enabled = false; against_computer = true;
        }

        private bool CheckForWinner()
        {
            // check horizontal rows
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled)) return true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled)) return true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled)) return true;
            // check vertical rows
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled)) return true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled)) return true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled)) return true;
            // check diagonals rows
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled)) return true;
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled)) return true;
            return false;
        }

        private void NewGame_Click(object sender, EventArgs e) // new game
        {
            turn = true; turnCount = 0;
            foreach (var button in Controls.OfType<Button>())
            {
                button.Enabled = true;
                button.Text = "";
            }
        }
    }
}
