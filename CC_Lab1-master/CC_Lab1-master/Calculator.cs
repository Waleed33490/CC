using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Lab1
{
    public partial class Calculator : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Output_Box.Text = "0";
        }

        private void N0_Click(object sender, EventArgs e) { ButtonClick("0"); }
        private void N1_Click(object sender, EventArgs e) { ButtonClick("1"); }
        private void N2_Click(object sender, EventArgs e) { ButtonClick("2"); }
        private void N3_Click(object sender, EventArgs e) { ButtonClick("3"); }
        private void N4_Click(object sender, EventArgs e) { ButtonClick("4"); }
        private void N5_Click(object sender, EventArgs e) { ButtonClick("5"); }
        private void N6_Click(object sender, EventArgs e) { ButtonClick("6"); }
        private void N7_Click(object sender, EventArgs e) { ButtonClick("7"); }
        private void N8_Click(object sender, EventArgs e) { ButtonClick("8"); }
        private void N9_Click(object sender, EventArgs e) { ButtonClick("9"); }

        private void ButtonClick(string number)
        {
            if ((Output_Box.Text == "0") || isOperationPerformed)
            {
                Output_Box.Clear();
            }
            isOperationPerformed = false;
            Output_Box.Text += number;
        }

        private void decimal_point_Click(object sender, EventArgs e)
        {
            if (!Output_Box.Text.Contains("."))
            {
                Output_Box.Text += ".";
            }
        }

        private void addition_Click(object sender, EventArgs e) { PerformOperation("+"); }
        private void subtraction_Click(object sender, EventArgs e) { PerformOperation("-"); }
        private void multiplication_Click(object sender, EventArgs e) { PerformOperation("*"); }
        private void division_Click(object sender, EventArgs e) { PerformOperation("/"); }

        private void PerformOperation(string op)
        {
            if (result != 0)
            {
                equality_Click(null, null);
                operation = op;
                isOperationPerformed = true;
            }
            else
            {
                operation = op;
                result = double.Parse(Output_Box.Text);
                isOperationPerformed = true;
            }
        }

        private void sin_Click(object sender, EventArgs e)
        {
            Output_Box.Text = Math.Sin(double.Parse(Output_Box.Text) * Math.PI / 180).ToString();
        }

        private void cos_Click(object sender, EventArgs e)
        {
            Output_Box.Text = Math.Cos(double.Parse(Output_Box.Text) * Math.PI / 180).ToString();
        }

        private void tan_Click(object sender, EventArgs e)
        {
            Output_Box.Text = Math.Tan(double.Parse(Output_Box.Text) * Math.PI / 180).ToString();
        }

        private void log_Click(object sender, EventArgs e)
        {
            Output_Box.Text = Math.Log10(double.Parse(Output_Box.Text)).ToString();
        }

        private void square_root_Click(object sender, EventArgs e)
        {
            Output_Box.Text = Math.Sqrt(double.Parse(Output_Box.Text)).ToString();
        }

        private void power_Click(object sender, EventArgs e)
        {
            PerformOperation("^");
        }

        private void equality_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Output_Box.Text = (result + double.Parse(Output_Box.Text)).ToString();
                    break;
                case "-":
                    Output_Box.Text = (result - double.Parse(Output_Box.Text)).ToString();
                    break;
                case "*":
                    Output_Box.Text = (result * double.Parse(Output_Box.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(Output_Box.Text) != 0)
                    {
                        Output_Box.Text = (result / double.Parse(Output_Box.Text)).ToString();
                    }
                    else
                    {
                        Output_Box.Text = "Cannot divide by zero";
                    }
                    break;
                case "^":
                    Output_Box.Text = Math.Pow(result, double.Parse(Output_Box.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(Output_Box.Text);
            operation = "";
        }

        private void Output_Box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            Output_Box.Text = "0";  
            result = 0;             
            operation = "";         
            isOperationPerformed = false;
        }

        private void clear_entry_Click(object sender, EventArgs e)
        {
            Output_Box.Text = "0";
        }

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
