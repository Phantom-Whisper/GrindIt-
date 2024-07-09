using System.Collections.ObjectModel;

namespace GrindIt.NutritionLib
{
    public class Meal
    {
        public Meal(MealType type)
        {
            this.type = type;
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

        public int TotalCalories()
        {
            int sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.Calories;
            }
            return sum;
        }

        public int TotalProtein()
        {
            int sum = 0;
            foreach(Food food in foodList)
            {
                sum += food.Protein;
            }
            return sum;
        }

        public int TotalCarbs()
        {
            int sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.Cabohydrate;
            }
            return sum;
        }

        public int TotalFat()
        {
            int sum = 0;
            foreach(Food food in foodList)
            {
                sum += food.Fat;
            }
            return sum;
        }
        public int TotalSodium()
        {
            int sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.Sodium;
            }
            return sum;
        }

        public int TotalSugar()
        {
            int sum = 0;
            foreach(Food food in foodList)
            {
                sum += food.Sugar;
            }
            return sum;
        }
    }
}
