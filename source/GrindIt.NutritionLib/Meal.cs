using System.Collections.ObjectModel;

namespace GrindIt.NutritionLib
{
    public class Meal
    {
        public Meal(MealType type)
        {
            this.type = type;
            this.foodList = new ObservableCollection<Food>();
        }

        private readonly MealType? type;

        public MealType? Type
        {
            get
            {
                return type;
            }
        }

        private readonly ObservableCollection<Food> foodList;

        public float TotalCalories()
        {
            float sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.Calories;
            }
            return sum;
        }

        public float TotalCarbs()
        {
            float sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.Cabohydrate;
            }
            return sum;
        }

        public float TotalFat()
        {
            float sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.Fat;
            }
            return sum;
        }

        public float TotalProtein()
        {
            float sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.Protein;
            }
            return sum;
        }

        public float TotalSatFat()
        {
            float sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.SaturedFat;
            }
            return sum;
        }

        public float TotalTransFat()
        {
            float sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.TransFat;
            }
            return sum;
        }

        public float TotalChol()
        {
            float sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.Cholesterol;
            }
            return sum;
        }

        public float TotalSodium()
        {
            float sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.Sodium;
            }
            return sum;
        }

        public float TotalPot()
        {
            float sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.Potassium;
            }
            return sum;
        }

        public float TotalDietFiber()
        {
            float sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.DietaryFiber;
            }
            return sum;
        }

        public float TotalSugar()
        {
            float sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.Sugar;
            }
            return sum;
        }

        public void AddFood(Food food)
        {
            foodList.Add(food);
        }

        public void ShowMeal()
        {
            Console.WriteLine("Meal Information");
            Console.WriteLine($"Meal type: {type}");
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
