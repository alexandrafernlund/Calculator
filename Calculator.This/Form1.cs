namespace Calculator.This
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // deklarerar variabler
        double num1, num2, result;
        char operation;

        // ny metod för changeLabel
        private void changeLabel(int numPressed)
        {
        
            {
                if (label1.Text.Equals("0") == true && label1.Text != null)
                {
                    label1.Text = numPressed.ToString();
                }
                
                else

                {
                    label1.Text = label1.Text + numPressed.ToString();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void zeroButton_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(label1.Text);
            operation = '%';
            result = result % num1;
            label1.Text = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(label1.Text);
            operation = '+';
            result = result + num1;
            label1.Text = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(label1.Text);
            operation = '-';
            result = result - num1;
            label1.Text = "";
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(label1.Text);
            operation = '*';
            result = result * num1;
            label1.Text = "";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(label1.Text);
            operation = '/';
            result = result / num1;
            label1.Text = "";
        }

        private void squarerootButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(label1.Text);
            if (num1 > 0)
            {
                double sqrt = Math.Sqrt(num1);
                label1.Text = sqrt.ToString();
            }
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            int stringLenght = label1.Text.Length;
            if (stringLenght > 1)
            {
                label1.Text = label1.Text.Substring(0, stringLenght - 1);
            }
            else
            {
                label1.Text = "0";
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            result = '0';
            if (label1.Text.Equals("0") == false)
            {
                switch (operation)
                {
                    case '+':
                        num2 = float.Parse(label1.Text);
                        result = num1 + num2;
                        break;
                    case '-':
                        num2 = float.Parse(label1.Text);
                        result = num1 - num2;
                        break;
                    case '/':
                        num2 = float.Parse(label1.Text);
                        result = num1 / num2;
                        break;
                    case '*':
                        num2 = float.Parse(label1.Text);
                        result = num1 * num2;
                        break;
                    default:
                        break;
                }
            }
            label1.Text = result.ToString();
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = '\0';
            
        }

    }
}