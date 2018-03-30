using System;
using static System.Console;                        ///*  Mike Hudekoff  Roger Long Th Spring 2017 C# */

/*Create a program named TaxpayerDemo2 that declares an array of 4 Taxpayer objects. 
 * As with last week’s homework, prompt the user for data for each object and display the 4 objects. 
 * Then, sort the array in order by the amount of tax owed and display the Taxpayer objects again.
Modify the Taxpayer class from last week so its objects are comparable to each other based on tax owed.*/

class TaxPayer : IComparable
{
    public string Social { get; set; } //
    public double Salary { get; set; }
    public  double TaxOwed { get; set; }

    public TaxPayer(string social, double salary, double taxOwed) //double taxOwed) //took out double taxOwed for testing
    {
        Social = social;
        Salary = salary;
        TaxOwed = taxOwed;
    }
    int IComparable.CompareTo(object o)
    {
        int returnVal;
        TaxPayer t = (TaxPayer)o;
        if (this.Salary > t.Salary)  //(this.taxOwed > t.taxOwed) Salary for testing
            returnVal = 1;
        else if (this.Salary < t.Salary) //(this.taxOwed < t.taxOwed)
            returnVal = -1;
        else
            returnVal = 0;

        return returnVal;
    }
}
class TaxPayerDemo
{
    static void Main(string[] args)
    {
        TaxPayer[] tP = new TaxPayer[2];
        for (int i = 0; i < tP.Length; ++i)
            tP[i] = GetData(i + 1);

        Array.Sort(tP);                    // sort needs to be int
        for (int i = 0; i < tP.Length; ++i)
            Display(i + 1, tP[i]);

        Console.ReadKey();
    }

    static TaxPayer GetData(int Num)
    {
        WriteLine("Enter Social Security Number for taxpayer {0}", Num);
        string social = ReadLine();

        while (social.Length != 9)
        {
            WriteLine("SSN must be 9 digits. Do not include dashes");
            WriteLine("Please enter the Social Security Number again");
            social = ReadLine();
        }
        WriteLine("Enter Gross Income: ");
        double salary = Convert.ToDouble(ReadLine());
      
        double taxOwed = 0.00;
        const double GROSS_RATE_30K_OR_OVER = .28;
        const double GROSS_RATE_UNDER_30k = .15;
        const double THIRTY_K = 30000;

        if (salary >= THIRTY_K)
        {
            taxOwed = (salary * GROSS_RATE_30K_OR_OVER);
        }
        else
        {
            taxOwed = (salary * GROSS_RATE_UNDER_30k);
        }


        return new TaxPayer(social, salary, taxOwed);        // add taxOwed
    }
    //   public double GetTaxOwed()
    //   {
    //       return new TaxPayer();
    //   }

    static void Display(int num, TaxPayer c)
    {

        WriteLine("Taxpayer {0} SSN: {1}, Salary:  {2:c} Tax Owed: ", num, c.Social, c.Salary, c.TaxOwed); //   Tax Owed: {3}   - took out for testing. Dont know how to refrnce
    }
    //   static void Display(int num, )
  
}
