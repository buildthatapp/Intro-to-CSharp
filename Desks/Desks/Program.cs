using System;
using static System.Console;

class Desks
{
    static void Main()
    {
        int numberOfDrawers; //declaring variable, value will be returned as out param from function QueryDrawers

        char typeOfWood; // declaring variable, value will be returned as out param from function QueryTypeOfWood

        int totalOrderCost; // declaring variable, value will be returned as out param from function CalculateTotal



        QueryDrawers(out numberOfDrawers); //calling function QueryDrawer, passing numberOfDrawers as out param

        QueryTypeOfWood(out typeOfWood); //calling function QueryTypeOfWood, passing typeOfWood as out param

        CalculateTotal( numberOfDrawers,  typeOfWood, out totalOrderCost); //calling function CalculateTotal, passing numberOfDrawers and typeOfWood as values, totalOrderCost as out param

        DisplayTotals( numberOfDrawers,  typeOfWood, totalOrderCost);  //calling function Displaytotals, passing numberOfDrawers, typeOfWood, and totalOrdercost as values
    }

    //function definition for QueryDrawers
    //will accept an integer as an out parameter
    // will receive input from the user on number of drawers and return that number to caller

    private static void QueryDrawers(out int numberOfDrawers)
    {
        string drawers; //creating string drawers, scope within function, this string will be set by the user through ReadLine()

        do  //start of do-while loop. purpose is to post-test the input received from the user, and repeat the prompt until the user enters a valid value
        {
            Write("Enter the number of drawers you would like to purchase : ");

             drawers = ReadLine(); // assinging the input read through ReadLine to string variable drawers

            int.TryParse(drawers, out numberOfDrawers); //attempting to parse the string drawers to an integer, storing the result as out numberOfDrawers

            // loop control variable is the bool resulting from trying to parse the string drawers as an int. as long as the parse
            // is not successful, will repeat everything in the do-while loop
        } while (!int.TryParse(drawers, out numberOfDrawers));  

    }

    // function definition for QueryTypeOfWood
    // function will receive typeOfWood as a char out parameter
    // purpose of function is to prompt user for the type of wood they want their desk to be and return their response to caller
    // we are looking for the user to only enter m,n, or o as input values.
    // to handle the case of the user entering M, N, or O, we will .ToUpper the users input and test only capitalized values in the logic
    private static void QueryTypeOfWood(out Char typeOfWood)
    {
        string wood;

        do
        {
            WriteLine("Choices of wood are m for mahogany, o for oak, or p for pine");

            WriteLine();

            Write("Enter the type of wood you would like your desk(s) to be made of : ");

            wood = ReadLine().ToUpper(); // storing a capitalized version of the users input into wood

            char.TryParse(wood, out typeOfWood);  // attempting to parse wood as a character, and store the new value as out typeOfWood

            //  logic to repeat function until user inputs a valid value
            //  loop will repeat if either :
            //                              char.tryparse on wood FAILS
            //                              or
            //                              char.tryparse succeeds, but character parsed is not M,P, or O
        } while (!char.TryParse(wood, out typeOfWood) || (typeOfWood != 'M' && typeOfWood != 'P' && typeOfWood != 'O'));


    }

    // function definition for CalculateTotal
    // purpose of function is to take the number of drawers, the type of wood as input and return the totalOrdercost back as an out param
    private static void CalculateTotal( int drawers,  Char wood, out int totalOrderCost)
    {
        const int SURCHARGE_PER_DRAWER = 30;  // constant variable to hold the surcharge per drawer.  surcharge per drawer is a flat $30

        const int PINE_DESK_COST = 100, OAK_DESK_COST = 140, ALL_OTHER_WOOD_COST = 180;  // constants for holding the prices per desk, based on type of wood

        int totalSurcharge = drawers * SURCHARGE_PER_DRAWER; // calculation for finding the total surcharge per order. the total surcharge is equal to the number of drawers times the surcharge per drawer


        if (wood == 'P')  //  case type of wood is Pine, set total order cost relative to Pine desk cost
            totalOrderCost =  PINE_DESK_COST + totalSurcharge;
        else if (wood == 'O') // case type of wood is Oak, set total order cost relative to Oak desk cost
            totalOrderCost = OAK_DESK_COST + totalSurcharge;
        else // all other cases, including mahogany .  set total order cost relative to ALL_OTHER_WOOD_COST
            totalOrderCost = ALL_OTHER_WOOD_COST + totalSurcharge;
    }

    // function definition for displaying input and totals back to the user
    //  no need to pass as ref or out, since we are only using values to be displayed to the user
    //  accepts an integer number of drawers, a character value for wood, and an integer value for total cost
    private static void DisplayTotals(int drawers, Char wood, int cost)
    {
        string woodString;  
        if (wood == 'P')  // test cases for types of wood based on the character received as input param
            woodString = "Pine";
        else if (wood == 'O')
            woodString = "Oak";
        else
            woodString = "Mahogany";

        if (drawers > 1) // test cases for number of drawers. output string displayed to user will change depending on amount of drawers ordered
        {
            WriteLine("You have ordered a {0} desk with {1} drawers", woodString, drawers);
            WriteLine("Your cost is {0}", cost.ToString("C2"));
        }
        else if (drawers == 1)
        {
            WriteLine("You have ordered a {0} desk with {1} drawer", woodString, drawers);
            WriteLine("Your cost is {0}", cost.ToString("C2"));
        }
        else
        {
            WriteLine("You have ordered a {0} desk with no drawers", woodString);
            WriteLine("Your cost is {0}", cost.ToString("C2"));
        }
    }






}