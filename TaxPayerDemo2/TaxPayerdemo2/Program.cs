
using System;
using static System.Console;                       


class TaxPayerDemo
{
    static void Main() 
    {
        TaxPayer[] taxPayerArray = new TaxPayer[4];
        for (int x = 0; x < taxPayerArray.Length; ++x)
             taxPayerArray[x] = GetData(x + 1);
        WriteLine("-------------------------------------");

        for ( int i =0; i < taxPayerArray.Length; ++i)
            Display(i + 1, taxPayerArray[i]);

        WriteLine("-------------------------------------");


        Array.Sort(taxPayerArray);                    
        for (int i = 0; i < taxPayerArray.Length; ++i)
            Display(i + 1, taxPayerArray[i]);

        
     }

    static TaxPayer GetData(int taxPayerNumber)
    {
        WriteLine("Enter Social Security Number for taxpayer {0}", taxPayerNumber); 
        string ssnString = ReadLine();
        int ssnInteger;

        while ( !int.TryParse(ssnString, out ssnInteger) && ssnInteger.ToString().Length!=9 )
        {
           
            WriteLine("You have entered an incorrect value for social security number.");
            WriteLine("Please re-enter your SSN. Enter the value as 9 consecutive digits.");
            Write("Social Security Number : ");
            ssnString = ReadLine();
        }
     
        

        WriteLine("Enter Gross Income: ");
        string salaryString = ReadLine();
        double salaryAmount;

        while (!double.TryParse(salaryString, out salaryAmount))
        {
            WriteLine("You have entered an incorrect value for Gross Income.");
            WriteLine("Please enter a numerical value with no letters or special characters");
            Write("Gross Income : ");
            salaryString = ReadLine();
        }
      
        double amountOfTaxOwed = 0.00;
       

        if (salaryAmount >= 30000)
        {
            amountOfTaxOwed  = (salaryAmount * .28);
        }
        else
        {
            amountOfTaxOwed = (salaryAmount * .15);
        }


        return new TaxPayer(ssnString, salaryAmount, amountOfTaxOwed);        
    }


    static void Display(int taxPayerNumber, TaxPayer currentTaxPayer)  
    {
        
        WriteLine("Taxpayer {0} SSN: {1} Salary:  {2} Tax Owed: {3}", taxPayerNumber, currentTaxPayer.SSN, currentTaxPayer.SalaryAmount.ToString("C2"), currentTaxPayer.AmountOfTaxOwed.ToString("C2")); 
    }

}

class TaxPayer : IComparable
{
    public string SSN { get; set; }
    public double SalaryAmount { get; set; }
    public double AmountOfTaxOwed { get; }

    public TaxPayer(string social, double salary, double taxOwed)
    {
        SSN = social;
        SalaryAmount = salary;
        AmountOfTaxOwed = taxOwed;
    }
    int IComparable.CompareTo(object o)
    {
        int returnVal;
        TaxPayer t = (TaxPayer)o;
        if (this.SalaryAmount > t.SalaryAmount)
            returnVal = 1;
        else if (this.SalaryAmount < t.SalaryAmount)
            returnVal = -1;
        else
            returnVal = 0;

        return returnVal;
    }
}