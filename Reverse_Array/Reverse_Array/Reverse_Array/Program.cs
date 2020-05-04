// Program Name:    T05 P01 Reverse an Array
// Author:          Karim Khan
//
// Date:            06-April-2020
//
// Description:     Mini-Project Assignment ‐ Array Practice Programs
//
//                  Create a Console Application that
//                  1. generates 5 random numbers(between 1 and 1000) storing them in an array,
//                  2. displays the values in the array to the user,
//                  3. then displays the array in reverse order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // set Random Number Array Dimensions, Maximum and Minimum values

            const int ARRAY_SIZE = 5; 
            const int RAND_MINIMUM = 1;
            const int RAND_MAXIMUM = 1000;

            // create array called myRandomNumbers 
            
            int[] myRandomNumbers = new int[ARRAY_SIZE];

            System.Random random = new System.Random();

            // use a for-loop to to pull out the generated random numbers (within defined bounds) and appending them to the array
            
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                myRandomNumbers[i] = random.Next(RAND_MINIMUM, RAND_MAXIMUM);
            }
            
            //display random numbers array
            
            Console.Write("Random  Number List: ");
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.Write($"{myRandomNumbers[i], 4}"); // each random number should be separated by 4 characters (to make the output look pretty)
            }
            Console.WriteLine();

            // display array in reverse order
            
            Console.Write("Reverse Number List: ");

            for (int i = ARRAY_SIZE - 1; i >= 0; i--)
            {
                Console.Write($"{myRandomNumbers[i],4}"); // each random number should be separated by 4 characters (to make the output look pretty)
            }
            Console.WriteLine("\n");
        }
    }
}
