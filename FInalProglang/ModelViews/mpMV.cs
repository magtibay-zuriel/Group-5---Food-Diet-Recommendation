using FInalProglang.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace FInalProglang.ModelViews
{
    internal class mpMV
    {
        private string connectionString;
        private List<MAINTAINPLAN> maintainMeals = new List<MAINTAINPLAN>();

        public mpMV()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public string GetMealsForDay(string day)
        {
            LoadMeals(day);
            var meal = maintainMeals.FirstOrDefault();

            return meal != null ?
                $"Breakfast: {meal.Bfast}\nMidmeal: {meal.Midmeal}\nLunch: {meal.Lunch}\nSnacks: {meal.Snacks}\nDinner: {meal.Dinner}"
                : "No meals available for this day.";
        }

        private void LoadMeals(string day)
        {
            maintainMeals.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Bfast, Midmeal, Lunch, Snacks, Dinner FROM MaintainPlan WHERE Days LIKE @Days";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Days", $"%{day}%");
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MAINTAINPLAN meal = new MAINTAINPLAN
                            {
                                Bfast = reader.GetString(0),
                                Midmeal = reader.GetString(1),
                                Lunch = reader.GetString(2),
                                Snacks = reader.GetString(3),
                                Dinner = reader.GetString(4)
                            };
                            maintainMeals.Add(meal);
                        }
                    }
                }
            }
        }
    }
}
