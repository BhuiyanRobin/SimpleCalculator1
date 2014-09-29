using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayExample
{
    public partial class FindIndexUI : Form
    {
        public FindIndexUI()
        {
            InitializeComponent();
        }

        private int counter = 0;
        int[] numbers = new int[5];
        private void addButton_Click(object sender, EventArgs e)
        {
            if (counter<numbers.Length)
            {
                numbers[counter] = Convert.ToInt32(inputTextBox.Text);
            }
            else
            {
                MessageBox.Show("You cannot input number, array is full!");
            }
            counter ++;

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int searchStartPoint = 0;
            int notFoundValue = -1;
            while (searchStartPoint > notFoundValue)
            {
                searchStartPoint = Array.IndexOf(numbers, 100, (searchStartPoint));
                if (searchStartPoint>-1)
                {
                    indexLocationLabel.Text += searchStartPoint + ",";
                }
            }
            
           
        }
    }
}
