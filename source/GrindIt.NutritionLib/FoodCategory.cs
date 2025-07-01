namespace GrindIt.NutritionLib
{
    /// <summary>
    /// Enumerates the various categories of food.
    /// </summary>
    public enum FoodCategory
    {
        Cereals,
        Fruits,
        Vegetables,
        Dairy,
        Meats,
        Fish,
        Fats,
        Sugars,
        Drinks
    }

    /// <summary>
    /// Provides utility methods for converting and handling <see cref="FoodCategory"/> values.
    /// </summary>
    public static class FoodCategoryHelper
    {
        /// <summary>
        /// Converts a <see cref="FoodCategory"/> enum value to its integer string representation.
        /// </summary>
        /// <param name="category">The food category to convert.</param>
        /// <returns>A string representation of the integer value of the category.</returns>
        public static string ConvertToString(FoodCategory category) => ((int)category).ToString();

        /// <summary>
        /// Attempts to convert an integer value to a corresponding <see cref="FoodCategory"/> enum value.
        /// Returns <c>null</c> if the value is not defined in the enum.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>A <see cref="FoodCategory"/> value if defined; otherwise, <c>null</c>.</returns>
        public static FoodCategory? FromInt(int value) =>
            Enum.IsDefined(typeof(FoodCategory), value) ? (FoodCategory)value : null;

        /// <summary>
        /// Converts an integer to a <see cref="FoodCategory"/> value.
        /// If the value is not defined, returns the specified default category.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <param name="defaultCategory">The default category to return if the value is invalid.</param>
        /// <returns>A valid <see cref="FoodCategory"/> value.</returns>
        public static FoodCategory FromIntOrDefault(int value, FoodCategory defaultCategory = FoodCategory.Cereals) =>
            Enum.IsDefined(typeof(FoodCategory), value) ? (FoodCategory)value : defaultCategory;

        /// <summary>
        /// Converts an integer to a <see cref="FoodCategory"/> value or throws an exception if invalid.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The corresponding <see cref="FoodCategory"/> value.</returns>
        /// <exception cref="ArgumentException">Thrown if the provided integer does not map to a valid <see cref="FoodCategory"/>.</exception>
        public static FoodCategory FromIntOrThrow(int value) =>
            Enum.IsDefined(typeof(FoodCategory), value) ? (FoodCategory)value
            : throw new ArgumentException($"Invalid FoodCategory value: {value}");
    }
}