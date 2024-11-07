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
    public partial class GainWeight : Form
    {
        private gpMV gpMVobj;
        public float BmiValue { get; set; }
        public GainWeight(float bmiValue)
        {
            InitializeComponent();
            BmiValue = bmiValue;
            gpMVobj = new gpMV();
            LoadData();
        }
        private void LoadData()
        {
            string mondayMeals = gpMVobj.GetMealsForDay("Monday");
            MondayGain.Text = mondayMeals;

            string tuesdayMeals = gpMVobj.GetMealsForDay("Tuesday");
            TuesdayGain.Text = tuesdayMeals;

            string wednesdayMeals = gpMVobj.GetMealsForDay("Wednesday");
            WednesdayGain.Text = wednesdayMeals;

            string thursdayMeals = gpMVobj.GetMealsForDay("Thursday");
            ThursdayGain.Text = thursdayMeals;

            string fridayMeals = gpMVobj.GetMealsForDay("Friday");
            FridayGain.Text = fridayMeals;

            string saturdayMeals = gpMVobj.GetMealsForDay("Saturday");
            SaturdayGain.Text = saturdayMeals;

            string sundayMeals = gpMVobj.GetMealsForDay("Sunday");
            SundayGain.Text = sundayMeals;

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
        private void GainWeight_Load(object sender, EventArgs e)
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
