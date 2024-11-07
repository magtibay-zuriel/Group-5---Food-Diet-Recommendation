DROP TABLE IF EXISTS MaintainPlan;

-- Create the MealPlan table with the necessary columns and primary key
CREATE TABLE MaintainPlan(
    Days VARCHAR(10),
    Category VARCHAR(10),
    Bfast TEXT,
    Midmeal TEXT,
    Lunch TEXT,
    Snacks TEXT,
    Dinner TEXT,
    PRIMARY KEY (Days, Category)
);

INSERT INTO MaintainPlan (Days, Category, Bfast, Midmeal, Lunch, Snacks, Dinner) VALUES
('Monday', 'maintain', '3 aloo paratha + 1 cup curd + 6 almonds', 'Pomegranate (1 cup) + 1 Guava + 1 cup cottage cheese', 'Parboiled Rice (1 cup) or 3 Chapatis + Veg. curry (1 cup) + Daal (1 cup) + 1/4th fresh lemon + salad', 'Green Tea (1 cup) with 1 tsp honey + 1 cup soybean chaap', '2 Chapatti + Chicken stew (1 cup)'),
('Tuesday', 'maintain', 'Soy Milk 1 cup + 1 cup Cornflakes + Ripe Banana (2)', '1 Orange + Grapes (1 cup) + 1 cup cottage cheese', 'Parboiled Rice (1 cup) or 3 Chapatis + Veg. curry (1/2 cup) + Daal (1/2 cup) + 1/4th fresh lemon + salad', 'Green Tea (1 cup) with 1 tsp honey + 4 Almonds + 5-6 Raisins', '2 Chapatti + Veg. Curry (1 cup)'),
('Wednesday', 'maintain', 'Veg. Sandwich (2) + Orange juice (1 cup) + 2 boiled eggs', 'Pomegranate (1 cup) + 1 Guava + 1 cup cottage cheese', 'Parboiled Rice (1 cup) or 3 Chapatis + Veg. curry (1 cup) + Daal (1 cup) + 1/4th fresh lemon + salad', 'Green Tea (1 cup) with 1 tsp honey + 4 Almonds + 5-6 Raisins', '2 Chapatti + Chicken stew (1 cup)'),
('Thursday', 'maintain', '2 paneer paratha + 1 cup curd + 6 almonds', '1 Orange + Grapes (1 cup) + 1 cup cottage cheese', 'Parboiled Rice (1 cup) or 3 Chapatis + Veg. curry (1 cup) + Daal (1 cup) + 1/4th fresh lemon + salad', 'Green Tea (1 cup) with 1 tsp honey + 4 Almonds + 5-6 Raisins', '2 Chapatti + Veg. Curry (1 cup)'),
('Friday', 'maintain', 'Soy Milk 1 cup + 1 cup Cornflakes + Ripe Banana (2)', 'Pomegranate (1 cup) + 1 Guava + 1 cup cottage cheese', 'Parboiled Rice (1 cup) or 3 Chapatis + Veg. curry (1 cup) + Daal (1 cup) + 1/4th fresh lemon + salad', 'Green Tea (1 cup) with 1 tsp honey + 4 Almonds + 5-6 Raisins', '2 Chapatti + Chicken stew (1 cup)'),
('Saturday', 'maintain', 'Veg. Sandwich (2) + Orange juice (1 cup) + 2 boiled eggs', '1 Orange + Grapes (1 cup) + 1 cup cottage cheese', 'Parboiled Rice (1 cup) or 3 Chapatis + Veg. curry (1 cup) + Daal (1 cup) + 1/4th fresh lemon + salad', 'Green Tea (1 cup) with 1 tsp honey + 4 Almonds + 5-6 Raisins', '2 Chapatti + Chicken stew (1 cup)'),
('Sunday', 'maintain', '2 dal paratha + 1 cup curd + 6 almonds', 'Pomegranate (1 cup) + 1 Guava + 1 cup cottage cheese', 'Parboiled Rice (1 cup) or 3 Chapatis + Veg. curry (1 cup) + Daal (1 cup) + 1/4th fresh lemon + salad', 'Green Tea (1 cup) with 1 tsp honey + 4 Almonds + 5-6 Raisins', '2 Chapatti + Chicken stew (1 cup)');

SELECT * FROM MaintainPlan
ORDER BY CASE 
    WHEN Days = 'Monday' THEN 1
    WHEN Days = 'Tuesday' THEN 2
    WHEN Days = 'Wednesday' THEN 3
    WHEN Days = 'Thursday' THEN 4
    WHEN Days = 'Friday' THEN 5
    WHEN Days = 'Saturday' THEN 6
    WHEN Days = 'Sunday' THEN 7
END;
