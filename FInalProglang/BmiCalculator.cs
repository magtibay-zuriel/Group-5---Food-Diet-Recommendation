using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FInalProglang
{
    public partial class BmiCalculator : BG
    {
        public BmiCalculator()
        {
            InitializeComponent();
        }

        private void TextBoxHeight_TextChanged(object sender, EventArgs e)
        {
            TextBoxHeight.Focus();
            if (string.IsNullOrWhiteSpace(TextBoxHeight.Text))
            {
                return;
            }
            float height;
            if (float.TryParse(TextBoxHeight.Text, out height))
            {

            }
            else
            {
                MessageBox.Show("Please enter a valid number for height.");
            }
        }

        private void TextBoxWeight_TextChanged(object sender, EventArgs e)
        {
            TextBoxWeight.Focus();
            if (string.IsNullOrWhiteSpace(TextBoxWeight.Text))
            {
                return;
            }
            float weight;
            if (float.TryParse(TextBoxWeight.Text, out weight))
            {

            }
            else
            {
                MessageBox.Show("Please enter a valid number for weight.");
            }
        }
        public float bmi()
        {
            float height, weight;
            if (float.TryParse(TextBoxHeight.Text, out height) && float.TryParse(TextBoxWeight.Text, out weight))
            {
                height = height / 100;

                float BMI = weight / (height * height);
                return BMI;
            }
            return 0;

        }
        public string CategoryBMI(float bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxHeight.Text.Trim()))
            {
                errorProvider1.SetError(TextBoxHeight, "Please input your Height");
                return;
            }
            else
            {
                errorProvider1.SetError(TextBoxHeight, string.Empty);
            }
            if (string.IsNullOrEmpty(TextBoxWeight.Text.Trim()))
            {
                errorProvider2.SetError(TextBoxWeight, "Please input your Weight");
                return;
            }
            else
            {
                errorProvider2.SetError(TextBoxWeight, string.Empty);
            }
            float bmiValue = bmi();
            FoodMenu m1 = new FoodMenu(bmiValue);
            m1.Show();
            this.Hide();
        }
    }
}
