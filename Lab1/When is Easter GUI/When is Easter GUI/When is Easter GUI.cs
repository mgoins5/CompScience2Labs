namespace When_is_Easter_GUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // end method

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Calculate the day Easter falls on with the given year
            int year;
            string suffix = "";

            try
            {
                // 1 Get year from textbox

                year = int.Parse(YearTextBox.Text);

                // 2 Take the year and put it into the algorithm

                // Anonymous Gregorian Computus algorithm
                double a = year % 19;
                double b = Math.Floor(year / 100d); // I found dividing by 100d, instead of 100, here fixes the error and lets the program run
                double c = year % 100;
                double d = Math.Floor(b / 4);
                double ee = b % 4;
                double f = Math.Floor((b + 8) / (25));
                double g = Math.Floor((b - f + 1) / (3));
                double h = (19 * a + b - d - g + 15) % 30;
                double i = Math.Floor(c / 4);
                double k = c % 4;
                double l = (32 + 2 * ee + 2 * i - h - k) % 7;
                double m = Math.Floor((a + 11 * h + 22 * l) / 451);

                double month = Math.Floor((h + l - 7 * m + 114) / 31);
                double day = 1 + ((h + l - 7 * m + 114) % 31);

                // Check what number of month Easter falls in and store in a string.
                string monthOfEaster;

                if (month == 3)
                {
                    monthOfEaster = "March";
                }
                else if (month == 4)
                {
                    monthOfEaster = "April";
                }
                else
                {
                    throw new Exception("What's happening here?");
                } // end if

                switch (day)
                {
                    case 1:
                        suffix = "st";
                        break;
                    case 2:
                        suffix = "nd";
                        break;
                    case 3:
                        suffix = "rd";
                        break;
                    case >= 4:
                        suffix = "th";
                        break;
                } // end switch

                // 3 Output the day easter falls on

                string output = $"In {year}, Easter falls on {monthOfEaster} {day}{suffix}.";
                OutputLabel.Text = output;
            }
            catch
            {
                // display an error message if the user enters a bad value
                // change messagebox to use the output label
                // MessageBox.Show("Invalid Value: Please enter a valid number", "Fahrenheit to Celsius Converter");
                OutputLabel.Text = "Please enter a valid year.";
            }
            // select all to reenter new values easier
            YearTextBox.Focus();
            YearTextBox.SelectAll();
        } // end method
    } // end class
} // end namespace
