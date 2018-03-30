namespace FullertonMaidService
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.employeeIdentificationGroupBox = new System.Windows.Forms.GroupBox();
            this.timeSheetGroupBox = new System.Windows.Forms.GroupBox();
            this.payrollProcessingGroupBox = new System.Windows.Forms.GroupBox();
            this.processButton = new System.Windows.Forms.Button();
            this.regularHoursTextBox = new System.Windows.Forms.TextBox();
            this.overtimeHoursTextBox = new System.Windows.Forms.TextBox();
            this.regularAmountTextBox = new System.Windows.Forms.TextBox();
            this.overtimeAmountTextBox = new System.Windows.Forms.TextBox();
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            this.regularHoursLabel = new System.Windows.Forms.Label();
            this.overtimeHoursLabel = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.payrollHoursLabel = new System.Windows.Forms.Label();
            this.payrollAmountLabel = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.hourlySalaryTextBox = new System.Windows.Forms.TextBox();
            this.hourlySalaryLabel = new System.Windows.Forms.Label();
            this.day1 = new System.Windows.Forms.TextBox();
            this.day2 = new System.Windows.Forms.TextBox();
            this.day3 = new System.Windows.Forms.TextBox();
            this.day5 = new System.Windows.Forms.TextBox();
            this.day4 = new System.Windows.Forms.TextBox();
            this.day6 = new System.Windows.Forms.TextBox();
            this.day7 = new System.Windows.Forms.TextBox();
            this.day14 = new System.Windows.Forms.TextBox();
            this.day13 = new System.Windows.Forms.TextBox();
            this.day11 = new System.Windows.Forms.TextBox();
            this.day12 = new System.Windows.Forms.TextBox();
            this.day10 = new System.Windows.Forms.TextBox();
            this.day9 = new System.Windows.Forms.TextBox();
            this.day8 = new System.Windows.Forms.TextBox();
            this.firstWeekLabel = new System.Windows.Forms.Label();
            this.secondWeekLabel = new System.Windows.Forms.Label();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.wednesdayLabel = new System.Windows.Forms.Label();
            this.tuesdayLabel = new System.Windows.Forms.Label();
            this.thursdayLabel = new System.Windows.Forms.Label();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.sundayLabel = new System.Windows.Forms.Label();
            this.saturdayLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.employeeIdentificationGroupBox.SuspendLayout();
            this.timeSheetGroupBox.SuspendLayout();
            this.payrollProcessingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeIdentificationGroupBox
            // 
            this.employeeIdentificationGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.employeeIdentificationGroupBox.Controls.Add(this.hourlySalaryLabel);
            this.employeeIdentificationGroupBox.Controls.Add(this.hourlySalaryTextBox);
            this.employeeIdentificationGroupBox.Controls.Add(this.employeeNameLabel);
            this.employeeIdentificationGroupBox.Controls.Add(this.employeeNameTextBox);
            this.employeeIdentificationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.employeeIdentificationGroupBox.Name = "employeeIdentificationGroupBox";
            this.employeeIdentificationGroupBox.Size = new System.Drawing.Size(685, 62);
            this.employeeIdentificationGroupBox.TabIndex = 0;
            this.employeeIdentificationGroupBox.TabStop = false;
            this.employeeIdentificationGroupBox.Text = "Employee Identification";
            // 
            // timeSheetGroupBox
            // 
            this.timeSheetGroupBox.Controls.Add(this.saturdayLabel);
            this.timeSheetGroupBox.Controls.Add(this.sundayLabel);
            this.timeSheetGroupBox.Controls.Add(this.fridayLabel);
            this.timeSheetGroupBox.Controls.Add(this.thursdayLabel);
            this.timeSheetGroupBox.Controls.Add(this.tuesdayLabel);
            this.timeSheetGroupBox.Controls.Add(this.wednesdayLabel);
            this.timeSheetGroupBox.Controls.Add(this.mondayLabel);
            this.timeSheetGroupBox.Controls.Add(this.secondWeekLabel);
            this.timeSheetGroupBox.Controls.Add(this.firstWeekLabel);
            this.timeSheetGroupBox.Controls.Add(this.day14);
            this.timeSheetGroupBox.Controls.Add(this.day13);
            this.timeSheetGroupBox.Controls.Add(this.day11);
            this.timeSheetGroupBox.Controls.Add(this.day12);
            this.timeSheetGroupBox.Controls.Add(this.day10);
            this.timeSheetGroupBox.Controls.Add(this.day9);
            this.timeSheetGroupBox.Controls.Add(this.day8);
            this.timeSheetGroupBox.Controls.Add(this.day7);
            this.timeSheetGroupBox.Controls.Add(this.day6);
            this.timeSheetGroupBox.Controls.Add(this.day4);
            this.timeSheetGroupBox.Controls.Add(this.day5);
            this.timeSheetGroupBox.Controls.Add(this.day3);
            this.timeSheetGroupBox.Controls.Add(this.day2);
            this.timeSheetGroupBox.Controls.Add(this.day1);
            this.timeSheetGroupBox.Location = new System.Drawing.Point(12, 80);
            this.timeSheetGroupBox.Name = "timeSheetGroupBox";
            this.timeSheetGroupBox.Size = new System.Drawing.Size(685, 110);
            this.timeSheetGroupBox.TabIndex = 1;
            this.timeSheetGroupBox.TabStop = false;
            this.timeSheetGroupBox.Text = "Time Sheet";
            // 
            // payrollProcessingGroupBox
            // 
            this.payrollProcessingGroupBox.Controls.Add(this.resetButton);
            this.payrollProcessingGroupBox.Controls.Add(this.payrollAmountLabel);
            this.payrollProcessingGroupBox.Controls.Add(this.payrollHoursLabel);
            this.payrollProcessingGroupBox.Controls.Add(this.grossPayLabel);
            this.payrollProcessingGroupBox.Controls.Add(this.overtimeHoursLabel);
            this.payrollProcessingGroupBox.Controls.Add(this.regularHoursLabel);
            this.payrollProcessingGroupBox.Controls.Add(this.grossPayTextBox);
            this.payrollProcessingGroupBox.Controls.Add(this.overtimeAmountTextBox);
            this.payrollProcessingGroupBox.Controls.Add(this.regularAmountTextBox);
            this.payrollProcessingGroupBox.Controls.Add(this.overtimeHoursTextBox);
            this.payrollProcessingGroupBox.Controls.Add(this.regularHoursTextBox);
            this.payrollProcessingGroupBox.Controls.Add(this.processButton);
            this.payrollProcessingGroupBox.Location = new System.Drawing.Point(12, 196);
            this.payrollProcessingGroupBox.Name = "payrollProcessingGroupBox";
            this.payrollProcessingGroupBox.Size = new System.Drawing.Size(685, 84);
            this.payrollProcessingGroupBox.TabIndex = 2;
            this.payrollProcessingGroupBox.TabStop = false;
            this.payrollProcessingGroupBox.Text = "Payroll Processing";
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(6, 35);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 16;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // regularHoursTextBox
            // 
            this.regularHoursTextBox.Location = new System.Drawing.Point(281, 32);
            this.regularHoursTextBox.Name = "regularHoursTextBox";
            this.regularHoursTextBox.ReadOnly = true;
            this.regularHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.regularHoursTextBox.TabIndex = 1;
            this.regularHoursTextBox.TabStop = false;
            this.regularHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // overtimeHoursTextBox
            // 
            this.overtimeHoursTextBox.Location = new System.Drawing.Point(281, 58);
            this.overtimeHoursTextBox.Name = "overtimeHoursTextBox";
            this.overtimeHoursTextBox.ReadOnly = true;
            this.overtimeHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.overtimeHoursTextBox.TabIndex = 2;
            this.overtimeHoursTextBox.TabStop = false;
            this.overtimeHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // regularAmountTextBox
            // 
            this.regularAmountTextBox.Location = new System.Drawing.Point(396, 32);
            this.regularAmountTextBox.Name = "regularAmountTextBox";
            this.regularAmountTextBox.ReadOnly = true;
            this.regularAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.regularAmountTextBox.TabIndex = 3;
            this.regularAmountTextBox.TabStop = false;
            this.regularAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // overtimeAmountTextBox
            // 
            this.overtimeAmountTextBox.Location = new System.Drawing.Point(396, 58);
            this.overtimeAmountTextBox.Name = "overtimeAmountTextBox";
            this.overtimeAmountTextBox.ReadOnly = true;
            this.overtimeAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.overtimeAmountTextBox.TabIndex = 4;
            this.overtimeAmountTextBox.TabStop = false;
            this.overtimeAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grossPayTextBox
            // 
            this.grossPayTextBox.Location = new System.Drawing.Point(585, 32);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.ReadOnly = true;
            this.grossPayTextBox.Size = new System.Drawing.Size(100, 20);
            this.grossPayTextBox.TabIndex = 5;
            this.grossPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // regularHoursLabel
            // 
            this.regularHoursLabel.AutoSize = true;
            this.regularHoursLabel.Location = new System.Drawing.Point(221, 35);
            this.regularHoursLabel.Name = "regularHoursLabel";
            this.regularHoursLabel.Size = new System.Drawing.Size(50, 13);
            this.regularHoursLabel.TabIndex = 6;
            this.regularHoursLabel.Text = "Regular: ";
            // 
            // overtimeHoursLabel
            // 
            this.overtimeHoursLabel.AutoSize = true;
            this.overtimeHoursLabel.Location = new System.Drawing.Point(221, 61);
            this.overtimeHoursLabel.Name = "overtimeHoursLabel";
            this.overtimeHoursLabel.Size = new System.Drawing.Size(55, 13);
            this.overtimeHoursLabel.TabIndex = 7;
            this.overtimeHoursLabel.Text = "Overtime: ";
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Location = new System.Drawing.Point(518, 35);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(61, 13);
            this.grossPayLabel.TabIndex = 8;
            this.grossPayLabel.Text = "Gross Pay: ";
            // 
            // payrollHoursLabel
            // 
            this.payrollHoursLabel.AutoSize = true;
            this.payrollHoursLabel.Location = new System.Drawing.Point(313, 16);
            this.payrollHoursLabel.Name = "payrollHoursLabel";
            this.payrollHoursLabel.Size = new System.Drawing.Size(35, 13);
            this.payrollHoursLabel.TabIndex = 9;
            this.payrollHoursLabel.Text = "Hours";
            // 
            // payrollAmountLabel
            // 
            this.payrollAmountLabel.AutoSize = true;
            this.payrollAmountLabel.Location = new System.Drawing.Point(430, 16);
            this.payrollAmountLabel.Name = "payrollAmountLabel";
            this.payrollAmountLabel.Size = new System.Drawing.Size(43, 13);
            this.payrollAmountLabel.TabIndex = 10;
            this.payrollAmountLabel.Text = "Amount";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(102, 20);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(394, 20);
            this.employeeNameTextBox.TabIndex = 0;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(6, 23);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(90, 13);
            this.employeeNameLabel.TabIndex = 1;
            this.employeeNameLabel.Text = "Employee Name: ";
            // 
            // hourlySalaryTextBox
            // 
            this.hourlySalaryTextBox.Location = new System.Drawing.Point(604, 23);
            this.hourlySalaryTextBox.Name = "hourlySalaryTextBox";
            this.hourlySalaryTextBox.Size = new System.Drawing.Size(75, 20);
            this.hourlySalaryTextBox.TabIndex = 1;
            this.hourlySalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hourlySalaryLabel
            // 
            this.hourlySalaryLabel.AutoSize = true;
            this.hourlySalaryLabel.Location = new System.Drawing.Point(518, 23);
            this.hourlySalaryLabel.Name = "hourlySalaryLabel";
            this.hourlySalaryLabel.Size = new System.Drawing.Size(75, 13);
            this.hourlySalaryLabel.TabIndex = 3;
            this.hourlySalaryLabel.Text = "Hourly Salary: ";
            // 
            // day1
            // 
            this.day1.Location = new System.Drawing.Point(100, 43);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(56, 20);
            this.day1.TabIndex = 2;
            this.day1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day2
            // 
            this.day2.Location = new System.Drawing.Point(162, 43);
            this.day2.Name = "day2";
            this.day2.Size = new System.Drawing.Size(56, 20);
            this.day2.TabIndex = 3;
            this.day2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day3
            // 
            this.day3.Location = new System.Drawing.Point(224, 45);
            this.day3.Name = "day3";
            this.day3.Size = new System.Drawing.Size(56, 20);
            this.day3.TabIndex = 4;
            this.day3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day5
            // 
            this.day5.Location = new System.Drawing.Point(348, 45);
            this.day5.Name = "day5";
            this.day5.Size = new System.Drawing.Size(56, 20);
            this.day5.TabIndex = 6;
            this.day5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day4
            // 
            this.day4.Location = new System.Drawing.Point(286, 45);
            this.day4.Name = "day4";
            this.day4.Size = new System.Drawing.Size(56, 20);
            this.day4.TabIndex = 5;
            this.day4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day6
            // 
            this.day6.Location = new System.Drawing.Point(410, 45);
            this.day6.Name = "day6";
            this.day6.Size = new System.Drawing.Size(56, 20);
            this.day6.TabIndex = 7;
            this.day6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day7
            // 
            this.day7.Location = new System.Drawing.Point(472, 45);
            this.day7.Name = "day7";
            this.day7.Size = new System.Drawing.Size(56, 20);
            this.day7.TabIndex = 8;
            this.day7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day14
            // 
            this.day14.Location = new System.Drawing.Point(472, 83);
            this.day14.Name = "day14";
            this.day14.Size = new System.Drawing.Size(56, 20);
            this.day14.TabIndex = 15;
            this.day14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day13
            // 
            this.day13.Location = new System.Drawing.Point(410, 83);
            this.day13.Name = "day13";
            this.day13.Size = new System.Drawing.Size(56, 20);
            this.day13.TabIndex = 14;
            this.day13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day11
            // 
            this.day11.Location = new System.Drawing.Point(286, 83);
            this.day11.Name = "day11";
            this.day11.Size = new System.Drawing.Size(56, 20);
            this.day11.TabIndex = 12;
            this.day11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day12
            // 
            this.day12.Location = new System.Drawing.Point(348, 83);
            this.day12.Name = "day12";
            this.day12.Size = new System.Drawing.Size(56, 20);
            this.day12.TabIndex = 13;
            this.day12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day10
            // 
            this.day10.Location = new System.Drawing.Point(224, 83);
            this.day10.Name = "day10";
            this.day10.Size = new System.Drawing.Size(56, 20);
            this.day10.TabIndex = 11;
            this.day10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day9
            // 
            this.day9.Location = new System.Drawing.Point(162, 81);
            this.day9.Name = "day9";
            this.day9.Size = new System.Drawing.Size(56, 20);
            this.day9.TabIndex = 10;
            this.day9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // day8
            // 
            this.day8.Location = new System.Drawing.Point(100, 81);
            this.day8.Name = "day8";
            this.day8.Size = new System.Drawing.Size(56, 20);
            this.day8.TabIndex = 9;
            this.day8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // firstWeekLabel
            // 
            this.firstWeekLabel.AutoSize = true;
            this.firstWeekLabel.Location = new System.Drawing.Point(30, 50);
            this.firstWeekLabel.Name = "firstWeekLabel";
            this.firstWeekLabel.Size = new System.Drawing.Size(64, 13);
            this.firstWeekLabel.TabIndex = 15;
            this.firstWeekLabel.Text = "First Week: ";
            // 
            // secondWeekLabel
            // 
            this.secondWeekLabel.AutoSize = true;
            this.secondWeekLabel.Location = new System.Drawing.Point(12, 86);
            this.secondWeekLabel.Name = "secondWeekLabel";
            this.secondWeekLabel.Size = new System.Drawing.Size(82, 13);
            this.secondWeekLabel.TabIndex = 16;
            this.secondWeekLabel.Text = "Second Week: ";
            // 
            // mondayLabel
            // 
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.Location = new System.Drawing.Point(109, 29);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(45, 13);
            this.mondayLabel.TabIndex = 17;
            this.mondayLabel.Text = "Monday";
            // 
            // wednesdayLabel
            // 
            this.wednesdayLabel.AutoSize = true;
            this.wednesdayLabel.Location = new System.Drawing.Point(221, 29);
            this.wednesdayLabel.Name = "wednesdayLabel";
            this.wednesdayLabel.Size = new System.Drawing.Size(64, 13);
            this.wednesdayLabel.TabIndex = 18;
            this.wednesdayLabel.Text = "Wednesday";
            // 
            // tuesdayLabel
            // 
            this.tuesdayLabel.AutoSize = true;
            this.tuesdayLabel.Location = new System.Drawing.Point(167, 29);
            this.tuesdayLabel.Name = "tuesdayLabel";
            this.tuesdayLabel.Size = new System.Drawing.Size(48, 13);
            this.tuesdayLabel.TabIndex = 19;
            this.tuesdayLabel.Text = "Tuesday";
            // 
            // thursdayLabel
            // 
            this.thursdayLabel.AutoSize = true;
            this.thursdayLabel.Location = new System.Drawing.Point(291, 29);
            this.thursdayLabel.Name = "thursdayLabel";
            this.thursdayLabel.Size = new System.Drawing.Size(51, 13);
            this.thursdayLabel.TabIndex = 20;
            this.thursdayLabel.Text = "Thursday";
            // 
            // fridayLabel
            // 
            this.fridayLabel.AutoSize = true;
            this.fridayLabel.Location = new System.Drawing.Point(358, 29);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(35, 13);
            this.fridayLabel.TabIndex = 21;
            this.fridayLabel.Text = "Friday";
            // 
            // sundayLabel
            // 
            this.sundayLabel.AutoSize = true;
            this.sundayLabel.Location = new System.Drawing.Point(482, 29);
            this.sundayLabel.Name = "sundayLabel";
            this.sundayLabel.Size = new System.Drawing.Size(43, 13);
            this.sundayLabel.TabIndex = 22;
            this.sundayLabel.Text = "Sunday";
            // 
            // saturdayLabel
            // 
            this.saturdayLabel.AutoSize = true;
            this.saturdayLabel.Location = new System.Drawing.Point(417, 29);
            this.saturdayLabel.Name = "saturdayLabel";
            this.saturdayLabel.Size = new System.Drawing.Size(49, 13);
            this.saturdayLabel.TabIndex = 23;
            this.saturdayLabel.Text = "Saturday";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(585, 59);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 23);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 296);
            this.Controls.Add(this.payrollProcessingGroupBox);
            this.Controls.Add(this.timeSheetGroupBox);
            this.Controls.Add(this.employeeIdentificationGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fullerton Maid Service - Employee Payroll";
            this.employeeIdentificationGroupBox.ResumeLayout(false);
            this.employeeIdentificationGroupBox.PerformLayout();
            this.timeSheetGroupBox.ResumeLayout(false);
            this.timeSheetGroupBox.PerformLayout();
            this.payrollProcessingGroupBox.ResumeLayout(false);
            this.payrollProcessingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox employeeIdentificationGroupBox;
        private System.Windows.Forms.Label hourlySalaryLabel;
        private System.Windows.Forms.TextBox hourlySalaryTextBox;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.GroupBox timeSheetGroupBox;
        private System.Windows.Forms.Label saturdayLabel;
        private System.Windows.Forms.Label sundayLabel;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.Label thursdayLabel;
        private System.Windows.Forms.Label tuesdayLabel;
        private System.Windows.Forms.Label wednesdayLabel;
        private System.Windows.Forms.Label mondayLabel;
        private System.Windows.Forms.Label secondWeekLabel;
        private System.Windows.Forms.Label firstWeekLabel;
        private System.Windows.Forms.TextBox day14;
        private System.Windows.Forms.TextBox day13;
        private System.Windows.Forms.TextBox day11;
        private System.Windows.Forms.TextBox day12;
        private System.Windows.Forms.TextBox day10;
        private System.Windows.Forms.TextBox day9;
        private System.Windows.Forms.TextBox day8;
        private System.Windows.Forms.TextBox day7;
        private System.Windows.Forms.TextBox day6;
        private System.Windows.Forms.TextBox day4;
        private System.Windows.Forms.TextBox day5;
        private System.Windows.Forms.TextBox day3;
        private System.Windows.Forms.TextBox day2;
        private System.Windows.Forms.TextBox day1;
        private System.Windows.Forms.GroupBox payrollProcessingGroupBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label payrollAmountLabel;
        private System.Windows.Forms.Label payrollHoursLabel;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Label overtimeHoursLabel;
        private System.Windows.Forms.Label regularHoursLabel;
        private System.Windows.Forms.TextBox grossPayTextBox;
        private System.Windows.Forms.TextBox overtimeAmountTextBox;
        private System.Windows.Forms.TextBox regularAmountTextBox;
        private System.Windows.Forms.TextBox overtimeHoursTextBox;
        private System.Windows.Forms.TextBox regularHoursTextBox;
        private System.Windows.Forms.Button processButton;
    }
}

