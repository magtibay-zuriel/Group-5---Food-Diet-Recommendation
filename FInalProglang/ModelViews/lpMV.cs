using FInalProglang.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace FInalProglang.ModelViews
{
    internal class lpMV
    {
        public string connectionString;
        public List<LOSSPLAN> loss { get; set; } = new List<LOSSPLAN>();

        public lpMV()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public string GetMealsForDay(string day)
        {
            LoadMeals(day);
            var firstMealPlan = loss.FirstOrDefault();
            if (firstMealPlan != null)
            {
                return $"Breakfast: {firstMealPlan.Bfast}\nLunch: {firstMealPlan.Lunch}\nDinner: {firstMealPlan.Dinner}";
            }
            return "No meal plan available for this day.";
        }

        private void LoadMeals(string day)
        {
            loss.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Bfast, Lunch, Dinner FROM LossPlan WHERE Days LIKE @Days";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Days", $"%{day}%");
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LOSSPLAN mealPlan = new LOSSPLAN
                            {
                                Bfast = reader.GetString(0),
                                Lunch = reader.GetString(1),
                                Dinner = reader.GetString(2),
                            };
                            loss.Add(mealPlan);
                        }
                    }
                }
            }
        }
    }
}
