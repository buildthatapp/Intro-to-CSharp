//  Assignment Name: Week 2 Homework
//  Written By: Louis Magdaleno
//  Date 10 February 2017
//  Program Description:  This program will prompt a user to enter an integer value for degrees in fahrenheit
//                        then will convert the fahrenheit temperature into celcius and show the user both temperatures.

using System;
using static System.Console;

namespace Chapter2
{
    class FahrenheitToCelsius
    {
        static void Main()  
        {
            const int FAHRTOCEL_MINUS32 = 32; // integer constant holding the value 32. This value will be subtracted from the fahrenheit temp
            const double FAHRTOCEL_5_OVER_9 = (double)5/9; // double constant holding value of 5/9.  This value will be multiplied by the difference of user input integer and 32
            int tempInFahrenheit; double tempInCelcius; // empty variables needed to store value of user input and the value of degrees in celcius
            Write("Enter a temperature in Fahrenheit degrees >> ");  //prompting user to enter an integer for degrees in F
            tempInFahrenheit = Convert.ToInt32(ReadLine());  //converting string of userinput into a signed integer 32 bits. Convert.ToInt used here instead of Parse.Int to catch 0 value inputs.
            tempInCelcius = (double) (tempInFahrenheit - FAHRTOCEL_MINUS32) * FAHRTOCEL_5_OVER_9;  // formula for finding degrees in celcius. setting degrees in celcius equal to the product of 5/9(degreesF - 32)
            WriteLine(tempInFahrenheit + " Fahrenheit is " + tempInCelcius + " degrees Celcius");  // displaying both temperatures to the user
            Write("Press any key to continue . . .");  //end of program, prompting user to hit any key to continue
            ReadKey();
        }
    }
}
