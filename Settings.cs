using System;
using System.Windows.Forms;

namespace X_O_Csharp_forms
{
    public partial class Settings : Form
    {

        public static string player1 = null;
        public static string player2 = null;

        public Settings()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            if ((playerOne.Text == "X" && playerTwo.Text == "O") || (playerOne.Text == "x" && playerTwo.Text == "o") || (playerOne.Text == "X" && playerTwo.Text == "o") || (playerOne.Text == "x" && playerTwo.Text == "O") || (playerOne.Text == "O" && playerTwo.Text == "X") || (playerOne.Text == "o" && playerTwo.Text == "x") || (playerOne.Text == "O" && playerTwo.Text == "x") || (playerOne.Text == "o" && playerTwo.Text == "X"))
            {
                player1 = playerOne.Text;
                player2 = playerTwo.Text;

                DialogResult = DialogResult.OK;

                this.Close();

            }
            else
            {
                MessageBox.Show("The only allowed signs are x and o, including uppercase and lowercase letters!\nEntered signs must not be the same, no matter if they are uppercase or lowercase letters!");
            }

        }
    }
}
