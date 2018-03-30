using System;
using static System.Console;


namespace FlexibleArrayMethod
{
    class Program
    {
        static void Main()
        {
            //creating three arrays of integers of different sizes

            int[] one = { 1, 3, 5, 7, 9 };
            int[] two = { 2, 4, 6 };
            int[] three = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            
            //calling function DisplayArray and passing each of the three 
            //arrays as parameters

            DisplayArray(one);
            DisplayArray(two);
            DisplayArray(three);
        }
        //function DisplayArray accepts an array of integers as vals

        private static void DisplayArray(int[] vals)
        {
            //local variable declaration for loop control and sum
            int sum = 0;
            int i;

            //begin interations through each index in array passed as vals[]
            
            for ( i = 0; i < vals.Length-1; ++i)
            {
                //string construction to output during each iteration

                Write("{0} + ", vals[i]);

                //adding the values in each index to sum

                sum += vals[i];
            }
            //at the final index, displays the element, then displays that  sum plus that element

            WriteLine("{0} = {1}", vals[i], sum+=vals[i]);   
        }
    }
}
