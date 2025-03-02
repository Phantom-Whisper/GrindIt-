namespace GrindIt.NutritionLib
{
    public enum FoodCategory
    {
        CEREALS,
        FRUITS,
        VEGETABLES,
        DAIRY,
        MEATS,
        FISH,
        FATS,
        SUGARS,
        DRINKS
    }

    public static class FoodCategoryHelper
    {
        public static string ConvertToString(FoodCategory category) => ((int)category).ToString();

        public static FoodCategory? FromInt(int value) =>
            Enum.IsDefined(typeof(FoodCategory), value) ? (FoodCategory)value : null;

        public static FoodCategory FromIntOrDefault(int value, FoodCategory defaultCategory = FoodCategory.CEREALS) =>
            Enum.IsDefined(typeof(FoodCategory), value) ? (FoodCategory)value : defaultCategory;

        public static FoodCategory FromIntOrThrow(int value) =>
            Enum.IsDefined(typeof(FoodCategory), value) ? (FoodCategory)value
            : throw new ArgumentException($"Invalid FoodCategory value: {value}");
    }
}
