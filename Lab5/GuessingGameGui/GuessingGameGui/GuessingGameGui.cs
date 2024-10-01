using System.Security.Cryptography;

namespace GuessingGameGui
{
    public partial class frmGuessingGameGui : Form
    {
        // pick a random number for the "correct answer"
        Random rnd = new Random();
        bool hasAnswer = false;
        int correctAnswer = 0;
        int incorrectGuesses = 0;
        int numbersRemaining = 100;
        public frmGuessingGameGui()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // end method

        private void frmGuessingGameGui_Load(object sender, EventArgs e)
        {
            // output status to the user
            stblOutput.Text = "Pick a number to guess!";

            for (int i = 1; i <= 100; i++)
            {
                lstOutput.Items.Add(i);
            } // end for
        } // end method

        private void lstOutput_Click(object sender, EventArgs e)
        {
            if (hasAnswer == false)
            {
                correctAnswer = rnd.Next(1, 101);
                hasAnswer = true;
            } // end if

            // if they click a list item and that item is not an empty space...
            if (lstOutput.SelectedIndex >= 0 && lstOutput.SelectedItem != "")
            {

                if (lstOutput.SelectedItem.Equals(correctAnswer))
                {
                    MessageBox.Show($"The correct number was {correctAnswer}, and you found it after " +
                    $"{incorrectGuesses + 1} attempt(s). Play again or exit through the file menu.", "Congratulations!!!");
                    // once the correct answer is found reset the game and stop executing code.
                    resetGame(sender, e);
                    return;
                } // end if
                // store the selected index into a variable for use later
                int i = lstOutput.SelectedIndex + 1;
                lstOutput.Items.Remove(lstOutput.SelectedItem);
                // https://stackoverflow.com/questions/10284952/c-sharp-way-to-add-value-in-a-listt-at-index
                // source as I could not find insert in the book
                lstOutput.Items.Insert((i - 1), "");
                // keep track of the amount of incorrect guesses and numbers remaining
                incorrectGuesses++;
                lblIncorrectGuessesOutput.Text = incorrectGuesses.ToString();
                numbersRemaining--;
                lblNumbersRemainingOutput.Text = numbersRemaining.ToString();
                // give hints as to where the answer is
                if (i > correctAnswer)
                {
                    stblOutput.Text = "The correct answer is lower than the selected option.";
                }
                else
                {
                    stblOutput.Text = "The correct answer is higher than the selected option.";
                } // end if
            } // end if
        } // end method

        private void mnuFileNewGame_Click(object sender, EventArgs e)
        {
            resetGame(sender, e);
        } // end method

        private void resetGame(object sender, EventArgs e)
        {
            // clear the list and reset all the variables then reload the "game"
            lstOutput.Items.Clear();
            hasAnswer = false;
            correctAnswer = 0;
            incorrectGuesses = 0;
            lblIncorrectGuessesOutput.Text = incorrectGuesses.ToString();
            numbersRemaining = 100;
            lblNumbersRemainingOutput.Text = numbersRemaining.ToString();
            frmGuessingGameGui_Load(sender, e);
        } // end method
    } // end class
} // end namespace
