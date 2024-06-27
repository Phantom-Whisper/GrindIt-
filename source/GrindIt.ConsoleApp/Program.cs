using GrindIt.NutritionLib;
using GrindIt.WorkoutLib;

DisplayCategoryEnum();
DisplayTargetedMusclesEnum();

void DisplayCategoryEnum()
{
    Console.WriteLine("Test Enum food category");
    foreach (Category category in Enum.GetValues(typeof(Category)))
    {
        string categoryString = CategoryToString.ToString(category);
        Console.WriteLine($"Category: {category}, ToString: {categoryString}");
    }
}

void DisplayTargetedMusclesEnum()
{
    Console.WriteLine("Test Enum muscles targeted");
    foreach (TargetedMuscles muscles in Enum.GetValues(typeof(TargetedMuscles))) 
    {
        string muscleString = TargetedMusclesToString.ToString(muscles);
        Console.WriteLine($"Muscles group: {muscles}, ToString: {muscleString}");
    }
}