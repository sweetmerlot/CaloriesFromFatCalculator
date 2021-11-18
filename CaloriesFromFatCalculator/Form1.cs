using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriesFromFatCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            int fat = 0;
            int carb = 0;
            inputIsValid(ref fat, ref carb);
            calFromFatOutput.Text = CalsFromFat(fat).ToString();
            calFromCarbOutput.Text = CalsFromCarbs(carb).ToString();

        }

        //method checks whether user input is good
        private bool inputIsValid(ref int fat, ref int carb)
        {
            //currently the boolean is set to false
            bool inputValid = false;

            //if input can be parsed, the boolean is set to true
            //Otherwise it remains false and user receives error message.
            if (int.TryParse(fatGramsInput.Text, out fat))
            {
                if (int.TryParse(carbGramsInput.Text, out carb))
                {
                    inputValid = true;
                    
                }
                else
                {
                    MessageBox.Show("Enter a whole number for grams of carbs");
                }
            }
            else
            {
                MessageBox.Show("Enter an whole number for grams of fat");
               
            }
            return inputValid;
        }
        
        //method to calculate calories from fat
        private int CalsFromFat(int fatGrams)
        {
            return fatGrams * 9;
        }
        //method to calculate calories from carbs
        private int CalsFromCarbs(int carbGrams)
        {
            return carbGrams * 4;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fatGramsInput.Text = "";
            carbGramsInput.Text = "";
            calFromCarbOutput.Text = "";
            calFromFatOutput.Text = "";
        }
    }
}
