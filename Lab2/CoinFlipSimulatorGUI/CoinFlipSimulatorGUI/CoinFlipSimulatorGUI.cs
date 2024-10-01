namespace CoinFlipSimulatorGUI
{
    public partial class CoinFlipSimulatorGUI : Form
    {
        public CoinFlipSimulatorGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // variables to hold numbers
            int heads = 0;
            int tails = 0;
            // if something fails we hold a value and if there is a value have a notification sent
            int error = 0;
            // get the value that the user has entered. Default is 1000.
            int total = (int)ValueNumUpDown.Value;
            // create a Random object
            Random rnd = new Random();

            // loop through the flips until the total is reached
            for (int i = 0; i < total; i++)
            {
                // for each loop get either a 0 or 1
                int j = rnd.Next(0, 2);

                // if 0 increment heads, if 1 increment tails, if anything else make the error known
                if (j == 0)
                {
                    heads++;
                }
                else if (j == 1)
                {
                    tails++;
                }
                else
                {
                    error++;
                } // end if

                if (error > 0)
                {
                    Console.Error.WriteLine("There is an error");
                } // end if

                // once the total is reached, output the results to the respective labels
                if (i == total - 1)
                {
                    HeadsLabel.Text = heads.ToString() + "\n" + $"({(decimal)heads / total:P1})";
                    TailsLabel.Text = tails.ToString() + "\n" + $"({(decimal)tails / total:P1})";
                } // end if
            } // end for
        } // end method
    } // end class
} // end namespace
