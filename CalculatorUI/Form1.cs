using System;
using System.Windows.Forms;
using CalculatorLibrary;

namespace CalculatorUI
{
    public partial class Form1 : Form
    {
        private BasicCalculator calculator;
        private Memory memory;
        private double currentNumber = 0;
        private string currentOperation = "";

        public Form1()
        {
            InitializeComponent();
            calculator = new BasicCalculator();
            memory = new Memory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0"; // Default display
        }

        // ✅ Number Button Click
        private void Number_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (txtDisplay.Text == "0") txtDisplay.Text = "";
                txtDisplay.Text += clickedButton.Text;
            }
        }

        // ✅ Clear (C)
        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            calculator.Clear();
        }

        // ✅ Backspace
        private void Backspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";
        }

        // ✅ Clear Entry (CE)
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        // ✅ Negate (+/-)
        private void btnPM_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double num))
            {
                txtDisplay.Text = (-num).ToString();
            }
        }

        // ✅ Operation Buttons (+, -, *, /)
        private void btnAdd_Click(object sender, EventArgs e) => SetOperation("+");
        private void btnSubtract_Click(object sender, EventArgs e) => SetOperation("-");
        private void btnMultiply_Click(object sender, EventArgs e) => SetOperation("*");
        private void btnDivide_Click(object sender, EventArgs e) => SetOperation("/");

        private void SetOperation(string operation)
        {
            if (double.TryParse(txtDisplay.Text, out currentNumber))
            {
                currentOperation = operation;
                calculator.result = currentNumber;
                txtDisplay.Text = "0"; // Reset display for next input
            }
        }

        // ✅ Equals (=) Button
        private void btnResult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double secondNumber))
            {
                switch (currentOperation)
                {
                    case "+": calculator.Add(secondNumber); break;
                    case "-": calculator.Subtract(secondNumber); break;
                    case "*": calculator.Multiply(secondNumber); break;
                    case "/": calculator.Divide(secondNumber); break;
                }
                txtDisplay.Text = calculator.result.ToString();
                currentOperation = "";
            }
        }

        // ✅ Memory Functions
        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double value))
            {
                memory.Save(value);
                MessageBox.Show($"Saved {value} to memory.");
            }
        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memory.Recall().ToString();
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            memory.Clear();
            MessageBox.Show("Memory Cleared!");
        }
    }
}
