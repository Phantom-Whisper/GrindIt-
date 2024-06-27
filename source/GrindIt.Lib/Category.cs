namespace GrindIt.NutritionLib
{
    public enum Category
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
        public static string ToString(Category category) => ((int)category).ToString();
    }
}
