using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe_TheGame
{
    public partial class Form1 : Form
    {
        int x_win_count = 0, o_win_count = 0, draw_count = 0;
        bool turn = true; //ehen true - X turn, false - 0 turn
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void AboutMenuItem(object sender, EventArgs e) => MessageBox.Show("By SlavY Yurasov 2019", "Tic-Tac-Toe About");
        private void ExitMenuItem(object sender, EventArgs e) => Application.Exit();

        private void Button_click(object sender, EventArgs e) //нажатие на любую кнопку в поле игры
        {
            turnCount++;
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            b.Enabled = false; //выключаем "использованную" кнопку

            if (CheckForWinner()) //проверяем есть ли победитель
            {
                foreach (var button in Controls.OfType<Button>()) //выключаем все кнопки
                    button.Enabled = false;

                if (turn) //выводим победителя
                {
                    MessageBox.Show($"{p1_name.Text} Win!", "Yea!!");
                    p1_score.Text = (++x_win_count).ToString();
                }
                else
                {
                    MessageBox.Show($"{p2_name.Text} Win!", "Yea!");
                    p2_score.Text = (++o_win_count).ToString();
                }

                return;
            }
            if (turnCount == 9)
            {
                MessageBox.Show("Draw!", "Ouch!"); //ничья
                Draw_Count_label.Text = $"Draws = {++draw_count}";
            }
            turn = !turn; //передача хода
        }
        private void Mouse_enter(object sender, EventArgs e) //показываем чей ход Х или О на кнопке
        {
            Button b = (Button)sender;
            if (!b.Enabled) return; //если кнопка уже задействованная то ничего не делаем
            b.Text = turn ? "X" : "O";
        }
        private void Mouse_leave(object sender, EventArgs e) //при уходе мыши возвращаем все обратно
        {
            Button b = (Button)sender;
            if (b.Enabled) b.Text = "";
        }
        private void Reset_win_counts(object sender, EventArgs e) //сброс счета
        {
            x_win_count = o_win_count = draw_count = 0;
            Draw_Count_label.Text = $"Draws = {draw_count}";
            p1_score.Text = (x_win_count).ToString();
            p2_score.Text = (o_win_count).ToString();
            //NewGame_Click(null, null);
            newGameToolStripMenuItem.PerformClick();
        }


        private bool CheckForWinner()
        {
            //проверка горизонтальных рядов
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled)) return true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled)) return true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled)) return true;
            //поверка вертикальных рядов
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled)) return true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled)) return true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled)) return true;
            //проверка диагоналей
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled)) return true;
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled)) return true;
            return false;
        }

        private void NewGame_Click(object sender, EventArgs e) //новая игра
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
