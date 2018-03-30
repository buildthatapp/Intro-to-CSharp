namespace Restaurant
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
            this.appetizersLabel = new System.Windows.Forms.Label();
            this.mainDishLabel = new System.Windows.Forms.Label();
            this.dessertLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.garlicBreadRadio = new System.Windows.Forms.RadioButton();
            this.shrimpCocktailRadio = new System.Windows.Forms.RadioButton();
            this.stuffedMushroomsRadio = new System.Windows.Forms.RadioButton();
            this.lasagnaWithMeatSauceRadio = new System.Windows.Forms.RadioButton();
            this.linguiniWithClamSauce = new System.Windows.Forms.RadioButton();
            this.spaghettiWithMarinaraSauceRadio = new System.Windows.Forms.RadioButton();
            this.canoliRadio = new System.Windows.Forms.RadioButton();
            this.chocolateTruffleRadio = new System.Windows.Forms.RadioButton();
            this.tiramisuRadio = new System.Windows.Forms.RadioButton();
            this.priceLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // appetizersLabel
            // 
            this.appetizersLabel.AutoSize = true;
            this.appetizersLabel.Location = new System.Drawing.Point(12, 28);
            this.appetizersLabel.Name = "appetizersLabel";
            this.appetizersLabel.Size = new System.Drawing.Size(56, 13);
            this.appetizersLabel.TabIndex = 0;
            this.appetizersLabel.Text = "Appetizers";
            // 
            // mainDishLabel
            // 
            this.mainDishLabel.AutoSize = true;
            this.mainDishLabel.Location = new System.Drawing.Point(12, 147);
            this.mainDishLabel.Name = "mainDishLabel";
            this.mainDishLabel.Size = new System.Drawing.Size(54, 13);
            this.mainDishLabel.TabIndex = 1;
            this.mainDishLabel.Text = "Main Dish";
            // 
            // dessertLabel
            // 
            this.dessertLabel.AutoSize = true;
            this.dessertLabel.Location = new System.Drawing.Point(12, 267);
            this.dessertLabel.Name = "dessertLabel";
            this.dessertLabel.Size = new System.Drawing.Size(43, 13);
            this.dessertLabel.TabIndex = 2;
            this.dessertLabel.Text = "Dessert";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stuffedMushroomsRadio);
            this.groupBox1.Controls.Add(this.shrimpCocktailRadio);
            this.groupBox1.Controls.Add(this.garlicBreadRadio);
            this.groupBox1.Location = new System.Drawing.Point(19, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.spaghettiWithMarinaraSauceRadio);
            this.groupBox2.Controls.Add(this.linguiniWithClamSauce);
            this.groupBox2.Controls.Add(this.lasagnaWithMeatSauceRadio);
            this.groupBox2.Location = new System.Drawing.Point(19, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tiramisuRadio);
            this.groupBox3.Controls.Add(this.chocolateTruffleRadio);
            this.groupBox3.Controls.Add(this.canoliRadio);
            this.groupBox3.Location = new System.Drawing.Point(19, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // garlicBreadRadio
            // 
            this.garlicBreadRadio.AutoSize = true;
            this.garlicBreadRadio.Location = new System.Drawing.Point(7, 11);
            this.garlicBreadRadio.Name = "garlicBreadRadio";
            this.garlicBreadRadio.Size = new System.Drawing.Size(83, 17);
            this.garlicBreadRadio.TabIndex = 0;
            this.garlicBreadRadio.TabStop = true;
            this.garlicBreadRadio.Text = "Garlic Bread";
            this.garlicBreadRadio.UseVisualStyleBackColor = true;
            this.garlicBreadRadio.CheckedChanged += new System.EventHandler(this.garlicBreadRadio_CheckedChanged);
            // 
            // shrimpCocktailRadio
            // 
            this.shrimpCocktailRadio.AutoSize = true;
            this.shrimpCocktailRadio.Location = new System.Drawing.Point(7, 35);
            this.shrimpCocktailRadio.Name = "shrimpCocktailRadio";
            this.shrimpCocktailRadio.Size = new System.Drawing.Size(98, 17);
            this.shrimpCocktailRadio.TabIndex = 1;
            this.shrimpCocktailRadio.TabStop = true;
            this.shrimpCocktailRadio.Text = "Shrimp Cocktail";
            this.shrimpCocktailRadio.UseVisualStyleBackColor = true;
            this.shrimpCocktailRadio.CheckedChanged += new System.EventHandler(this.shrimpCocktailRadio_CheckedChanged);
            // 
            // stuffedMushroomsRadio
            // 
            this.stuffedMushroomsRadio.AutoSize = true;
            this.stuffedMushroomsRadio.Location = new System.Drawing.Point(7, 59);
            this.stuffedMushroomsRadio.Name = "stuffedMushroomsRadio";
            this.stuffedMushroomsRadio.Size = new System.Drawing.Size(116, 17);
            this.stuffedMushroomsRadio.TabIndex = 2;
            this.stuffedMushroomsRadio.TabStop = true;
            this.stuffedMushroomsRadio.Text = "Stuffed Mushrooms";
            this.stuffedMushroomsRadio.UseVisualStyleBackColor = true;
            this.stuffedMushroomsRadio.CheckedChanged += new System.EventHandler(this.stuffedMushroomsRadio_CheckedChanged);
            // 
            // lasagnaWithMeatSauceRadio
            // 
            this.lasagnaWithMeatSauceRadio.AutoSize = true;
            this.lasagnaWithMeatSauceRadio.Location = new System.Drawing.Point(7, 21);
            this.lasagnaWithMeatSauceRadio.Name = "lasagnaWithMeatSauceRadio";
            this.lasagnaWithMeatSauceRadio.Size = new System.Drawing.Size(149, 17);
            this.lasagnaWithMeatSauceRadio.TabIndex = 0;
            this.lasagnaWithMeatSauceRadio.TabStop = true;
            this.lasagnaWithMeatSauceRadio.Text = "Lasagna with Meat Sauce";
            this.lasagnaWithMeatSauceRadio.UseVisualStyleBackColor = true;
            this.lasagnaWithMeatSauceRadio.CheckedChanged += new System.EventHandler(this.lasagnaWithMeatSauceRadio_CheckedChanged);
            // 
            // linguiniWithClamSauce
            // 
            this.linguiniWithClamSauce.AutoSize = true;
            this.linguiniWithClamSauce.Location = new System.Drawing.Point(7, 44);
            this.linguiniWithClamSauce.Name = "linguiniWithClamSauce";
            this.linguiniWithClamSauce.Size = new System.Drawing.Size(143, 17);
            this.linguiniWithClamSauce.TabIndex = 1;
            this.linguiniWithClamSauce.TabStop = true;
            this.linguiniWithClamSauce.Text = "Linguini with Clam Sauce";
            this.linguiniWithClamSauce.UseVisualStyleBackColor = true;
            this.linguiniWithClamSauce.CheckedChanged += new System.EventHandler(this.linguiniWithClamSauce_CheckedChanged);
            // 
            // spaghettiWithMarinaraSauceRadio
            // 
            this.spaghettiWithMarinaraSauceRadio.AutoSize = true;
            this.spaghettiWithMarinaraSauceRadio.Location = new System.Drawing.Point(7, 67);
            this.spaghettiWithMarinaraSauceRadio.Name = "spaghettiWithMarinaraSauceRadio";
            this.spaghettiWithMarinaraSauceRadio.Size = new System.Drawing.Size(170, 17);
            this.spaghettiWithMarinaraSauceRadio.TabIndex = 2;
            this.spaghettiWithMarinaraSauceRadio.TabStop = true;
            this.spaghettiWithMarinaraSauceRadio.Text = "Spaghetti with Marinara Sauce";
            this.spaghettiWithMarinaraSauceRadio.UseVisualStyleBackColor = true;
            this.spaghettiWithMarinaraSauceRadio.CheckedChanged += new System.EventHandler(this.spaghettiWithMarinaraSauceRadio_CheckedChanged);
            // 
            // canoliRadio
            // 
            this.canoliRadio.AutoSize = true;
            this.canoliRadio.Location = new System.Drawing.Point(7, 19);
            this.canoliRadio.Name = "canoliRadio";
            this.canoliRadio.Size = new System.Drawing.Size(54, 17);
            this.canoliRadio.TabIndex = 0;
            this.canoliRadio.TabStop = true;
            this.canoliRadio.Text = "Canoli";
            this.canoliRadio.UseVisualStyleBackColor = true;
            this.canoliRadio.CheckedChanged += new System.EventHandler(this.canoliRadio_CheckedChanged);
            // 
            // chocolateTruffleRadio
            // 
            this.chocolateTruffleRadio.AutoSize = true;
            this.chocolateTruffleRadio.Location = new System.Drawing.Point(7, 42);
            this.chocolateTruffleRadio.Name = "chocolateTruffleRadio";
            this.chocolateTruffleRadio.Size = new System.Drawing.Size(106, 17);
            this.chocolateTruffleRadio.TabIndex = 1;
            this.chocolateTruffleRadio.TabStop = true;
            this.chocolateTruffleRadio.Text = "Chocolate Truffle";
            this.chocolateTruffleRadio.UseVisualStyleBackColor = true;
            this.chocolateTruffleRadio.CheckedChanged += new System.EventHandler(this.chocolateTruffleRadio_CheckedChanged);
            // 
            // tiramisuRadio
            // 
            this.tiramisuRadio.AutoSize = true;
            this.tiramisuRadio.Location = new System.Drawing.Point(7, 66);
            this.tiramisuRadio.Name = "tiramisuRadio";
            this.tiramisuRadio.Size = new System.Drawing.Size(64, 17);
            this.tiramisuRadio.TabIndex = 2;
            this.tiramisuRadio.TabStop = true;
            this.tiramisuRadio.Text = "Tiramisu";
            this.tiramisuRadio.UseVisualStyleBackColor = true;
            this.tiramisuRadio.CheckedChanged += new System.EventHandler(this.tiramisuRadio_CheckedChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(152, 387);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(120, 70);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 479);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dessertLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainDishLabel);
            this.Controls.Add(this.appetizersLabel);
            this.Name = "Form1";
            this.Text = "Today\'s Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appetizersLabel;
        private System.Windows.Forms.Label mainDishLabel;
        private System.Windows.Forms.Label dessertLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton stuffedMushroomsRadio;
        private System.Windows.Forms.RadioButton shrimpCocktailRadio;
        private System.Windows.Forms.RadioButton garlicBreadRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton spaghettiWithMarinaraSauceRadio;
        private System.Windows.Forms.RadioButton linguiniWithClamSauce;
        private System.Windows.Forms.RadioButton lasagnaWithMeatSauceRadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton tiramisuRadio;
        private System.Windows.Forms.RadioButton chocolateTruffleRadio;
        private System.Windows.Forms.RadioButton canoliRadio;
        private System.Windows.Forms.Label priceLabel;
    }
}

