using System.Diagnostics;

namespace ElementaryMathTestGui
{
    // BUGS - Fixed all that I know of

    // bug 1 0 0 for operands is not happy. Maybe its the active form? Thats not the reason.
    // Old lab from cs1 has a loop if the right operator is 0 to get another...
    // this led to an infinite if the operator was modulus :/

    // bug 2 if you complete a test then do 0 0 it defaults to 0 9?? || Fixed? I think so
    public partial class frmElementaryMathTestGui : Form
    {
        private enum MathOperation
        {
            Addition = 0,
            Subtraction = 1,
            Multiplication = 2,
            Modulus = 3
        } // end enum

        bool takingTest = false; // value to see if a test is being taken to effectively disable the take test button
        bool takenTest = false; // value to see if a test has been taken to reset the form if the user selects to take another test
        int currentQuestion = 1; // tracks the current question
        int numberCorrect = 0; // Holds the number of questions answered correctly
        int userAnswer = 0;// holds the users answer to compare to the right answer later

        private static int _leftOperand;
        private static int _rightOperand;
        private static MathOperation _operation;
        private static int _operandMin;
        private static int _operandMax;

        // Constants
        public readonly static string[] POSITIVE_COMMENT = { "Correct!", "That's right!", "Yes!" };
        public readonly static string[] NEGATIVE_COMMENT = { "Incorrect.", "That's wrong.", "No." };
        public readonly static Random m_rnd = new Random();
        public frmElementaryMathTestGui()
        {
            InitializeComponent();
        } // end method

        private void btnTakeTest_Click(object sender, EventArgs e)
        {
            // check if a test is already being taken
            if (takingTest)
            {
                return;
            } // end if
            // before making the test, check if the minimum operand is less than the maximum operand
            if (nudMinimum.Value > nudMaximum.Value)
            {
                MessageBox.Show("Please make sure that the minimum operand is less than the maximum operand.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudMinimum.Focus();
                return;
            } // end if
            if (takenTest)
            {
                int i = (int)nudMinimum.Value;
                int j = (int)nudMaximum.Value;
                btnReset_Click(sender, e);
                nudMinimum.Value = i;
                nudMaximum.Value = j;
            } // end if

            _operandMin = (int)nudMinimum.Value;
            _operandMax = ((int)(nudMaximum.Value + 1));
            lblCurrentQuestionOutput.Text = GetProblem().ToString();
            takingTest = true;
            txtAnswer.Focus();
            txtAnswer.Clear();
            ActiveForm.AcceptButton = btnGradeAnswer;
        } // end method

        private void btnGradeAnswer_Click(object sender, EventArgs e)
        {
            // if the user has not clicked take test then do nothing if this button is clicked.
            if (takingTest == false)
            {
                return;
            } // end if

            // try to parse the user's input as an int to compare with the right answer.
            try
            {
                userAnswer = int.Parse(txtAnswer.Text); // Get answer from user
            }
            catch
            {
                MessageBox.Show("Please enter a whole number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnswer.SelectAll();
                return;
            } // end try

            int actualAnswer = GetAnswer(); // Get actual answer
            // Test if user's answer and actual answer are the same
            if (userAnswer == actualAnswer)
            {
                MessageBox.Show(GetPositiveComment());
                numberCorrect++; // Increment number of correct answers
                lblRightOutput.Text = (int.Parse(lblRightOutput.Text) + 1).ToString();
                DisplayStatistics();
            }
            else
            {
                MessageBox.Show(GetNegativeComment() + $"\n\nThe correct answer was {actualAnswer}.");
                lblWrongOutput.Text = (currentQuestion - numberCorrect).ToString();
                DisplayStatistics();
            } // end if

            if (currentQuestion > nudTotalQuestions.Value)
            {
                MessageBox.Show($"Congratulations! You finished with a score of {lblGradeOutput.Text}. Select " +
                    $"\"Take Test\" to start a new test or \"Exit\" to exit the application.", "Results");
                takingTest = false;
                takenTest = true;
                ActiveForm.AcceptButton = btnTakeTest;
            } // end if
        } // end method

        private void DisplayStatistics()
        {
            lblGradeOutput.Text = $"{((double)numberCorrect / currentQuestion):P0}";
            txtAnswer.Clear();
            txtAnswer.Focus();
            currentQuestion++;
            if (currentQuestion <= nudTotalQuestions.Value)
            {
                lblcurrentQuestion.Text = $"Question {currentQuestion}:";
                lblCurrentQuestionOutput.Text = GetProblem().ToString();
            } // end if
        } // end method

        private void nudTotalQuestions_ValueChanged(object sender, EventArgs e)
        {
            lblQuestionsOutput.Text = nudTotalQuestions.Value.ToString();
        } // end method

        private void btnReset_Click(object sender, EventArgs e)
        {
            nudTotalQuestions.Value = 10;
            nudMinimum.Value = 0;
            nudMaximum.Value = 9;
            lblRightOutput.Text = "0";
            lblWrongOutput.Text = "0";
            lblGradeOutput.Text = "100%";
            lblCurrentQuestionOutput.Text = "";
            lblcurrentQuestion.Text = "Question 1:";
            txtAnswer.Clear();
            currentQuestion = 1;
            takingTest = false;
            takenTest = false;
            numberCorrect = 0;
            nudTotalQuestions.Focus();
            ActiveForm.AcceptButton = btnTakeTest;
        } // end method

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // end method

        public static string GetProblem()
        {
            _leftOperand = GetOperand();
            _rightOperand = GetOperand();
            _operation = GetOperator();

            if (_operation == MathOperation.Modulus)
            {
                while (_rightOperand == 0)
                {
                    _rightOperand = GetOperand();
                } // end while
            } // end if

            string sign = string.Empty;
            switch (_operation)
            {
                case MathOperation.Addition:
                    sign = "+";
                    break;
                case MathOperation.Subtraction:
                    sign = "-";
                    break;
                case MathOperation.Multiplication:
                    sign = "X";
                    break;
                case MathOperation.Modulus:
                    sign = "%";
                    break;
                default:
                    Debug.Write("Something went wrong in the GetProblem section");
                    break;
            } // end switch
            return $"{_leftOperand} {sign} {_rightOperand} = ";
        } //end method

        public static int GetOperand()
        {
            Random rnd = new Random();
            return rnd.Next(_operandMin, _operandMax);
        } // end method

        private static MathOperation GetOperator()
        {
            Random rnd = new Random();
            return (MathOperation)rnd.Next(0, 4);
        } // end method

        public static int GetAnswer()
        {
            switch (_operation)
            {
                case MathOperation.Addition:
                    return _leftOperand + _rightOperand;
                case MathOperation.Subtraction:
                    return _leftOperand - _rightOperand;
                case MathOperation.Multiplication:
                    return _leftOperand * _rightOperand;
                case MathOperation.Modulus:
                    return _leftOperand % _rightOperand;
                default:
                    Debug.Write("Something went wrong in the GetAnswer section");
                    return 911;
            } // end switch
        } // end method

        public static string GetPositiveComment()
        {
            return POSITIVE_COMMENT[m_rnd.Next(POSITIVE_COMMENT.Length)]; // Return a random positive comment
        } // end method
        public static string GetNegativeComment()
        {
            return NEGATIVE_COMMENT[m_rnd.Next(NEGATIVE_COMMENT.Length)]; // Return a random negative comment
        } // end method
    } // end class
} // end namespace
