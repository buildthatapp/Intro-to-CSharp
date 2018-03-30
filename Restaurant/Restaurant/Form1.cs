using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
                //appetizer prices
                         private const double GARLIC_BREAD_PRICE = 2.00;
        private const double SHRIMP_COCKTAIL_PRICE = 2.50;
        private const double STUFFED_MUSHROOMS_PRICE = 3.00;

        //main dish prices
        private const double LASAGNA_WITH_MEAT_SAUCE_PRICE = 10.00;
        private const double LINGUINI_WITH_CLAM_SAUCE_PRICE = 12.50;
        private const double SPAGHETTI_WITH_MARINARA_SAUCE_PRICE = 15.00;

        //dessert prices
        private const double CANOLI_PRICE = 3.50;
        private const double CHOCOLATE_TRUFFLE_PRICE = 3.75;
        private const double TIRAMISU_PRICE = 4.00;

        double appetizerPrice = 0;
        double totalFoodPrice = 0;
        double tax = 0;
        double mainDishPrice = 0;
        double dessertPrice = 0;

        private void garlicBreadRadio_CheckedChanged(object sender, EventArgs e)
        {
            appetizerPrice = GARLIC_BREAD_PRICE;
            calculatePrice(appetizerPrice, mainDishPrice, dessertPrice);
        }

        private void shrimpCocktailRadio_CheckedChanged(object sender, EventArgs e)
        {
            appetizerPrice = SHRIMP_COCKTAIL_PRICE;
            calculatePrice(appetizerPrice, mainDishPrice, dessertPrice);
        }

        private void stuffedMushroomsRadio_CheckedChanged(object sender, EventArgs e)
        {
            appetizerPrice = STUFFED_MUSHROOMS_PRICE;
            calculatePrice(appetizerPrice, mainDishPrice, dessertPrice);
        }
 

        private void lasagnaWithMeatSauceRadio_CheckedChanged(object sender, EventArgs e)
        {
            mainDishPrice = LASAGNA_WITH_MEAT_SAUCE_PRICE;
            calculatePrice(appetizerPrice, mainDishPrice, dessertPrice);
        }

        private void linguiniWithClamSauce_CheckedChanged(object sender, EventArgs e)
        {
            mainDishPrice = LINGUINI_WITH_CLAM_SAUCE_PRICE;
            calculatePrice(appetizerPrice, mainDishPrice, dessertPrice);
        }

        private void spaghettiWithMarinaraSauceRadio_CheckedChanged(object sender, EventArgs e)
        {
            mainDishPrice = SPAGHETTI_WITH_MARINARA_SAUCE_PRICE;
            calculatePrice(appetizerPrice, mainDishPrice, dessertPrice);
        }

     

        private void canoliRadio_CheckedChanged(object sender, EventArgs e)
        {
            dessertPrice = CANOLI_PRICE;
            calculatePrice(appetizerPrice, mainDishPrice, dessertPrice);
        }

        private void chocolateTruffleRadio_CheckedChanged(object sender, EventArgs e)
        {
            dessertPrice = CHOCOLATE_TRUFFLE_PRICE;
            calculatePrice(appetizerPrice, mainDishPrice, dessertPrice);
        }

        private void tiramisuRadio_CheckedChanged(object sender, EventArgs e)
        {
            dessertPrice = TIRAMISU_PRICE;
            calculatePrice(appetizerPrice, mainDishPrice, dessertPrice);
        }

        private void calculatePrice(double appPrice, double mainPrice, double dessertPrice)
        {
            totalFoodPrice = appPrice + mainPrice + dessertPrice;
            tax = totalFoodPrice * .0875;
            priceLabel.Text = "Food:    " + totalFoodPrice.ToString("C2") + "\n Tax:     " + tax.ToString("C2") + "\n ---------- \n Total:     " + (totalFoodPrice + tax).ToString("C2");

        }
    }
}

      
    


