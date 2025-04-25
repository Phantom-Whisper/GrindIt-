namespace GrindIt.WorkoutLib
{
    /// <summary>
    /// Represents the different muscle groups that can be targeted during an exercise.
    /// </summary>
    public enum TargetedMuscles
    {
        SHOULDERS,
        BACK,
        LOWERBACK,
        CHEST,
        ABS,
        TRICEPS,
        BICEPS,
        FOREARMS,
        QUADS,
        HARMSTRINGS,
        GLUTES,
        CALVES,
        OTHER
    }

    /// <summary>
    /// Provides a method for converting a <see cref="TargetedMuscles"/> enum value to a string representation.
    /// </summary>
    public static class TargetedMusclesToString
    {
        /// <summary>
        /// Converts a <see cref="TargetedMuscles"/> enum value to its string representation as an integer.
        /// </summary>
        /// <param name="targetedMuscles">The targeted muscle group.</param>
        /// <returns>The string representation of the <see cref="TargetedMuscles"/> enum value.</returns>
        public static string ToString(TargetedMuscles targetedMuscles) => ((int)targetedMuscles).ToString();
    }

    /// <summary>
    /// Provides methods to convert integers to <see cref="TargetedMuscles"/> enum values.
    /// </summary>
    public static class StringToCategory
    {
        /// <summary>
        /// Converts an integer value to the corresponding <see cref="TargetedMuscles"/> enum value.
        /// </summary>
        /// <param name="value">The integer value representing a <see cref="TargetedMuscles"/> enum.</param>
        /// <returns>The corresponding <see cref="TargetedMuscles"/> enum value, or null if the integer does not correspond to a valid enum.</returns>
        public static TargetedMuscles? FromInt(int value)
        {
            if (Enum.IsDefined(typeof(TargetedMuscles), value))
                return (TargetedMuscles)value;
            
            return null;
        }
    }
}
