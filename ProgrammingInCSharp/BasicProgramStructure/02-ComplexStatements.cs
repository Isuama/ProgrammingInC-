using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramStructure
{
    class _02_ComplexStatements
    {
        //complex statement are those that can or will enclose one or more simple statements into a code block 
        //surrounded by curly braces {}
        //an exmaple

        void ComplexState()
        {
            //check to see how many values in an array are even numbers
            int[] numbers = { 5, 24, 36, 19, 45, 60, 78 };
            int evenNums = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Number {0} is an even number", num);
                    evenNums++;
                }
                else
                    Console.WriteLine("Number {0} is an odd number", num);

                Console.WriteLine("there were {0} even number/s", evenNums);

                //complex statements do not end with a semicolon
            }
        }
    }
    
}
