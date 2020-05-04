// Program Name:    T04 P02 GUI Technical Support
// Author:          Karim Khan
//
// Date:            06-April-2020
//
// Description:     Mini-Project Assignment ‐ Graphical User Interfaces
//
//                  Implement an application that has a Graphical Use Interface 
//                  which allows the user to figure out what they should do 
//                  with a malfunctioning computer.
//                  Two pieces of information need to be determined;
//                  1. first whether the ailing computer beeps on startup or it does not, and then
//                  2. whether the hard drive spins on startup or it does not.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Technical_Support
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //once quit button is clicked, application exits gracefully
        }

        // once "What should I do" button is clicked, it will reflect choices made on the checkboxes 
        // based on the rules and messages of the application highlighted in the assignment
        private void recommendationButton_Click(object sender, EventArgs e)
        {
            if (computerBeepCheckBox.Checked && discSpinCheckBox.Checked)
            {
                recommendationLabel.Text = "Bring your computer in to repair";
            }
            else if (!computerBeepCheckBox.Checked && discSpinCheckBox.Checked)
            {
                recommendationLabel.Text = "Check speaker wires";
            }
            else if (computerBeepCheckBox.Checked && !discSpinCheckBox.Checked)
            {
                recommendationLabel.Text = "Check drive cables";
            }
            else if (!computerBeepCheckBox.Checked && !discSpinCheckBox.Checked)
            {
                recommendationLabel.Text = "Call Tech Support";
            }


        }
        // clear the recommendation once checkboxes are cleared to test a new case
        private void checkBoxChanged(object sender, EventArgs e)
        {
            recommendationLabel.Text = "";
        }
    }
}
