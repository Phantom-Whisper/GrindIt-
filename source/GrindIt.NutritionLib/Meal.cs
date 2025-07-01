using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace GrindIt.NutritionLib
{
    /// <summary>
    /// Represents a meal that contains a collection of food entries along with the time the meal occurred.
    /// </summary>
    [Serializable]
    [XmlRoot("Meal")]
    public class Meal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Meal"/> class.
        /// Sets the meal time to the current time with seconds cleared, and initializes the food list.
        /// </summary>
        public Meal()
        {
            FoodList = [];
            MealDateTime = DateTime.Now.AddSeconds(-DateTime.Now.Second);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Meal"/> class with the specified meal type.
        /// </summary>
        /// <param name="type">The type of meal (e.g., breakfast, lunch, etc.).</param>
        public Meal(MealType type) : this()
        {
            Type = type;
        }

        /// <summary>
        /// Gets or sets the type of the meal.
        /// </summary>
        public MealType? Type { get; set; }

        private ObservableCollection<FoodEntry> _foodList;

        /// <summary>
        /// Gets or sets the list of food entries in the meal.
        /// </summary>
        [XmlArray("FoodList")]
        [XmlArrayItem("FoodEntry")]
        public ObservableCollection<FoodEntry> FoodList
        {
            get => _foodList;
            set => _foodList = value ?? [];
        }

        /// <summary>
        /// Gets or sets the date and time when the meal was consumed.
        /// </summary>
        [XmlElement("MealDateTime")]
        public DateTime MealDateTime { get; set; }

        /// <summary>
        /// Calculates the total number of calories in the meal.
        /// </summary>
        /// <returns>Total calories based on portion sizes.</returns>
        public float TotalCalories() => FoodList.Sum(entry => entry.Food!.Calories * entry.PortionSize);

        /// <summary>
        /// Calculates the total carbohydrates in the meal.
        /// </summary>
        public float TotalCarbs() => FoodList.Sum(entry => entry.Food!.Carbohydrate * entry.PortionSize);

        /// <summary>
        /// Calculates the total fat in the meal.
        /// </summary>
        public float TotalFat() => FoodList.Sum(entry => entry.Food!.Fat * entry.PortionSize);

        /// <summary>
        /// Calculates the total protein in the meal.
        /// </summary>
        public float TotalProtein() => FoodList.Sum(entry => entry.Food!.Protein * entry.PortionSize);

        /// <summary>
        /// Calculates the total saturated fat in the meal.
        /// </summary>
        public float TotalSatFat() => FoodList.Sum(entry => entry.Food!.SaturedFat * entry.PortionSize);

        /// <summary>
        /// Calculates the total trans fat in the meal.
        /// </summary>
        public float TotalTransFat() => FoodList.Sum(entry => entry.Food!.TransFat * entry.PortionSize);

        /// <summary>
        /// Calculates the total cholesterol in the meal.
        /// </summary>
        public float TotalCholesterol() => FoodList.Sum(entry => entry.Food!.Cholesterol * entry.PortionSize);

        /// <summary>
        /// Calculates the total sodium in the meal.
        /// </summary>
        public float TotalSodium() => FoodList.Sum(entry => entry.Food!.Sodium * entry.PortionSize);

        /// <summary>
        /// Calculates the total potassium in the meal.
        /// </summary>
        public float TotalPot() => FoodList.Sum(entry => entry.Food!.Potassium * entry.PortionSize);

        /// <summary>
        /// Calculates the total dietary fiber in the meal.
        /// </summary>
        public float TotalDietFiber() => FoodList.Sum(entry => entry.Food!.DietaryFiber * entry.PortionSize);

        /// <summary>
        /// Calculates the total sugar content in the meal.
        /// </summary>
        public float TotalSugar() => FoodList.Sum(entry => entry.Food!.Sugar * entry.PortionSize);

        /// <summary>
        /// Adds a food item to the meal with the specified portion size.
        /// </summary>
        /// <param name="food">The food to add.</param>
        /// <param name="portionSize">The portion size of the food item.</param>
        public void AddFood(Food food, float portionSize)
        {
            FoodList.Add(new FoodEntry(food, portionSize));
        }

        /// <summary>
        /// Removes a food item from the meal by name.
        /// Throws an exception if the item is not found.
        /// </summary>
        /// <param name="food">The food to remove.</param>
        /// <exception cref="InvalidOperationException">Thrown when the specified food is not in the list.</exception>
        public void RemoveFood(Food food)
        {
            var foodEntry = FoodList.FirstOrDefault(entry => entry.Food?.Name == food.Name);
            if (foodEntry != null)
            {
                FoodList.Remove(foodEntry);
            }
            else
            {
                throw new InvalidOperationException("Food is not in the list.");
            }
        }

        //to be deleted
        public void ShowMeal()
        {
            Console.WriteLine("Meal Information");
            foreach (var food in _foodList)
            {
                Console.WriteLine($"{food.Food?.Name} ({food.Food?.ServingSize} portion)");
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Meal Date & Time: {MealDateTime:yyyy-MM-dd HH:mm}");
            Console.WriteLine($"Meal type: {Type}");
            Console.WriteLine($"- Total Calories: {TotalCalories()} kcal");
            Console.WriteLine($"- Total Carbs: {TotalCarbs()} g");
            Console.WriteLine($"- Total Fat: {TotalFat()} g");
            Console.WriteLine($"- Total Protein: {TotalProtein()} g");
            Console.WriteLine($"- Total Saturated Fat: {TotalSatFat()} g");
            Console.WriteLine($"- Total Trans Fat: {TotalTransFat()} g");
            Console.WriteLine($"- Total Cholesterol: {TotalCholesterol()} mg");
            Console.WriteLine($"- Total Sodium: {TotalSodium()} mg");
            Console.WriteLine($"- Total Potassium: {TotalPot()} mg");
            Console.WriteLine($"- Total Dietary Fiber: {TotalDietFiber()} g");
            Console.WriteLine($"- Total Sugar: {TotalSugar()} g");
        }
    }
}