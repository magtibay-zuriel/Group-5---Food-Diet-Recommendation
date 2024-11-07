using FInalProglang.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;


namespace FInalProglang.ModelViews
{
    internal class gpMV
    {
        public string connectionString;
        public List<GAINPLAN> gain { get; set; } = new List<GAINPLAN>();

        public gpMV()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public string GetMealsForDay(string day)
        {
            LoadGainPlan(day);
            var meals = gain.FirstOrDefault();
            if (meals != null)
            {
                return $"Breakfast: {meals.Bfast}\nLunch: {meals.Lunch}\nDinner: {meals.Dinner}\nDessert: {meals.Dessert}\nSnacks: {meals.Snacks}";
            }
            return "No meal plan available for this day.";
        }

        private void LoadGainPlan(string day)
        {
            gain.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Bfast, Lunch, Dinner, Dessert, Snacks FROM GainPlan WHERE Days LIKE @Days";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Days", $"%{day}%");
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GAINPLAN gp = new GAINPLAN
                            {
                                Bfast = reader.GetString(0),
                                Lunch = reader.GetString(1),
                                Dinner = reader.GetString(2),
                                Dessert = reader.GetString(3),
                                Snacks = reader.GetString(4)
                            };
                            gain.Add(gp);
                        }
                    }
                }
            }
        }
    }
}
