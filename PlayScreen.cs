using System;
using System.Windows.Forms;

namespace X_O_Csharp_forms
{
    public partial class PlayScreen : Form
    {

        int step = 0;

        private void checkForWin()
        {

            if ((field1.Text == Settings.player1 && field2.Text == Settings.player1 && field3.Text == Settings.player1) || (field4.Text == Settings.player1 && field5.Text == Settings.player1 && field6.Text == Settings.player1) || (field7.Text == Settings.player1 && field8.Text == Settings.player1 && field9.Text == Settings.player1) || (field1.Text == Settings.player1 && field4.Text == Settings.player1 && field7.Text == Settings.player1) || (field2.Text == Settings.player1 && field5.Text == Settings.player1 && field8.Text == Settings.player1) || (field3.Text == Settings.player1 && field6.Text == Settings.player1 && field9.Text == Settings.player1) || (field1.Text == Settings.player1 && field5.Text == Settings.player1 && field9.Text == Settings.player1) || (field3.Text == Settings.player1 && field5.Text == Settings.player1 && field7.Text == Settings.player1))
            {
                MessageBox.Show("Player one won!\nNew game: Game --> New game");
                buttonsDisabled();

                if (settingsButton.Enabled == false)
                {
                    settingsButton.Enabled = true;
                }
            }
            else if ((field1.Text == Settings.player2 && field2.Text == Settings.player2 && field3.Text == Settings.player2) || (field4.Text == Settings.player2 && field5.Text == Settings.player2 && field6.Text == Settings.player2) || (field7.Text == Settings.player2 && field8.Text == Settings.player2 && field9.Text == Settings.player2) || (field1.Text == Settings.player2 && field4.Text == Settings.player2 && field7.Text == Settings.player2) || (field2.Text == Settings.player2 && field5.Text == Settings.player2 && field8.Text == Settings.player2) || (field3.Text == Settings.player2 && field6.Text == Settings.player2 && field9.Text == Settings.player2) || (field1.Text == Settings.player2 && field5.Text == Settings.player2 && field9.Text == Settings.player2) || (field3.Text == Settings.player2 && field5.Text == Settings.player2 && field7.Text == Settings.player2))
            {
                MessageBox.Show("Player two won!\nNew game: Game --> New game");
                buttonsDisabled();

                if (settingsButton.Enabled == false)
                {
                    settingsButton.Enabled = true;
                }
            }
            else if (step == 9)
            {
                MessageBox.Show("It's a draw!\nNew game: Game --> New game");
                buttonsDisabled();

                if (settingsButton.Enabled == false)
                {
                    settingsButton.Enabled = true;
                }
            }            
        }

        private void buttonsDisabled()
        {
            field1.Enabled = false;
            field2.Enabled = false;
            field3.Enabled = false;
            field4.Enabled = false;
            field5.Enabled = false;
            field6.Enabled = false;
            field7.Enabled = false;
            field8.Enabled = false;
            field9.Enabled = false;
        }

        private void buttonsEnabled()
        {
            field1.Enabled = true;
            field2.Enabled = true;
            field3.Enabled = true;
            field4.Enabled = true;
            field5.Enabled = true;
            field6.Enabled = true;
            field7.Enabled = true;
            field8.Enabled = true;
            field9.Enabled = true;
        }

        private void newGame()
        {

            step = 0;

            field1.Text = "";
            field2.Text = "";
            field3.Text = "";
            field4.Text = "";
            field5.Text = "";
            field6.Text = "";
            field7.Text = "";
            field8.Text = "";
            field9.Text = "";

            buttonsEnabled();

        }

        public PlayScreen()
        {
            InitializeComponent();
        }

        private void field1_Click(object sender, EventArgs e)
        {

            if (step % 2 == 0)
            {
                field1.Text = Settings.player1;
            }
            else
            {
                field1.Text = Settings.player2;
            }

            field1.Enabled = false;
            step++;

            if (settingsButton.Enabled == true)
            {
                settingsButton.Enabled = false;
            }

            checkForWin();

        }

        private void field2_Click(object sender, EventArgs e)
        {

            if (step % 2 == 0)
            {
                field2.Text = Settings.player1;
            }
            else
            {
                field2.Text = Settings.player2;
            }

            field2.Enabled = false;
            step++;

            if (settingsButton.Enabled == true)
            {
                settingsButton.Enabled = false;
            }

            checkForWin();

        }

        private void field3_Click(object sender, EventArgs e)
        {

            if (step % 2 == 0)
            {
                field3.Text = Settings.player1;
            }
            else
            {
                field3.Text = Settings.player2;
            }

            field3.Enabled = false;
            step++;

            if (settingsButton.Enabled == true)
            {
                settingsButton.Enabled = false;
            }

            checkForWin();

        }

        private void field4_Click(object sender, EventArgs e)
        {

            if (step % 2 == 0)
            {
                field4.Text = Settings.player1;
            }
            else
            {
                field4.Text = Settings.player2;
            }

            field4.Enabled = false;
            step++;

            if (settingsButton.Enabled == true)
            {
                settingsButton.Enabled = false;
            }

            checkForWin();

        }


        private void field5_Click(object sender, EventArgs e)
        {

            if (step % 2 == 0)
            {
                field5.Text = Settings.player1;
            }
            else
            {
                field5.Text = Settings.player2;
            }

            field5.Enabled = false;
            step++;

            if (settingsButton.Enabled == true)
            {
                settingsButton.Enabled = false;
            }

            checkForWin();

        }

        private void field6_Click(object sender, EventArgs e)
        {

            if (step % 2 == 0)
            {
                field6.Text = Settings.player1;
            }
            else
            {
                field6.Text = Settings.player2;
            }

            field6.Enabled = false;
            step++;

            if (settingsButton.Enabled == true)
            {
                settingsButton.Enabled = false;
            }

            checkForWin();

        }

        private void field7_Click(object sender, EventArgs e)
        {

            if (step % 2 == 0)
            {
                field7.Text = Settings.player1;
            }
            else
            {
                field7.Text = Settings.player2;
            }

            field7.Enabled = false;
            step++;

            if (settingsButton.Enabled == true)
            {
                settingsButton.Enabled = false;
            }

            checkForWin();

        }

        private void field8_Click(object sender, EventArgs e)
        {

            if (step % 2 == 0)
            {
                field8.Text = Settings.player1;
            }
            else
            {
                field8.Text = Settings.player2;
            }

            field8.Enabled = false;
            step++;

            if (settingsButton.Enabled == true)
            {
                settingsButton.Enabled = false;
            }

            checkForWin();

        }

        private void field9_Click(object sender, EventArgs e)
        {

            if (step % 2 == 0)
            {
                field9.Text = Settings.player1;
            }
            else
            {
                field9.Text = Settings.player2;
            }

            field9.Enabled = false;
            step++;

            if (settingsButton.Enabled == true)
            {
                settingsButton.Enabled = false;
            }

            checkForWin();

        }

        private void PlayScreen_Load(object sender, EventArgs e)
        {

            MessageBox.Show("To start this application normally, adjust the settings!\nHelp --> Settings");
            buttonsDisabled();
            gameButton.Enabled = false;

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

            Settings settings = new Settings();

            if (settings.ShowDialog() == DialogResult.OK)
            {
                buttonsEnabled();
                gameButton.Enabled = true;
                newGame();
            }

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {

            Info info = new Info();

            info.ShowDialog();

        }        
    }
}