// Program Name:    T03 P01 getDoubleinRange() Method
//
// Author:          Karim Khan
//
// Date:            06-April-2020
//
// Description:     Mini-Project Assignment - Method Use and Creation Practice
//
//                  The operation of this method must meet the following requirements:
//                  1. it will use the string prompt to prompt the user for the input
//                  2. if a numeric value is entered by the user, the method will ensure 
//                     that the value is greater than or equal to minimum and less than or equal 
//                     to maximuim.If the entered values falls outside of the interval between the 
//                     minimum and the maximum , then the string found in error will be output, and 
//                     the user will be reprompted to enter the number again.
//                  3. the method will return to the caller only when a valid number is entered, 
//                     and the return value of the method will be that number.
//
using System;


namespace getDoubleInRange
{
    class Program
    {
        // create method in a stand-alone main() section
        static double getDoubleInRange(string prompt, double minimum, double maximum, string error)
        {
            double value; // declare floating point variable that returns output value resulting from user input
            bool numericValue; // declare boolean exoression to be used in the if-statement that ensures a valid numeric 
                               // is entered within specified bounds
            
            // use a do-while loop to attempt the user input at least once whic is protected by data sanitization 
            // to ensure a valid value is output
            do
            {
                Console.Write(prompt);
                if (! double.TryParse(Console.ReadLine(), out value ))
                {
                    Console.WriteLine("***ERROR - Non-numeric value entered. Try again.");
                    numericValue = false;
                }
                else
                {
                    if ( (value < minimum) || (value > maximum) )
                    {
                        Console.WriteLine(error);
                        numericValue = false;
                    }
                    else
                    {
                        numericValue = true;
                    }
                }
            } while ( !numericValue );

            return value;
        }

        static void Main(string[] args)
        {
            double minimum;
            double maximum;
            double value;

            // test created method to make sure it works
            Console.Write("Enter minimum value in range: ");
            minimum = double.Parse(Console.ReadLine());

            Console.Write("Enter maximum value in range: ");
            maximum = double.Parse(Console.ReadLine());

            // call the method

            value = getDoubleInRange("Enter a percentage discount [10 - 35]: ",
                                     minimum,
                                     maximum,
                                     "***Percentage entered is outside of range.");

            Console.WriteLine($"You have entered a percentage of {value:F2}%");
        }
    }
}
