namespace Tic_Tac_Toe_Single
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        //need a random for the CPU
        Random rnd = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void CPUmove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                //here the random CPU mover with timer
                int index = rnd.Next(buttons.Count);
                buttons[index].Enabled= false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.Coral;
                buttons.RemoveAt(index);
                CheckGame();
                CPUTimer.Stop();
            }

        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;

            currentPlayer = Player.X;
            button.Text= currentPlayer.ToString();
            button.Enabled= false;
            button.BackColor = Color.Aqua;
            buttons.Remove(button);
            CheckGame();
            counter++;
            CPUTimer.Start();
        }

        private void RestartGame(object sender, EventArgs e)
        {
       
            RestartGame();
        }

        private void CheckGame()
        {
            //vertical check
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                //horizontal check
                || button1.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button4.Text == "X" && button7.Text == "X"
                //diagonal check
                || button1.Text == "X" && button5.Text == "X" && button7.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                
                CPUTimer.Stop();
                MessageBox.Show("The player is win!","RESULTS");
                playerWinCount++;
                label1.Text = "Player Wins:" + playerWinCount;
                RestartGame();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                //horizontal check
                || button1.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button4.Text == "O" && button7.Text == "O"
                //diagonal check
                || button1.Text == "O" && button5.Text == "O" && button7.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("The CPU is win!", "RESULTS");
                CPUWinCount++;
                label1.Text = "Player Wins:" + CPUWinCount;
                RestartGame();

            }


        }

        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5,
            button6, button7, button8, button9 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "+";
                x.BackColor = DefaultBackColor;
            }
        }
    }
}