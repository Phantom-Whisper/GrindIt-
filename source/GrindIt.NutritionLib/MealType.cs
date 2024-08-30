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
    public static class IntToCategory
    {
        public static MealType? FromInt(int value)
        {
            if (Enum.IsDefined(typeof(MealType), value))
            {
                return (MealType)value;
            }
            else { return null; }
        }
    }
}
