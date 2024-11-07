DROP TABLE IF EXISTS GainPlan;

-- Create the MealPlan table with the necessary columns and primary key
CREATE TABLE GainPlan(
    Days VARCHAR(10),
    Category VARCHAR(10),
    Bfast TEXT,
    Lunch TEXT,
    Dinner TEXT,
    Dessert TEXT,
    Snacks TEXT,
    PRIMARY KEY (Days, Category)
);

INSERT INTO GainPlan (Days, Category, Bfast, Lunch, Snacks, Dinner, Dessert) VALUES
('Monday', 'gain', 'Peanut Butter on Wholegrain Toast: Toasted wholegrain bread + 2 tbsp peanut butter. Drizzle with honey to taste. Serve with 1 hot chocolate, made with milk + 1 serve of fruit (e.g., 1 medium pear or orange).', 'Chicken and Pasta Salad: Cooked chicken + pasta + 1 cup leafy green vegetables (e.g., spinach, rocket) + tomato + avocado + crumbled feta cheese + olive oil/vinegar dressing.', 'A handful of mixed nuts and/or seeds.', 'Lamb Chops and Vegetables: Lamb chop, trimmed & shallow fried in olive oil. Serve with sweet potato mash made with milk and olive oil + 2 cups cooked vegetables.', 'Fresh Fruit and Cheese Platter: Slice and serve a variety of fresh fruits in season and cheese.'),
('Tuesday', 'gain', 'Chia Porridge with Fruit: 2 tbsp chia seeds + rolled oats + 1.5 cups full cream milk + 1 serve of fruit (e.g., 1 medium banana or 6 dried prunes).', 'Egg, Cheese and Salad Wrap: 2 boiled & mashed eggs + 2 cheese slices + avocado + 1 cup salad vegetables (e.g., lettuce, cucumber, carrot) wrapped in tortilla bread.', 'A serve of yogurt with honey or fruit.', 'Steak and Potatoes: 200g steak + 1 large potato (baked) + 2 cups mixed vegetables.', 'Peanut Butter Chocolate Chip Cookie or Muffin: 1 serve, with a glass of milk.'),
('Wednesday', 'gain', 'Fruit Smoothie: 2 bananas + 1.5 cups full cream milk + 1 tbsp honey + ice + optional chia seeds or nut butter.', 'Ham, Cheese and Salad Sandwich: 2 slices of wholegrain bread + butter + sliced ham + cheese + salad vegetables + a sprinkle of salt/pepper + a handful of mixed nuts.', 'Chocolate (1-2 squares), or fruit toast.', 'Beef Stir-fry: 200g beef + a variety of vegetables + 1 cup cooked rice + soy sauce.', 'Vanilla Yogurt with Honey and Berries: 1 cup plain yogurt + a drizzle of honey + fresh or frozen berries.'),
('Thursday', 'gain', 'Egg and Avocado on Toast: 2 slices of wholegrain toast with smashed avocado + 2 poached eggs on top.', 'Creamy Chicken Wrap: 100g cooked chicken + cheese + avocado + 1 cup salad vegetables (e.g., lettuce, tomato) wrapped in tortilla bread.', 'Fruit Muffin + 1 cup fruit salad.', 'Pasta with Meat Sauce: 1.5 cups cooked pasta + 1 cup bolognaise sauce (made with ground beef) + sprinkle with cheese.', 'Chocolate Mousse: 1 serve (homemade or store-bought).'),
('Friday', 'gain', 'Omelette with Cheese and Spinach: 3 eggs + 1/2 cup spinach + 2 cheese slices + a slice of wholegrain toast.', 'Tuna and Rice Salad: 1 can tuna + cooked rice + mixed salad vegetables + 1 tbsp mayonnaise.', 'Fruit Yogurt + a handful of nuts/seeds.', 'Chicken & Vegetable Bake: 200g chicken + potato + sweet potato + seasonal vegetables + cheese topping.', 'Ice cream sundae: 1 scoop ice cream + fruit sauce.'),
('Saturday', 'gain', 'Pancakes with Maple Syrup: 2 pancakes + 2 tbsp maple syrup + 2 rashers bacon (optional) + 1 glass of milk.', 'Sushi with Avocado and Vegetables: 1 large sushi roll + 1 cup salad vegetables.', 'Muffin or cookies + 1 cup yogurt.', 'Lentil Soup with Bread: 1 bowl soup + 1 roll of bread.', 'Cake: 1 slice of cake + cream.'),
('Sunday', 'gain', 'Full English Breakfast: 2 eggs, 2 sausages, 2 rashers bacon + toast + baked beans + grilled tomatoes + mushrooms + coffee or tea.', 'Vegetable Quiche with Salad: 1 slice + mixed salad vegetables with dressing.', 'Fruit Snack: e.g., chocolate bar, fruit yogurt or muesli bar.', 'Roast Dinner: 1 serving of roast beef/lamb/chicken + potatoes + vegetables + gravy.', 'Chocolate pudding with cream.');

-- Query to display the meal plan in the correct order from Monday to Sunday
SELECT * FROM GainPlan
ORDER BY CASE 
    WHEN Days = 'Monday' THEN 1
    WHEN Days = 'Tuesday' THEN 2
    WHEN Days = 'Wednesday' THEN 3
    WHEN Days = 'Thursday' THEN 4
    WHEN Days = 'Friday' THEN 5
    WHEN Days = 'Saturday' THEN 6
    WHEN Days = 'Sunday' THEN 7
END;
