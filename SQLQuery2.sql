DROP TABLE IF EXISTS LossPlan;

-- Create the MealPlan table with the necessary columns and primary key
CREATE TABLE LossPlan(
    Days VARCHAR(10),
    Category VARCHAR(10),
    Bfast TEXT,
    Lunch TEXT,
    Dinner TEXT,
    PRIMARY KEY (Days, Category)
);

INSERT INTO LossPlan (Days, Category, Bfast, Lunch, Dinner) VALUES
('Monday', 'loss', '2 eggs with 1 tablespoon cooking oil + 1 slice toast, 1 orange + 4 oz whole-fat cottage cheese', 
 '5 ounces baked cod + 1 tablespoon olive oil + 3/4 cup quinoa + 1 cup roasted broccoli', 
 '5 ounces baked cod, 1 tablespoon olive oil, 3/4 cup quinoa, 1 cup roasted broccoli'),
('Tuesday', 'loss', '1 cup full-fat plain yogurt + 1 cup raspberries + 1/2 ounce walnuts', 
 '2 ounces fresh mozzarella + 1 cup sweet red pepper + 1/2 cup cucumber slices', 
 '1 medium sweet potato, 1 teaspoon butter, 4 ounces wild-caught salmon, 2 cups roasted Brussels sprouts'),
('Wednesday', 'loss', '1/2 cup raw oats cooked in 1 cup unsweetened almond milk + 1/4 cup blueberries + 1/2 banana', 
 '1 small whole-grain wrap + 2 tablespoons hummus + 1/4 cup cucumber + 1 ounce turkey breast', 
 '3 ounces ground turkey, 1/2 cup black beans, 1/2 cup kidney beans, 1 cup crushed tomatoes'),
('Thursday', 'loss', '2 fried eggs + 1 slice Ezekiel toast + 2 tablespoons avocado', 
 '1 cucumber and avocado sushi roll with 1 tablespoon soy sauce + 1 cup mixed greens', 
 '1 cup black beans, 1 egg, chopped onion, chopped garlic, 1 tablespoon breadcrumbs, 2 cups mixed greens, 1 ounce feta cheese'),
('Friday', 'loss', '1 scoop pea protein powder + 1 cup frozen blueberries + 1 tablespoon almond butter', 
 '2 cups kale, 4 ounces grilled chicken + 1/2 avocado', 
 '4 ounces grilled shrimp, 2 cups onions and peppers sautéed in olive oil, 2 small corn tortillas, 1 tablespoon full-fat sour cream, 1 ounce shredded cheese'),
('Saturday', 'loss', '1/2 cup raw oats cooked in 1 cup unsweetened almond milk + 1/4 cup raspberries + 1 tablespoon chia seeds', 
 '5 ounces canned tuna + 1 tablespoon mayonnaise + 2 cups romaine lettuce', 
 '5 ounces baked chicken, 1 cup roasted butternut squash cooked in olive oil, 1 cup roasted broccoli'),
('Sunday', 'loss', '2 eggs + 1 ounce cheddar cheese + 1 cup spinach + 1/2 cup blueberries', 
 '1 Chipotle burrito bowl with romaine lettuce + black beans + tomatoes + chicken breast + and guacamole', 
 '1 cup brown-rice or whole-wheat pasta, 1 tablespoon pesto, 1/2 cup cannellini beans, 1 cup spinach, 1 cup cherry tomatoes, 1 tablespoon grated parmesan cheese');

SELECT * FROM LossPlan
ORDER BY CASE 
    WHEN Days = 'Monday' THEN 1
    WHEN Days = 'Tuesday' THEN 2
    WHEN Days = 'Wednesday' THEN 3
    WHEN Days = 'Thursday' THEN 4
    WHEN Days = 'Friday' THEN 5
    WHEN Days = 'Saturday' THEN 6
    WHEN Days = 'Sunday' THEN 7
END;
