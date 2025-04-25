namespace GrindIt.NutritionLib
{
    /// <summary>
    /// Represents the various types of meals throughout the day.
    /// </summary>
    public enum MealType
    {
        BREAKFAST,
        LUNCH,
        DINNER,
        MORNINGSNACK,
        AFTERNOONSNACK,
        EVENINGSNACK
    }

    /// <summary>
    /// Provides conversion from <see cref="MealType"/> to string representations.
    /// </summary>
    public class MealTypeToString
    {
        /// <summary>
        /// Converts a <see cref="MealType"/> value to its corresponding numeric string representation.
        /// </summary>
        /// <param name="mealType">The <see cref="MealType"/> value to convert.</param>
        /// <returns>The integer value of the enum as a string.</returns>
        public static string ToString(MealType mealType) => ((int)mealType).ToString();
    }

    /// <summary>
    /// Helper class to convert integer values to <see cref="MealType"/> enum values.
    /// </summary>
    public static class IntToCategory
    {
        /// <summary>
        /// Converts an integer value to a corresponding <see cref="MealType"/> if defined.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The corresponding <see cref="MealType"/> if the value is valid; otherwise, <c>null</c>.</returns>
        public static MealType? FromInt(int value)
        {
            if (Enum.IsDefined(typeof(MealType), value))
            {
                return (MealType)value;
            }
            else
            {
                return null;
            }
        }
    }
}