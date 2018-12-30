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
        Double resultValue = 0;
        String operationPerform = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (isOperationPerformed))
                textBox.Clear();// used to clear the initial 0 value everytime a number is pressed
            isOperationPerformed = false;
            Button button = (Button)sender; // initialize sender object to button variable
            if(button.Text== ".")////Used to stop the calculator from using more then one .
            {
                if(!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + button.Text;
            }
            else
            textBox.Text = textBox.Text + button.Text;// concatenations of variables

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(resultValue!=0)
            {
                opEquals.PerformClick();
                operationPerform = button.Text;
                textbox_Result.Text = resultValue + " " + operationPerform;
                isOperationPerformed = true;
            }else
            operationPerform = button.Text;
            resultValue = Double.Parse(textBox.Text); //Used to convert the text into a double value for the results
            textbox_Result.Text = resultValue + " " + operationPerform;
            isOperationPerformed = true;
        }

        private void opAllClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void opClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;
        }

        private void opEquals_Click(object sender, EventArgs e)
        {
            switch (operationPerform)
            {
                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultValue = Double.Parse(textBox.Text);//used to show the operater sign more than once in the lab
            textbox_Result.Text = "";
        }
    }
}
