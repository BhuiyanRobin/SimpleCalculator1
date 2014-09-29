using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class simpleCalculatorUI : Form
    {
        public simpleCalculatorUI()
        {
            InitializeComponent();
        }

        decimal firstNumber;
        decimal secondNumber;
        decimal result;
       // string show;

        private void addButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(firstNumberTextBox.Text);
            secondNumber = Convert.ToDecimal(secondNumberTextBox.Text);
            result = firstNumber + secondNumber;
            resultTextbox.Text = Convert.ToString(result);
            //show = Convert.ToString(result);
           //MessageBox.Show(show);
            //firstNumberTextBox.Text = null ;
           // secondNumberTextBox.Text = null;

            
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(firstNumberTextBox.Text);
            secondNumber = Convert.ToDecimal(secondNumberTextBox.Text);
            result = firstNumber - secondNumber;
            resultTextbox.Text = Convert.ToString(result);
        }
       
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(firstNumberTextBox.Text);
            secondNumber = Convert.ToDecimal(secondNumberTextBox.Text);
            result = firstNumber * secondNumber;
            resultTextbox.Text = Convert.ToString(result);

          // firstNumberTextBox.Text = null;
            //secondNumberTextBox.Text = null;
        }

        private void devisionButton_Click(object sender, EventArgs e)
        {


            firstNumber = Convert.ToDecimal(firstNumberTextBox.Text);
            secondNumber = Convert.ToDecimal(secondNumberTextBox.Text);

            result = firstNumber / secondNumber;
     
            resultTextbox.Text = Convert.ToString(result);
        }

    }
}
