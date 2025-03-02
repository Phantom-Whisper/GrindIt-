namespace GrindIt.WorkoutLib
{
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

    public static class TargetedMusclesToString
    {
        public static string ToString(TargetedMuscles targetedMuscles) => ((int)targetedMuscles).ToString();
    }

    public static class StringToCategory
    {
        public static TargetedMuscles? FromInt(int value)
        {
            if (Enum.IsDefined(typeof(TargetedMuscles), value))
            {
                return (TargetedMuscles)value;
            }
            else
            {
                return null;
            }
        }
    }
}
