using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            // Clear result label
            labelResult.Text = "";

            // Variables
            int max = 0;
            int i = 0;
            int sum = 0;

            // try-catch to get number from textbox
            try
            {
                max = Convert.ToInt32(textBox1.Text); // converts to int
            }
            catch
            {
                MessageBox.Show("Numbers only!", "Error", MessageBoxButtons.OK); // Messagebox at error
            }

            /*
             * I decided to include the last number
             * ie the max number with (i <= max) in the calculation
             * and not the number before max (i < max).
            */
            while (i <= max)
            {
                sum = i + sum;
                i++;
            }

            // result text with sum of the while loop above
            labelResult.Text = $"Sum of every number to and including max number: {sum}"; 
        }
    }
}
