using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4_2
{
    public partial class Form1 : Form
    {
        private double firstOperand = 0;
        private string currentOperator = "";
        private bool isSecondInput = false;
        private ICalculator calculator = new Math();

        public Form1()
        {
            InitializeComponent();
        }

        private void AppendToDisplay(string value)
        {
            if (isSecondInput || txtDisplay.Text == "0")
            {
                txtDisplay.Text = value;
                isSecondInput = false;
            }
            else
            {
                txtDisplay.Text += value;
            }
        }
        private void btn_Equal_Click(object sender, EventArgs e)
        {
            double secondOperand = double.Parse(txtDisplay.Text);
            try
            {
                double result = calculator.Calculate(firstOperand, secondOperand, currentOperator);
                txtDisplay.Text = result.ToString();
                isSecondInput = true;
            }
            catch (Exception)
            {
                txtDisplay.Text = "Error";
            }
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                if (txtDisplay.Text == "")
                    txtDisplay.Text = "0";
            }
        }
        private void SetOperator(string op)
        {
            firstOperand = double.Parse(txtDisplay.Text);
            currentOperator = op;
            isSecondInput = true;
        }
        private void btn_Add_Click(object sender, EventArgs e) => SetOperator("+");
        private void btn_Subtract_Click(object sender, EventArgs e) => SetOperator("-");
        private void btn_Multiply_Click(object sender, EventArgs e) => SetOperator("*");
        private void btn_Divide_Click(object sender, EventArgs e) => SetOperator("/");
        private void btn_Percent_Click(object sender, EventArgs e) => SetOperator("%");

        private void btn_Zero_Click(object sender, EventArgs e) => AppendToDisplay("0");
        private void btn_One_Click(object sender, EventArgs e) => AppendToDisplay("1");
        private void btn_Two_Click(object sender, EventArgs e) => AppendToDisplay("2");
        private void btn_Three_Click(object sender, EventArgs e) => AppendToDisplay("3");
        private void btn_Four_Click(object sender, EventArgs e) => AppendToDisplay("4");
        private void btn_Five_Click(object sender, EventArgs e) => AppendToDisplay("5");
        private void btn_Six_Click(object sender, EventArgs e) => AppendToDisplay("6");
        private void btn_Seven_Click(object sender, EventArgs e) => AppendToDisplay("7");
        private void btn_Eight_Click(object sender, EventArgs e) => AppendToDisplay("8");
        private void btn_Nine_Click(object sender, EventArgs e) => AppendToDisplay("9");
        private void btn_Decimal_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }
        private void btn_PosNeg_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double value))
            {
                txtDisplay.Text = (-value).ToString();
            }
        }

        
    }
}
