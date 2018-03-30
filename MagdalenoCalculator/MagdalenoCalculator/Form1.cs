using System;
using System.Windows.Forms;


namespace MagdalenoCalculator
{
    public partial class Form1 : Form
    {
        private double operationTotal = 0;
        private char previousOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Operator_Pressed(object sender, EventArgs e)
        {
            // An operator was pressed; perform the last operation and store the new operator.
            char operation = (sender as Button).Text[0];
            if (operation == 'C')
            {
                operationTotal = 0;
            }
            else
            {
                double currentValue = double.Parse(displayBox.Text); 
                switch (previousOperation) //switches for operation button cases
                {
                    case '+': operationTotal += currentValue; break;
                    case '-': operationTotal -= currentValue; break;
                    case '×': operationTotal *= currentValue; break;
                    case '÷': operationTotal /= currentValue; break;
                    default: operationTotal = currentValue; break;
                }
            }

            previousOperation = operation;
            displayBox.Text = operation == '=' ? operationTotal.ToString() : " " ;
        }

        private void Number_Pressed(object sender, EventArgs e)
        {
            // check to see if key pressed was "."
            char keyPressed = (sender as Button).Text[0];
            if (keyPressed == '.')
            {
                if (!displayBox.Text.Contains("."))
                    displayBox.Text = displayBox.Text + "."; //adding a "." if there wasn't one already
                else { } // if there already is a decimal point, dont add another
            }
            else if (keyPressed == '0')
            {
                if (!displayBox.Text.Contains("0"))
                    displayBox.Text = displayBox.Text + "0"; //adding a "0" if there wasn't one already
                
            }
            else
            {
                string number = (sender as Button).Text; //if any other button was pressed, add that number to the displayBox
                displayBox.Text = displayBox.Text == "0" ? number : displayBox.Text + number;
            }
        }

    }
}
