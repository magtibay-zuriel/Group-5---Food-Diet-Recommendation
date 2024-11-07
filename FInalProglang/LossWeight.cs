using FInalProglang.ModelViews;
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
    public partial class LossWeight : Form
    {
        private lpMV lpMVobj;
        public float BmiValue { get; set; }
        public LossWeight(float bmiValue)
        {
            InitializeComponent();
            BmiValue = bmiValue;
            lpMVobj = new lpMV();
            LoadData();
        }
        private void LoadData()
        {
            string mondayMeals = lpMVobj.GetMealsForDay("Monday");
            MondayLoss.Text = mondayMeals;

            string tuesdayMeals = lpMVobj.GetMealsForDay("Tuesday");
            TuesdayLoss.Text = tuesdayMeals;

            string wednesdayMeals = lpMVobj.GetMealsForDay("Wednesday");
            WednesdayLoss.Text = wednesdayMeals;

            string thursdayMeals = lpMVobj.GetMealsForDay("Thursday");
            ThursdayLoss.Text = thursdayMeals;

            string fridayMeals = lpMVobj.GetMealsForDay("Friday");
            FridayLoss.Text = fridayMeals;

            string saturdayMeals = lpMVobj.GetMealsForDay("Saturday");
            SaturdayLoss.Text = saturdayMeals;

            string sundayMeals = lpMVobj.GetMealsForDay("Sunday");
            SundayLoss.Text = sundayMeals;

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            FoodMenu f1 = new FoodMenu(BmiValue);
            f1.Show();
            this.Hide();
        }
        protected virtual void SetBackground()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void LossWeight_Load(object sender, EventArgs e)
        {
            SetBackground();


            string imagePath = @"C:\Users\Admin\Documents\OOP PROJECT\FoodDietRecommendation\FoodDietRecommendation\FD.jpg";
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(imagePath);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;


            panel1.Controls.Add(pictureBox);
        }
    }
}
