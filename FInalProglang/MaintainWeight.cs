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
    public partial class MaintainWeight : Form
    {
        private mpMV mpMVobj;
        public float BmiValue { get; set; }
        
        public MaintainWeight(float bmiValue)
        {
            InitializeComponent();
            BmiValue = bmiValue;
            mpMVobj = new mpMV();
            LoadData();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            FoodMenu f1 = new FoodMenu(BmiValue);
            f1.Show();
            this.Hide();
        }
        private void LoadData()
        {
            string mondayMeals = mpMVobj.GetMealsForDay("Monday");
            MondayMaintain.Text = mondayMeals;

            string tuesdayMeals = mpMVobj.GetMealsForDay("Tuesday");
            TuesdayMaintain.Text = tuesdayMeals;

            string wednesdayMeals = mpMVobj.GetMealsForDay("Wednesday");
            WednesdayMaintain.Text = wednesdayMeals;

            string thursdayMeals = mpMVobj.GetMealsForDay("Thursday");
            ThursdayMaintain.Text = thursdayMeals;

            string fridayMeals = mpMVobj.GetMealsForDay("Friday");
            FridayMaintain.Text = fridayMeals;

            string saturdayMeals = mpMVobj.GetMealsForDay("Saturday");
            SaturdayMaintain.Text = saturdayMeals;

            string sundayMeals = mpMVobj.GetMealsForDay("Sunday");
            SundayMaintain.Text = sundayMeals;

        }
        protected virtual void SetBackground()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void MaintainWeight_Load(object sender, EventArgs e)
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
