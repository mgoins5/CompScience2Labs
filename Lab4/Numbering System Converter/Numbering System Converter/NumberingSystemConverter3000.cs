namespace Numbering_System_Converter
{
    public partial class frmNumberingSystemConverter3000 : Form
    {
        const int ASCIICONVERSION = 48;
        public frmNumberingSystemConverter3000()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int convertedValue = 0; // store the total of the value we're converting
            int value; // stores the nummber converted from the ascii value
            int i = 0; // stores the position of the index of the
            try
            {
                convertedValue = int.Parse(txtFrom.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid value.", "Invalid Value", MessageBoxButtons.OK);
                txtFrom.SelectAll();
                txtFrom.Focus();
                return;
            } // end try

            if (cmbFromBase.SelectedIndex != 8)
            {
                convertedValue = 0;
            } // end if

            // convert to base 10 if not base 10
            if (cmbFromBase.SelectedIndex != 8)
            {
                // Loop through the numbers to convert to base 10.
                for (int j = txtFrom.TextLength - 1; j >= 0; j--)
                {
                    // subtract the difference for the ascii value to the actual value.
                    value = txtFrom.Text[i] - ASCIICONVERSION;
                    convertedValue += value * (int)Math.Pow(int.Parse(cmbFromBase.Text), j);
                    i++;
                } // end for
            } // end if

            // convert from base 10 to whatever base were going to
            int divisor = 0; // creating a variable to use later

            int dividend = (int)convertedValue; // set the initial value to be converted.

            // check if a value has been selected and assign it to the divisor variable
            if (cmbToBase.SelectedItem != null)
            {
                divisor = (int)cmbToBase.SelectedItem;
            } // end if

            // some variables to convert to the new base
            int quotient = 0;
            string output = string.Empty;

            // loop through at least once until quetient does not equal zero
            do
            {
                // Quotient in whole numbers
                quotient = dividend / divisor;

                // Building the remainder output
                output = $"{(dividend % divisor)}{output}";

                // Set the next dividend to the current quotient
                dividend = quotient;
            } while (quotient != 0); // end do while

            lblToOutput.Text = output;
        } // end method

        private void frmNumberingSystemConverter3000_Load(object sender, EventArgs e)
        {
            // add numbers to the comboboxes
            for (int i = 2; i <= 10; i++)
            {
                if (i >= 2 && i <= 10)
                {
                    cmbFromBase.Items.Add(i);
                } // end if
                if (i >= 2 && i <= 10)
                {
                    cmbToBase.Items.Add(i);
                } // end if
            } // end for

            // on load select 10 and 2 as default
            cmbFromBase.SelectedIndex = 8;
            cmbToBase.SelectedIndex = 0;
        } // end method

        private void cmbFromBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpConverter.Text = $"Converting from base {cmbFromBase.SelectedItem} " +
            $"to base {cmbToBase.SelectedItem}";
            txtFrom.Text = "";
            lblToOutput.Text = "";
        } // end method

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbFromBase.SelectedIndex = 8;
            cmbToBase.SelectedIndex = 0;
            txtFrom.Text = "";
            lblToOutput.Text = "";
            txtFrom.Focus();
        } // end method

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // end method
    } // end class
} // end namespace
