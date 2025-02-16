using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayOfNumbersApp
{
    public partial class Form1 : Form
    {
        private ArrayOfNumbers arrayInstance;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] userNumbers = textBox1.Text.Split(',').Select(int.Parse).ToArray();

                arrayInstance = new ArrayOfNumbers(userNumbers);


                label1.Text = $"Array created successfully! The numbers are: {string.Join(", ", userNumbers)}";


            } catch
            {
                label1.Text = "Invalid input! Please enter numbers separated by commas.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arrayInstance != null)  
            {
                label2.Text = $"Sum of elements: {arrayInstance.Sum()}";
            }
            else
            {
                label2.Text = "Error: Create an array first!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arrayInstance != null)
            {
                label2.Text = $"The avarage of elements: {arrayInstance.Avg()}";
            }
            else
            {
                label2.Text = "Error: Create an array first!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (arrayInstance != null)
            {
                label2.Text = $"The largest number: {arrayInstance.LargestNum()}";
            }
            else
            {
                label2.Text = "Error: Create an array first!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (arrayInstance != null)
            {
                label2.Text = $"The number of elements in the array: {arrayInstance.Count()}";
            }
            else
            {
                label2.Text = "Error: Create an array first!";
            }
        }
    }
}
