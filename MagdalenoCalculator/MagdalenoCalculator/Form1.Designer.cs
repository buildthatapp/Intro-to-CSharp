namespace MagdalenoCalculator
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
            this.calculatorButtons = new System.Windows.Forms.GroupBox();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.equalButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multiplybutton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.calculatorButtons.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculatorButtons
            // 
            this.calculatorButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calculatorButtons.Controls.Add(this.displayBox);
            this.calculatorButtons.Controls.Add(this.buttonsPanel);
            this.calculatorButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculatorButtons.Location = new System.Drawing.Point(0, 0);
            this.calculatorButtons.Name = "calculatorButtons";
            this.calculatorButtons.Size = new System.Drawing.Size(303, 349);
            this.calculatorButtons.TabIndex = 0;
            this.calculatorButtons.TabStop = false;
            // 
            // displayBox
            // 
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.Location = new System.Drawing.Point(12, 12);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(279, 63);
            this.displayBox.TabIndex = 1;
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.White;
            this.buttonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonsPanel.Controls.Add(this.equalButton);
            this.buttonsPanel.Controls.Add(this.decimalButton);
            this.buttonsPanel.Controls.Add(this.zeroButton);
            this.buttonsPanel.Controls.Add(this.minusButton);
            this.buttonsPanel.Controls.Add(this.multiplybutton);
            this.buttonsPanel.Controls.Add(this.divideButton);
            this.buttonsPanel.Controls.Add(this.clearButton);
            this.buttonsPanel.Controls.Add(this.nineButton);
            this.buttonsPanel.Controls.Add(this.eightButton);
            this.buttonsPanel.Controls.Add(this.sevenButton);
            this.buttonsPanel.Controls.Add(this.plusButton);
            this.buttonsPanel.Controls.Add(this.sixButton);
            this.buttonsPanel.Controls.Add(this.fiveButton);
            this.buttonsPanel.Controls.Add(this.fourButton);
            this.buttonsPanel.Controls.Add(this.threeButton);
            this.buttonsPanel.Controls.Add(this.twoButton);
            this.buttonsPanel.Controls.Add(this.oneButton);
            this.buttonsPanel.Location = new System.Drawing.Point(12, 83);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(279, 249);
            this.buttonsPanel.TabIndex = 0;
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.equalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.equalButton.FlatAppearance.BorderSize = 5;
            this.equalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equalButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(211, 150);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(63, 92);
            this.equalButton.TabIndex = 19;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // decimalButton
            // 
            this.decimalButton.BackColor = System.Drawing.Color.Black;
            this.decimalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.decimalButton.FlatAppearance.BorderSize = 5;
            this.decimalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.decimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decimalButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.ForeColor = System.Drawing.Color.White;
            this.decimalButton.Location = new System.Drawing.Point(142, 199);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(63, 43);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = false;
            this.decimalButton.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.Black;
            this.zeroButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zeroButton.FlatAppearance.BorderSize = 5;
            this.zeroButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zeroButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.ForeColor = System.Drawing.Color.White;
            this.zeroButton.Location = new System.Drawing.Point(4, 199);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(132, 43);
            this.zeroButton.TabIndex = 16;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Gray;
            this.minusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.minusButton.FlatAppearance.BorderSize = 5;
            this.minusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minusButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.Color.White;
            this.minusButton.Location = new System.Drawing.Point(211, 3);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(63, 43);
            this.minusButton.TabIndex = 15;
            this.minusButton.Tag = "Operator";
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // multiplybutton
            // 
            this.multiplybutton.BackColor = System.Drawing.Color.Gray;
            this.multiplybutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.multiplybutton.FlatAppearance.BorderSize = 5;
            this.multiplybutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.multiplybutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplybutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplybutton.ForeColor = System.Drawing.Color.White;
            this.multiplybutton.Location = new System.Drawing.Point(142, 3);
            this.multiplybutton.Name = "multiplybutton";
            this.multiplybutton.Size = new System.Drawing.Size(63, 43);
            this.multiplybutton.TabIndex = 14;
            this.multiplybutton.Text = "×";
            this.multiplybutton.UseVisualStyleBackColor = false;
            this.multiplybutton.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.Color.Gray;
            this.divideButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.divideButton.FlatAppearance.BorderSize = 5;
            this.divideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divideButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.ForeColor = System.Drawing.Color.White;
            this.divideButton.Location = new System.Drawing.Point(73, 3);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(63, 43);
            this.divideButton.TabIndex = 13;
            this.divideButton.Text = "÷";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Gray;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearButton.FlatAppearance.BorderSize = 5;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(4, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(63, 43);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.Black;
            this.nineButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nineButton.FlatAppearance.BorderSize = 5;
            this.nineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nineButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.ForeColor = System.Drawing.Color.White;
            this.nineButton.Location = new System.Drawing.Point(142, 52);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(63, 43);
            this.nineButton.TabIndex = 10;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.Black;
            this.eightButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eightButton.FlatAppearance.BorderSize = 5;
            this.eightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eightButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.ForeColor = System.Drawing.Color.White;
            this.eightButton.Location = new System.Drawing.Point(73, 52);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(63, 43);
            this.eightButton.TabIndex = 9;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.Black;
            this.sevenButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sevenButton.FlatAppearance.BorderSize = 5;
            this.sevenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sevenButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.ForeColor = System.Drawing.Color.White;
            this.sevenButton.Location = new System.Drawing.Point(4, 52);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(63, 43);
            this.sevenButton.TabIndex = 8;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.Gray;
            this.plusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.plusButton.FlatAppearance.BorderSize = 5;
            this.plusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.ForeColor = System.Drawing.Color.White;
            this.plusButton.Location = new System.Drawing.Point(211, 52);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(63, 92);
            this.plusButton.TabIndex = 7;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.Black;
            this.sixButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sixButton.FlatAppearance.BorderSize = 5;
            this.sixButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sixButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.ForeColor = System.Drawing.Color.White;
            this.sixButton.Location = new System.Drawing.Point(142, 101);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(63, 43);
            this.sixButton.TabIndex = 6;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.Black;
            this.fiveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fiveButton.FlatAppearance.BorderSize = 5;
            this.fiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fiveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.ForeColor = System.Drawing.Color.White;
            this.fiveButton.Location = new System.Drawing.Point(73, 101);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(63, 43);
            this.fiveButton.TabIndex = 5;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.Black;
            this.fourButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fourButton.FlatAppearance.BorderSize = 5;
            this.fourButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fourButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.ForeColor = System.Drawing.Color.White;
            this.fourButton.Location = new System.Drawing.Point(4, 101);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(63, 43);
            this.fourButton.TabIndex = 4;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.Black;
            this.threeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.threeButton.FlatAppearance.BorderSize = 5;
            this.threeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.threeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.ForeColor = System.Drawing.Color.White;
            this.threeButton.Location = new System.Drawing.Point(142, 150);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(63, 43);
            this.threeButton.TabIndex = 2;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.Black;
            this.twoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.twoButton.FlatAppearance.BorderSize = 5;
            this.twoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twoButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.ForeColor = System.Drawing.Color.White;
            this.twoButton.Location = new System.Drawing.Point(73, 150);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(63, 43);
            this.twoButton.TabIndex = 1;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.Black;
            this.oneButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.oneButton.FlatAppearance.BorderSize = 5;
            this.oneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oneButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.ForeColor = System.Drawing.Color.White;
            this.oneButton.Location = new System.Drawing.Point(4, 150);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(63, 43);
            this.oneButton.TabIndex = 0;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(303, 349);
            this.Controls.Add(this.calculatorButtons);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.calculatorButtons.ResumeLayout(false);
            this.calculatorButtons.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox calculatorButtons;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multiplybutton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.TextBox displayBox;
    }
}

