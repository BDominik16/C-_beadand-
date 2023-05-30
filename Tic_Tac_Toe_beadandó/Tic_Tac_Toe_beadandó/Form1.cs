using System.ComponentModel;
using System.Reflection;

namespace Tic_Tac_Toe_beadandó
{
    public partial class Form1 : Form
    {
        bool multi = false;

        bool turner = true;  //egyszerően váltogatom az egyes gombokat true és false értékek között 
                             //X= true O= false
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Bolgár Dominik \n Neptun code: AAH5X1", "Tic Tac Toe Game");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turner)
                button.Text= "X";
            
            else
                button.Text = "O";

                turner = !turner;
                button.Enabled = false;
                counter++;
                Winner();

        }

        private void Winner()
        {

            //vertical check
            bool this_winner = false;

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                this_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                this_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                this_winner = true;


            //diagonal check
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                this_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                this_winner = true;

            //horizontal check

            else if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                this_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                this_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                this_winner = true;

            if (this_winner)
            {
                dis_button();
                String winner = "";
                if (turner)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show("The winner is: " + winner);
            }
            else
            {
                if (counter == 9)
                {
                    MessageBox.Show("This is draw!");
                }
            }

        }

        private void dis_button()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;
            turner= true;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }
    }
}