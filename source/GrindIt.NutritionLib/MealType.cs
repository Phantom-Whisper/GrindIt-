namespace GrindIt.NutritionLib
{
    public enum MealType
    {
        BREAKFAST,
        LUNCH,
        DINNER,
        MORNINGSNACK,
        AFTERNOONSNACK,
        EVENINGSNACK
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
