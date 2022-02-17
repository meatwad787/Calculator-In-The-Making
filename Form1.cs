using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calculatorDislay.Text = "0";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            calculatorDislay.Text = "";
            userInput += "7";
            calculatorDislay.Text += userInput;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calculatorDislay.Text = "";
            userInput += "8";
            calculatorDislay.Text += userInput;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calculatorDislay.Text = "";
            userInput += "9";
            calculatorDislay.Text += userInput;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calculatorDislay.Text = "";
            userInput += "4";
            calculatorDislay.Text += userInput;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculatorDislay.Text = "";
            userInput += "5";
            calculatorDislay.Text += userInput;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculatorDislay.Text = "";
            userInput += "6";
            calculatorDislay.Text += userInput;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            calculatorDislay.Text = "";
            userInput += "1";
            calculatorDislay.Text += userInput;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculatorDislay.Text = "";
            userInput += "2";
            calculatorDislay.Text += userInput;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculatorDislay.Text = "";
            userInput += "3";
            calculatorDislay.Text += userInput;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDislay.Text = "";
            userInput += "0";
            calculatorDislay.Text += userInput;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorDislay.Text += ".";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            //plus
            if (function == '+')
            {
                result = firstNum + secondNum;
                calculatorDislay.Text = result.ToString();
            }
            //minus
            else if (function == '-') 
            {
                result = firstNum - secondNum;
                calculatorDislay.Text = result.ToString();
            }
            //divide
            else if (function == '/')
            {
                if (secondNum == '0')
                {
                    calculatorDislay.Text = "Cannot divide by 0";
                }
                else
                {
                    result = firstNum / secondNum;
                    calculatorDislay.Text = result.ToString();
                }  
                
            }
            //multiply
            else if(function == '*')
            {
                result = firstNum * secondNum;
                calculatorDislay.Text = result.ToString();
            }
                    /*function = '=';
            first = userInput;
            userInput = "";
            */
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }
    }
}
