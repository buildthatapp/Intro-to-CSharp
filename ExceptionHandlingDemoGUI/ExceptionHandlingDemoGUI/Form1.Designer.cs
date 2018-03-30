namespace ExceptionHandlingDemoGUI
{
    partial class ExceptionHandlingDemoGUI
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
            this.okButton = new System.Windows.Forms.Button();
            this.enterAnIntegerTextBox = new System.Windows.Forms.TextBox();
            this.enterAnIntegerLabel = new System.Windows.Forms.Label();
            this.messageToUserLabel = new System.Windows.Forms.Label();
            this.messagerToUserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(96, 118);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // enterAnIntegerTextBox
            // 
            this.enterAnIntegerTextBox.Location = new System.Drawing.Point(154, 74);
            this.enterAnIntegerTextBox.Name = "enterAnIntegerTextBox";
            this.enterAnIntegerTextBox.Size = new System.Drawing.Size(54, 20);
            this.enterAnIntegerTextBox.TabIndex = 1;
            // 
            // enterAnIntegerLabel
            // 
            this.enterAnIntegerLabel.AutoSize = true;
            this.enterAnIntegerLabel.Location = new System.Drawing.Point(41, 81);
            this.enterAnIntegerLabel.Name = "enterAnIntegerLabel";
            this.enterAnIntegerLabel.Size = new System.Drawing.Size(89, 13);
            this.enterAnIntegerLabel.TabIndex = 2;
            this.enterAnIntegerLabel.Text = "Enter an Integer: ";
            // 
            // messageToUserLabel
            // 
            this.messageToUserLabel.AutoSize = true;
            this.messageToUserLabel.Location = new System.Drawing.Point(41, 162);
            this.messageToUserLabel.Name = "messageToUserLabel";
            this.messageToUserLabel.Size = new System.Drawing.Size(0, 13);
            this.messageToUserLabel.TabIndex = 3;
           
            // 
            // messagerToUserLabel
            // 
            this.messagerToUserLabel.AutoSize = true;
            this.messagerToUserLabel.Location = new System.Drawing.Point(44, 162);
            this.messagerToUserLabel.Name = "messagerToUserLabel";
            this.messagerToUserLabel.Size = new System.Drawing.Size(145, 13);
            this.messagerToUserLabel.TabIndex = 4;
            this.messagerToUserLabel.Text = "Successfully entered a \"221\"";
            // 
            // ExceptionHandlingDemoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.messagerToUserLabel);
            this.Controls.Add(this.messageToUserLabel);
            this.Controls.Add(this.enterAnIntegerLabel);
            this.Controls.Add(this.enterAnIntegerTextBox);
            this.Controls.Add(this.okButton);
            this.Name = "ExceptionHandlingDemoGUI";
            this.Text = "ExceptionHandling Demo";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox enterAnIntegerTextBox;
        private System.Windows.Forms.Label enterAnIntegerLabel;
        private System.Windows.Forms.Label messageToUserLabel;
        private System.Windows.Forms.Label messagerToUserLabel;
    }
}

