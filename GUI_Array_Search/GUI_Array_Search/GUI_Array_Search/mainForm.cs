// Program Name:    T05 P03 GUI Array Search
// Author:          Karim Khan
//
// Date:            07-April-2020
//
// Description:     Mini-Project Assignment ‐ Array Practice Programs
//
//                  Create a GUI app that generates 10 random numbers, stores them in an array, 
//                  and allows the user to search for a particular value, displaying the index 
//                  if found.If the value is not in the list of numbers then that should be reported 
//                  to the user with an appropriate message.
//                  The random numbers should all be two digit numbers; i.e.between 10 and 99.
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

namespace GUI_Array_Search
{
    public partial class mainForm : Form
    {
        // define list dimensions, minimum and maximum
        
        const int LIST_SIZE = 10;
        const int RAND_MIN   = 10;
        const int RAND_MAX   = 99;

        private List <int> myRandomNumbers = new List <int>(LIST_SIZE); // model used to generate random numbers
        public mainForm()
        {
            InitializeComponent();
        }
        // use Form Load event to trigger the generation of the list values and the subsequent display to the user
        
        private void mainForm_Load(object sender, EventArgs e)
        {
            System.Random random = new System.Random(); // activate random number generator

            // drop into the for loop to pull out the generated random numbers and add them to the list, 
            // accounting for the defined bounds
            
            for (int i = 0; i < LIST_SIZE; i++)
            {
                myRandomNumbers.Add(random.Next(RAND_MIN, RAND_MAX));
            }
            // use foreach loop to pull out the generated numbers from the collection and view them
            
            foreach (int number in myRandomNumbers)
            {
                randomOutputTextBox.Text += $"{number,4}"; // view generated random numbers
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // index value is used to pin-point index in the list
            
            int index = myRandomNumbers.IndexOf(int.Parse(searchTextBox.Text.Trim()));
            
            // if-else statement used to assess entered user value in the search box

            if (index == -1) // if index returns a value of -1, output message that value is not found
            {
                searchOutputLabel.Visible = true;
                searchOutputLabel.Text = $"The value {searchTextBox.Text.Trim()} was NOT found.";
            }

            else
            {
                searchOutputLabel.Visible = true;
                searchOutputLabel.Text = $"The value {searchTextBox.Text.Trim()} was found at index {index}.";
            }
        }
    }
}
