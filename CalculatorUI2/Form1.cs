using System;
using System.Windows.Forms;
using CalculatorLibrary;

namespace CalculatorUI2
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

        private void Number_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (txtDisplay.Text == "0") txtDisplay.Text = "";
                txtDisplay.Text += clickedButton.Text;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            memory.Clear();
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double num))
            {
                txtDisplay.Text = (-num).ToString();
            }
        }

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

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double value))
            {
                memory.Save(value);
                UpdateMemoryListBox();
            }
        }


        private void btnMC_Click(object sender, EventArgs e)
        {
            memory.Clear(); // Clears the memory
            UpdateMemoryListBox(); // Optionally, update the ListBox to reflect cleared memory
            txtDisplay.Text = "0";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            var memoryItems = memory.GetMemoryItems(); // Get the list of memory items
            if (memoryItems.Count > 0)
            {
                double lastMemoryValue = memoryItems[memoryItems.Count - 1].Value; // Get the last saved value
                txtDisplay.Text = lastMemoryValue.ToString(); // Display the value in the text box
            }
            else
            {
                MessageBox.Show("Memory is empty."); // Show a message if memory is empty
            }
        }
        private void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            e.DrawFocusRectangle();

            string text = listBox.Items[e.Index].ToString();
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Far;  // Align text to the right
                sf.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds, sf);
            }
        }
        private void UpdateMemoryListBox()
        {
            listBox.Items.Clear();  // Clear existing items in the ListBox

            foreach (var item in memory.GetMemoryItems())  // Loop through the memory items
            {
                listBox.Items.Add(item.ToString());  // Add each item to the ListBox
            }
        }


    }
}
