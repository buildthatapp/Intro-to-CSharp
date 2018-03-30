using System;

namespace MidTerm
{
    class MidTerm
    {
   
        static void Main(string[] args)
        {
            //Declaring two arrays to contain two sets of dates
            //index 0 is month, index 1 is date, index 2 is year
            int[] date = { 0, 0, 0 };
            int[] date1 = { 0, 0, 0 };
            int difference = 0;
           
            QueryDate(date);
            DisplayDate(date);
            QueryDate(date1);
            DisplayDate(date1);
            difference = BetweenDates(date, date1);
            Console.WriteLine("The difference between these two dates is {0}", difference);
          
        }

        static void QueryDate(int[] someDate)
        {
            QueryPart(someDate);
            
        }
        static void QueryPart(int[] someDate)
        {
            int x;
            for (x = 0; x < someDate.Length; ++x)
            {
                if (x == 0)
                {

                    do
                    {
                        Console.Write("Enter Year <1900-2100>: ");
                        someDate[2] = Convert.ToInt32(Console.ReadLine());
                        
                    } while (someDate[2] > 2100 || someDate[2] < 1900);

                }
                else if (x == 1)
                {
                    do
                    {
                        Console.Write("Enter Month <1-12>: ");
                        someDate[0] = Convert.ToInt32(Console.ReadLine());
                        
                    } while (someDate[0] < 1 || someDate[0] > 12);

                }
               
                else
                {
                    int numDays = DaysInMonth(someDate[0], someDate[2]);
                    do
                    {
                        
                        Console.Write("Enter Day <1-{0}>: ", numDays);
                        someDate[1] = Convert.ToInt32(Console.ReadLine());
                       
                    } while (someDate[1] < 1 || someDate[1] > numDays);

                }
                

            }

            
        }

        static int DaysInMonth(int month, int year)
        {
            int days;
            bool leapYearCheck = IsLeapYear(year);

            if (month != 4)
            {
                days = DateTime.DaysInMonth(year, month);
                return days;
            }
            else
            {
                if (leapYearCheck == false)
                {

                    days = DateTime.DaysInMonth(year, month);
                    return days;
                }
                else
                {
                    days = 29;
                    return days;

                }
            }

            

        }
        private static bool IsLeapYear(int year)
        {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
        }
        private static int BetweenDates(int[] date1, int[] date2)
        {
            int days = 0;
            int month = 0;
            int years = 0;
            int difference = 0;
            SortDates(date1, date2);
            years = date1[2] - date2[2];
            month = date1[0] - date2[0];
            days = date1[1] - date2[1];

            years = years * 365;
            month = month * 31;

            difference = years + month + days;
            
            return difference;

        }
        private static void SortDates(int[] date1, int[] date2)
        {
            bool swapDates = false;

            if (date1[2] < date2[2])
                swapDates = false;          // first year is earlier
            else if (date1[2] > date2[2])
                swapDates = true;           // first year is later

            // if we get here, both dates are in the same year

            else if (date1[0] < date2[0])
                swapDates = false;          // first month is earlier
            else if (date1[0] > date2[0])
                swapDates = true;           // first month is later

            // if we get here, both dates are in the same month

            else if (date1[1] < date2[1])
                swapDates = false;          // first day is earlier
            else if (date1[1] > date2[1])
                swapDates = true;           // first day is later

            if (swapDates)
                for (int i = 0; i <= 2; ++i)
                {
                    int t = date2[i];
                    date2[i] = date1[i];
                    date1[i] = t;
                }
        }
        private static string DateFormat(int[] date)
        {
            return String.Format("{0:D2}/{1:D2}/{2:D4}", date[0], date[1], date[2]);
        }
        private static void DisplayDate(int[] date)
        {
            string displayMessage = DateFormat(date);
            Console.WriteLine("You entered {0}", displayMessage);
            Console.WriteLine();
        }
    }
}

    

