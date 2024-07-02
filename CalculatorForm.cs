using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcForms
{
    public partial class CalculatorForm : Form
    {
        private TextBox _activeTextBox;
        private string _activeOperator;
        public CalculatorForm()
        {
            InitializeComponent();
            _activeTextBox = textBox_1;
        }


        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }



        private void textBox_1_Click(object sender, EventArgs e)
        {
            _activeTextBox = (TextBox)sender;
        }

        private void textBox_2_Click(object sender, EventArgs e)
        {
            _activeTextBox = (TextBox)sender;

        }

        private void button_Equal_Click(object sender, EventArgs e)
        {
            int fieldOne = int.Parse(textBox_1.Text);
            int fieldTwo = int.Parse(textBox_2.Text);
            int sumResult = fieldOne + fieldTwo;

            //result.Text =  sumResult.ToString();
            //result.Text = my_operator.Text;
            //int test = int.Parse("98");
            //result.Text = 1943438 "+" 98;
        }

        private double CalculateResult(int num1, int num2, string the_operator)
        {double result = 0;
            switch (the_operator)
            {
                case "+":
                    result = num1 + num2;
                    break;   
                    
                case "-":
                    result = num2 - num1;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num2 * num1;
                    break;
                    
            }
            return result;
        }





        private void fany_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("It says do not touch!! What is not clear? last time you touch");

        }



        private void button_all_Click(object sender, EventArgs e)
        {
            _activeTextBox.Text += ((Button)sender).Text;
        }

        private void all_operators(object sender, EventArgs e)
        {

            _activeOperator = ((Button)sender).Text;
            //my_operator  = ((Button)sender).Text;
        }
    }
}
