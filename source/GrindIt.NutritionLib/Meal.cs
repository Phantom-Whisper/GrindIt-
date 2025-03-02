using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Serialization;

namespace GrindIt.NutritionLib
{
    [Serializable]
    [XmlRoot("Meal")]
    public class Meal
    {
        public Meal()
        {
            FoodList = new ObservableCollection<FoodEntry>();
            MealDateTime = DateTime.Now.AddSeconds(-DateTime.Now.Second);
        }

        public Meal(MealType type) : this()
        {
            Type = type;
        }

        public MealType? Type { get; set; }

        private ObservableCollection<FoodEntry> foodList;

        [XmlArray("FoodList")]
        [XmlArrayItem("FoodEntry")]
        public ObservableCollection<FoodEntry> FoodList
        {
            get => foodList ??= new ObservableCollection<FoodEntry>();
            set => foodList = value ?? new ObservableCollection<FoodEntry>();
        }

        [XmlElement("MealDateTime")]
        public DateTime MealDateTime { get; set; }

        public float TotalCalories() => FoodList.Sum(entry => entry.Food.Calories * entry.PortionSize);
        public float TotalCarbs() => FoodList.Sum(entry => entry.Food.Carbohydrate * entry.PortionSize);
        public float TotalFat() => FoodList.Sum(entry => entry.Food.Fat * entry.PortionSize);
        public float TotalProtein() => FoodList.Sum(entry => entry.Food.Protein * entry.PortionSize);
        public float TotalSatFat() => FoodList.Sum(entry => entry.Food.SaturedFat * entry.PortionSize);
        public float TotalTransFat() => FoodList.Sum(entry => entry.Food.TransFat * entry.PortionSize);
        public float TotalChol() => FoodList.Sum(entry => entry.Food.Cholesterol * entry.PortionSize);
        public float TotalSodium() => FoodList.Sum(entry => entry.Food.Sodium * entry.PortionSize);
        public float TotalPot() => FoodList.Sum(entry => entry.Food.Potassium * entry.PortionSize);
        public float TotalDietFiber() => FoodList.Sum(entry => entry.Food.DietaryFiber * entry.PortionSize);
        public float TotalSugar() => FoodList.Sum(entry => entry.Food.Sugar * entry.PortionSize);

        public void AddFood(Food food, float portionSize)
        {
            FoodList.Add(new FoodEntry(food, portionSize));
        }

        public void RemoveFood(Food food)
        {
            var foodEntry = FoodList.FirstOrDefault(entry => entry.Food.Name == food.Name);
            if (foodEntry != null)
            {
                FoodList.Remove(foodEntry);
            }
            else
            {
                throw new InvalidOperationException("Food is not in the list.");
            }
        }

        public void ShowMeal()
        {
            Console.WriteLine("Meal Information");
            foreach (var food in foodList)
            {
                Console.WriteLine($"{food.Food.Name} ({food.Food.ServingSize} portion)"); 
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
            Console.WriteLine($"- Total Cholesterol: {TotalChol()} mg");
            Console.WriteLine($"- Total Sodium: {TotalSodium()} mg");
            Console.WriteLine($"- Total Potassium: {TotalPot()} mg");
            Console.WriteLine($"- Total Dietary Fiber: {TotalDietFiber()} g");
            Console.WriteLine($"- Total Sugar: {TotalSugar()} g");
        }
    }
}