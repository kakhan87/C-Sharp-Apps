// Program Name:    T04 P01 GUI Trapezoid Area
// Author:          Karim Khan
//
// Date:            06-April-2020
//
// Description:     Mini-Project Assignment ‐ Graphical User Interfaces
//
//                  Implement an application that allows the user to calculate the area of a Trapezoid. 
//                  The interface will have:
//                  1. A textbox for entering the length of one of the parallel sides
//                  2. Another textbox for entering the length of the other parallel side
//                  3. A third textbox that for entering the height; the distance between the two parallel sides
//                  4. A Calculate button that when pressed, will first validate the numbers entered into the text 
//                  boxes.If they are invalid lengths(not numeric or have values less than or equal to zero) an appropriate, 
//                  specific error message is to be displayed in an alert box(message box). If however the value are valid 
//                  then the area of the trapezoid is to be displayed in an area beside the calculate button.
//                  5. A Quit button which when pressed will cause the application to exit.
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Trapezoid_Area
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exits the Application
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double firstParallelSide;
            double secondParallelSide;
            double height;

            // get the trapezoid's first parallel side
            if (!double.TryParse(firstParallelSideTextBox.Text, out firstParallelSide))
            {
                MessageBox.Show("First Parallel Side is not a number.");
                return; // return will exit the function when calling it - if no valid base length is provided, 
                        // it ends the method "void" and nothing below the return statement will be executed.
            }

            if (firstParallelSide <= 0)
            {
                MessageBox.Show("First Parallel Side must be a positive number.");
                return;
            }
            // get the trapezoid's second parallel side
            if (!double.TryParse(secondParallelSideTextBox.Text, out secondParallelSide))
            {
                MessageBox.Show("Second Parallel Side is not a number.");
                return; // return will exit the function when calling it - if no valid base length is provided, 
                        // it ends the method "void" and nothing below the return statement will be executed.
            }

            if (secondParallelSide <= 0)
            {
                MessageBox.Show("Second Parallel Side must be a positive number.");
                return;
            }
            // get the trapezoid height

            if (!double.TryParse(heightTextBox.Text, out height))
            {
                MessageBox.Show("Triangle Height is not a number.");
                return;
            }

            if (height <= 0)
            {
                MessageBox.Show("Trapezoid Height must be a positive number.");
                return;
            }
            // do the calculation and update the results label

            double area = ((firstParallelSide + secondParallelSide) / 2) * height; // inline declaration of area

            resultOutputLabel.Text = $"Area = {area:N2}";
            resultOutputLabel.Visible = true;
        }
    }
}
