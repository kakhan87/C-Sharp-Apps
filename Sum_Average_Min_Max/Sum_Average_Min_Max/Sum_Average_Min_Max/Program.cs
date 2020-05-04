// Program Name:    T05 P02 Sum Average Min Max
// Author:          Karim Khan
//
// Date:            06-April-2020
//
// Description:     Mini-Project Assignment ‐ Array Practice Programs
//
//                  Create a console application that inputs 10 decimal numbers from the user, 
//                  store them in an array, then determine the sum, the mean(average), the minimum, and the maximum.
//                  The values of the numbers must be in the range of 0 to 100, inclusive.As the values are entered 
//                  into the application, an indication of what the sequence number is should be provided to the user.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Average_Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 10; // declare array size consisting of 10 decimal numbers
                       
            int[] value = new int[ARRAY_SIZE]; // create reference to array called "value"

            // ask the user to enter values between 0 and 100
            // dive into a for loop to register 10 entries of the user input 
            Console.WriteLine("Please enter 10 values between 0 and 100: ");
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.Write($"Value #{i + 1} : ");
                value[i] = int.Parse(Console.ReadLine());
            }

            // store entries into the array
            Console.Write("Values Entered: ");
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.Write($"{value[i],4}");
            }

            Console.WriteLine();
            
            // determine the total, mean, minimum and maximum
            double total = value.Sum();
            Console.WriteLine($"Total: {total:N0}");

            double mean = value.Average();
            Console.WriteLine($"Mean: {mean:N1}");

            double min = value.Min();
            Console.WriteLine($"Minimum: {min:N0}");

            double max = value.Max();
            Console.WriteLine($"Maximum: {max:N0}");
            Console.WriteLine();
        }
    }
}
