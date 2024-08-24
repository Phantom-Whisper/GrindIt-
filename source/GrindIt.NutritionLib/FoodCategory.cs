namespace GrindIt.NutritionLib
{
    public enum FoodCategory
    {
        CEREALS = 0,
        FRUITS = 1,
        VEGETABLES = 2,
        DAIRY = 3,
        MEATS = 4,
        FISH = 5,
        FATS = 6,
        SUGARS = 7,
        DRINKS = 8
    }

    public static class CategoryToString
    {
        public static string ToString(FoodCategory category) => ((int)category).ToString();
    }

    public static class StringToCategory
    {
        public static FoodCategory? FromInt(int value)
        {
            if (Enum.IsDefined(typeof(FoodCategory), value))
            {
                return (FoodCategory)value;
            }
            else
            {
                return null;
            }
        }
    }
}
