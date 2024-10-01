using System.CodeDom;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System;

namespace BMIGUI
{
    public partial class BMIGUI : Form
    {
        public BMIGUI()
        {
            InitializeComponent();
        } // end method

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // close the application when this button is clicked
            Application.Exit();
        } // end method

        private void ResetButton_Click(object sender, EventArgs e)
        {
            // when this button is clicked, perform the following:
            ImperialRadioButton.Checked = true;
            HeightTextBox.Text = string.Empty;
            WeightTextBox.Text = string.Empty;
            ResultLabel.Text = string.Empty;
            HeightTextBox.Focus();
        } // end method

        // change units depending on which measurement system is selected
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "cm";
            WeightUnitLabel.Text = "kg";
        } // end method

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "in";
            WeightUnitLabel.Text = "lb";
        } // end method

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // store some values in variables if they are numbers

            double bMI = 0;
            int height = 0;
            int weight = 0;
            // error code for error checking
            int error = 0;

            try
            {
                // try to convert the text to integers
                height = int.Parse(HeightTextBox.Text);
                // ccheck for negative numbers
                if (height <= 0)
                {
                    throw new Exception();
                } // end if
                // since height is good, we change the error code to align with weight.
                error = 1;
                weight = int.Parse(WeightTextBox.Text);
                // check for negative numbers
                if (weight <= 0)
                {
                    throw new Exception();
                } // end if
            }
            catch
            {
                // if there is an error, display a message and select the offending textbox.
                ResultLabel.Text = "Invalid height or weight. Please enter positive numeric values for both " +
                    "height and weight.";

                if (error == 0)
                {
                    HeightTextBox.Focus();
                    HeightTextBox.SelectAll();
                }
                else
                {
                    WeightTextBox.Focus();
                    WeightTextBox.SelectAll();
                } // end if
                Debug.WriteLine("The try/catch on line 72 caught this error.");
                return;
            } // end try

            // calculate bmi for either radio button. Cast one as a double to keep the decimal values
            if (ImperialRadioButton.Checked)
            {
                bMI = ((double)(weight) * 703 / (height * height));
                FillOutResultLabelText(height, weight, bMI);

            }
            else if (MetricRadioButton.Checked)
            {
                bMI = (((double)weight / height / height) * 10000);
                FillOutResultLabelText(height, weight, bMI);

            } // end if

            // based on their bMI, add additional information to the resultlabel.text
            switch (bMI) 
            {
                case < 18.5:
                    ResultLabel.Text += "You are underweight.";
                    break;

                case > 25:
                    ResultLabel.Text += "You are overweight.";
                    break;

                case >= 18.5:
                    ResultLabel.Text += "Your weight is optimal.";
                    break;
            } // end switch
        } // end method

        private void FillOutResultLabelText(int height, int weight, double bMI)
        {
            ResultLabel.Text = $"Based on a height of {height}{HeightUnitLabel.Text} and a weight " +
                        $"of {weight}{WeightUnitLabel.Text}, your BMI is {bMI:F1}. ";
        } // end method
    } // end class
} // end namespace