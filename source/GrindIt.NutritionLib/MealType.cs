namespace GrindIt.NutritionLib
{
    public enum MealType
    {
        BREAKFAST = 0,
        LUNCH = 1,
        DINNER = 2,
        MORNINGSNACK = 3,
        AFTERNOONSNACK = 4,
        EVENINGSNACK = 5
    }

    public class MealTypeToString
    {
        public static string ToString(MealType mealType) => ((int)mealType).ToString();
    }
}
