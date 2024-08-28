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

        public float TotalCalories()
        {
            float sum = 0;
            foreach (Food food in foodList)
            {
                sum += food.Calories;
            }
            return sum;
        }

        public float TotalProtein()
        {
            float sum = 0;
            foreach(Food food in foodList)
            {
                sum += food.Protein;
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
            foreach(Food food in foodList)
            {
                sum += food.Fat;
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

        public float TotalSugar()
        {
            float sum = 0;
            foreach(Food food in foodList)
            {
                sum += food.Sugar;
            }
            return sum;
        }
    }
}
