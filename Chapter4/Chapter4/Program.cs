using System;
using static System.Console;

namespace Chapter4
{
    class Payroll
    {
        static void Main(string[] args)
        {
            double payRate, hoursWorked, netPay, grossPay, withholding;
            Write("Enter hourly pay rate: ");
            payRate = (double)double.Parse(ReadLine());
            Write("Enter hours worked: ");
            hoursWorked = (double)double.Parse(ReadLine());
            WriteLine("For " + hoursWorked + " hours at " + payRate.ToString("C2") + " per hour");
            grossPay = (double)(hoursWorked * payRate);
            if (grossPay > 300)
            {
                withholding = (double)(grossPay * .12);
            }
            else
            {
                withholding = (double)(grossPay * .1);
            }
            netPay = (double)(grossPay - withholding);
            WriteLine(String.Format("Payrate is : {0,10}", payRate));
            WriteLine(String.Format("Hours worked are : {0,10}", hoursWorked));
            WriteLine(String.Format("Gross Pay is : {0,10}", grossPay));
            WriteLine(String.Format("Net Pay is : {0,10}", netPay));

        }
    }
}
