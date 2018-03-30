using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullertonMaidService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //clearing all textboxes, resetting forecolor to black

            employeeNameTextBox.Clear();
            hourlySalaryTextBox.Clear();
            day1.Clear();
            day2.Clear();
            day3.Clear();
            day4.Clear();
            day5.Clear();
            day6.Clear();
            day7.Clear();
            day8.Clear();
            day9.Clear();
            day10.Clear();
            day11.Clear();
            day12.Clear();
            day13.Clear();
            day14.Clear();
            regularHoursTextBox.Clear();
            overtimeHoursTextBox.Clear();
            regularAmountTextBox.Clear();
            overtimeAmountTextBox.Clear();
            grossPayTextBox.Clear();

            hourlySalaryTextBox.ForeColor = Color.Black;
            day1.ForeColor = Color.Black;
            day2.ForeColor = Color.Black;
            day3.ForeColor = Color.Black;
            day4.ForeColor = Color.Black;
            day5.ForeColor = Color.Black;
            day6.ForeColor = Color.Black;
            day7.ForeColor = Color.Black;
            day8.ForeColor = Color.Black;
            day9.ForeColor = Color.Black;
            day10.ForeColor = Color.Black;
            day11.ForeColor = Color.Black;
            day12.ForeColor = Color.Black;
            day13.ForeColor = Color.Black;
            day14.ForeColor = Color.Black;

        }

        private void processButton_Click(object sender, EventArgs e)
        {
            double[] hoursWorked;
            hoursWorked = new double[14];  
            double hourlyRate =0;

            if (!double.TryParse(hourlySalaryTextBox.Text, out hourlyRate)) { hourlySalaryTextBox.ForeColor = Color.Red; hourlyRate = 0; }

            
            //converting all 14 days textboxes to doubles
             if (!double.TryParse(day1.Text, out hoursWorked[0]) || hoursWorked[0] <0 ) { day1.ForeColor = Color.Red; hoursWorked[0] = 0; }
             if (!double.TryParse(day2.Text, out hoursWorked[1]) || hoursWorked[1] < 0) { day2.ForeColor = Color.Red; hoursWorked[1] = 0; }
             if (!double.TryParse(day3.Text, out hoursWorked[2]) || hoursWorked[2] < 0) { day3.ForeColor = Color.Red; hoursWorked[2] = 0; }
             if (!double.TryParse(day4.Text, out hoursWorked[3]) || hoursWorked[3] < 0) { day4.ForeColor = Color.Red; hoursWorked[3] = 0; }
             if (!double.TryParse(day5.Text, out hoursWorked[4]) || hoursWorked[4] < 0) { day5.ForeColor = Color.Red; hoursWorked[4] = 0; }
             if (!double.TryParse(day6.Text, out hoursWorked[5]) || hoursWorked[5] < 0) { day6.ForeColor = Color.Red; hoursWorked[5] = 0; }
             if (!double.TryParse(day7.Text, out hoursWorked[6]) || hoursWorked[6] < 0) { day7.ForeColor = Color.Red; hoursWorked[6] = 0; }
             if (!double.TryParse(day8.Text, out hoursWorked[7]) || hoursWorked[7] < 0) { day8.ForeColor = Color.Red; hoursWorked[7] = 0; }
             if (!double.TryParse(day9.Text, out hoursWorked[8]) || hoursWorked[8] < 0) { day9.ForeColor = Color.Red; hoursWorked[8] = 0; }
             if (!double.TryParse(day10.Text, out hoursWorked[9]) || hoursWorked[9] < 0) { day10.ForeColor = Color.Red; hoursWorked[9] = 0; }
             if (!double.TryParse(day11.Text, out hoursWorked[10]) || hoursWorked[10] < 0) { day11.ForeColor = Color.Red; hoursWorked[10] = 0; }
             if (!double.TryParse(day12.Text, out hoursWorked[11]) || hoursWorked[11] < 0) { day12.ForeColor = Color.Red; hoursWorked[11] = 0; }
             if (!double.TryParse(day13.Text, out hoursWorked[12]) || hoursWorked[12] < 0) { day13.ForeColor = Color.Red; hoursWorked[12] = 0; }
             if (!double.TryParse(day14.Text, out hoursWorked[13]) || hoursWorked[13] < 0) { day14.ForeColor = Color.Red; hoursWorked[13] = 0; }

             

            

            //adding up all the hours worked
            double totalHoursWorkedWeek1 = 0;
            for (int x = 0; x < 7; ++x)
            {
                totalHoursWorkedWeek1 += hoursWorked[x];

            }
            double totalHoursWorkedWeek2 = 0;
            for (int x = 7; x < 14; ++x)
            {
                totalHoursWorkedWeek2 += hoursWorked[x];

            }
            //finding total hours worked per week
            double overTimeHoursWeek1=0, regularHoursWeek1 =0;
            // wk1
            if (totalHoursWorkedWeek1 > 40)
            {
                overTimeHoursWeek1 = totalHoursWorkedWeek1 - 40;
                regularHoursWeek1 = totalHoursWorkedWeek1 - overTimeHoursWeek1;
            }
            else
            {
                regularHoursWeek1 = totalHoursWorkedWeek1;
            }
            double overTimeHoursWeek2 = 0, regularHoursWeek2 = 0;
            //wk2
            if (totalHoursWorkedWeek2 > 40)
            {
                overTimeHoursWeek2 = totalHoursWorkedWeek2 - 40;
                regularHoursWeek2 = totalHoursWorkedWeek2 - overTimeHoursWeek2;
            }
            else
            {
                regularHoursWeek2 = totalHoursWorkedWeek2;
            }

            double totalRegularHours, totalOverTimeHours;
            totalOverTimeHours = overTimeHoursWeek1 + overTimeHoursWeek2;
            totalRegularHours = regularHoursWeek1 + regularHoursWeek2;

            //finding total regular hour pay
            double totalRegularHoursPay = 0;
            totalRegularHoursPay = (totalRegularHours) * hourlyRate;
            double totalOverTimePay = 0;
            totalOverTimePay = totalOverTimeHours * (1.5 * hourlyRate);
            overtimeAmountTextBox.Text = totalOverTimePay.ToString("C2");
            regularAmountTextBox.Text = totalRegularHoursPay.ToString("C2");
            regularHoursTextBox.Text = totalRegularHours.ToString();
            overtimeHoursTextBox.Text = totalOverTimeHours.ToString();
            
            //setting the grossPay textbox 
            double grossPay = (totalOverTimePay + totalRegularHoursPay);
            grossPayTextBox.Text = grossPay.ToString("C2");

        }
        
    }
}
