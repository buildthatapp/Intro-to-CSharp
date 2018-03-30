using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandlingDemoGUI
{
    public partial class ExceptionHandlingDemoGUI : Form
    {
        
        public ExceptionHandlingDemoGUI()
        {
            InitializeComponent();
            messagerToUserLabel.Visible = false;
        }



        private void okButton_Click(object sender, EventArgs e)
        {



            int enterAnIntegerInt = 0;

            try
            {
                enterAnIntegerInt = Convert.ToInt32(enterAnIntegerTextBox.Text);
            }

            catch (Exception)
            {
                messagerToUserLabel.Visible = true;
                messagerToUserLabel.Text = "Input string was not in the correct format.";
            }

            if (int.TryParse(enterAnIntegerTextBox.Text, out enterAnIntegerInt))
            {
                messagerToUserLabel.Visible = true;

                messagerToUserLabel.Text = "Successfully entered a " + enterAnIntegerInt + "";
            }




            
        }
    }
}
