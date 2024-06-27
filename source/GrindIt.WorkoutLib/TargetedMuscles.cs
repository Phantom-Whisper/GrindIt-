namespace GrindIt.WorkoutLib
{
    public enum TargetedMuscles
    {
        SHOULDERS = 0,
        BACK = 1,
        LOWERBACK = 2,
        CHEST = 3,
        ABS = 4,
        TRICEPS = 5,
        BICEPS = 6,
        FOREARMS = 7,
        QUADS = 8,
        HARMSTRINGS = 9,
        GLUTES = 10,
        CALVES = 11,
        OTHER = 12
    }

    public static class TargetedMusclesToString
    {
        public static string ToString(TargetedMuscles targetedMuscles) => ((int)targetedMuscles).ToString();
    }
}
