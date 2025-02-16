using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayOfNumbersApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ArrayOfNumbers array = new ArrayOfNumbers(2);

            
            array.SetElement(0, 20);
            array.SetElement(1, 30);

            MessageBox.Show($"Element on index 0: {array.GetElement(0)}");
            MessageBox.Show($"Element on index 1: {array.GetElement(1)}");



            Application.Run(new Form1());


        }
    }
}
