// Program Name:    T03 P02 Temperature Conversion
//
// Author:          Karim Khan
//
// Date:            06-April-2020
//
// Description:     Mini-Project Assignment - Method Use and Creation Practice
//
//                  Write a console application that will convert a temperature in Fahrenheit degrees 
//                  to one in Celsius degrees, as well as the reverse.
//                  Output the resulting temperature accurate to 2 decimal places.
//                  Your solution must include the following four methods:
//                  1. method toCelsius() which returns the Celsius equivalent of the Fahrenheit temperature
//                     passed as an argument.
//                  2. method toFahrenheit() which returns the Fahrenheit equivalent of a Celsius temperature
//                     passed as an argument.
//                  3. method getDouble() which returns a double value input from the console, using a prompt
//                     passed as an argument.
//                  4. method getChoice() which takes three arguments, a prompt string, and then two character
//                     choices.The method will prompt the user including the passed prompt string, and validate that the
//                     character entered by the user is one of the two choices.The character entered is returned by the
//                     method.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    class Program
    {
        // create a toCelsius method that converts from Fahrenheit to Celsius
        static double toCelsius(double fahrenheit)
        {
            return (5.0 / 9.0) * (fahrenheit - 32.0);
        }
        // create a toFahrenheit method that converts from Celsius to Fahrenheit
        static double toFahrenheit(double celsius)
        {
            return (9.0 / 5.0) * celsius + 32.0;
        }
        // create a getDouble method to ensure user inputs a valid double number
        static double getDouble(string prompt)
        {
            double doubleNumber;
            bool validDoubleNum;
            string input;

            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if ( !double.TryParse(input, out doubleNumber ))
                {
                    Console.WriteLine("*** Input is not a double number. Try again.");
                    validDoubleNum = false;
                }
                else
                {
                    validDoubleNum = true;
                }
            } while ( !validDoubleNum );

            return doubleNumber;
        }
        // create getChoice() method prompting the user to choose which temperature to convert from to the other (F to C or C to F)
        static char getChoice(string prompt, char choice1, char choice2)
        {
            string input;
            bool validEntry;
            char result = ' ';

            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                if (input[0] == choice1)
                {
                    result = choice1;
                    validEntry = true;
                }
                else if (input[0] == choice2)
                {
                    result = choice2;
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine($"*** Must enter either '{choice1}' or '{choice2}'");
                    validEntry = false;
                }

            } while ( !validEntry );

            return result;
        }
        static void Main(string[] args)
        {
            char inputUnits; // records the units of the input temperature (either 'F' or 'C')
            char outputUnits; // gets the letter that represents the output temperature units
            double inputTemp; // gets the temperature input by the user
            double outputTemp; // gets the output temperature calculated by the program
            char moreToDo; // gets the letter 'Y if more temperatures to be converted

            do
            {
                // get input units and temperature
                inputUnits = getChoice("What is the input temperature units? [F]ahrenheit or [C]elsius?: ", 'F', 'C');
                inputTemp = getDouble("Enter temperature to be converted: ");
                if (inputUnits == 'C') // convert celsius -> to fahrenheit
                {
                    outputTemp = toFahrenheit(inputTemp);
                    outputUnits = 'F';
                }
                else // convert fahrenheit -> to celsius
                {
                    outputTemp = toCelsius(inputTemp);
                    outputUnits = 'C';
                }
                // output results
                Console.WriteLine($"A temperature of {inputTemp}°{inputUnits} equals {outputTemp:F2}°{outputUnits}");
                // ask if more to do
                moreToDo = getChoice("Convert another temperature? [YN]?: ", 'Y', 'N');
            } while ( moreToDo == 'Y' );
        }
    }
}
