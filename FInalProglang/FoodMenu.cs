using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProglang
{
    public partial class FoodMenu : BG
    {
        private float bmiValue;
        public FoodMenu(float bmiValue)
        {
            InitializeComponent();
            this.bmiValue = bmiValue;
        }

        private void FoodMenu_Load(object sender, EventArgs e)
        {
            bmiResult.Text = bmiValue.ToString("F2"); ;
            string category = new BmiCalculator().CategoryBMI(bmiValue);
            categoryResult.Text = category;
            if (category == "Underweight")
            {
                LossWeightBtn.Visible = false;
                MaintainWeightBtn.Visible = false;
            }
            if (category == "Overweight")
            {
                GainWeightBtn.Visible = false;
                MaintainWeightBtn.Visible = false;
            }
            if (category == "Obesity")
            {
                GainWeightBtn.Visible = false;
                MaintainWeightBtn.Visible = false;
            }
        }

        private void LossWeightBtn_Click(object sender, EventArgs e)
        {
            LossWeight l1 = new LossWeight(bmiValue);
            l1.Show();
            this.Hide();
        }

        private void MaintainWeightBtn_Click(object sender, EventArgs e)
        {
            MaintainWeight m1 = new MaintainWeight(bmiValue);
            m1.Show();
            this.Hide();
        }

        private void GainWeightBtn_Click(object sender, EventArgs e)
        {
            GainWeight g1 = new GainWeight(bmiValue);
            g1.Show();
            this.Hide();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            BmiCalculator m1 = new BmiCalculator();
            this.Hide();
            m1.Show();
        }
    }
}
