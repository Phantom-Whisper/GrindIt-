using GrindIt.NutritionLib;
using GrindIt.WorkoutLib;
using System.Collections.Specialized;
using System.Globalization;


Menu();

void Menu()
{
    bool exit = false;
    while (!exit)
    {
        Console.Clear();
        Console.WriteLine("Menu: ");
        Console.WriteLine("1. GrindIt! - Nutrition");
        Console.WriteLine("2. GrindIt! - Workout");
        Console.WriteLine("9. Exit");
        Console.Write("Your choice: ");

        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                NutritionMenu();
                break;
            case "2":
                WorkoutMenu();
                break;
            case "9":
                exit = true;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again");
                break;
        }
    }
}

void WorkoutMenu()
{
    bool exit = false;
    while (!exit)
    {
        Console.Clear();
        Console.WriteLine("Menu: ");
        Console.WriteLine("1. Test series");
        Console.WriteLine("9. Exit");
        Console.Write("Your choice: ");

        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                SeriesTest();
                break;
            case "9":
                exit = true;
                break;
            default:
                Console.WriteLine("Invalid option.Please try again");
                break;
        }
    }
}

void NutritionMenu()
{
    DisplayCategoryEnum();
}

void SeriesTest()
{
    Series reps1 = new Series();
    bool exit = false;
    while (!exit)
    {
        Console.Clear();
        Console.WriteLine("1. Add weight");
        Console.WriteLine("2. Remove weight");
        Console.WriteLine("3. Add reps");
        Console.WriteLine("4. Remove reps");
        Console.WriteLine("5. Enter weight");
        Console.WriteLine("6. Enter reps");
        Console.WriteLine("9. Exit");

        Console.Write("Weight: ");
        Console.WriteLine(reps1.Weight);
        Console.Write("Reps: ");
        Console.WriteLine(reps1.Reps);
        int test = reps1.TotalWeight();
        Console.Write("Test total weight of the series: ");
        Console.WriteLine(test);

        Console.Write("Your choice: ");
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                reps1.AddWeight();
                break;
            case "2":
                reps1.RemoveWeigth();
                break;
            case "3":
                reps1.AddReps();
                break;
            case "4":
                reps1.RemoveReps();
                break;
            case "5":
                int weight;
                Console.WriteLine("Enter the weight: ");
                string? input2 = Console.ReadLine();
                int.TryParse(input2, out weight);
                reps1.AddWeight(weight);
                break;
            case "6":
                int reps;
                Console.WriteLine("Enter the reps: ");
                string? input3 = Console.ReadLine();
                int.TryParse(input3, out reps);
                reps1.AddReps(reps);
                break;
            case "9":
                exit = true;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again");
                break;
        }
    }
}


void DisplayCategoryEnum()
{
    Console.WriteLine("Test Enum food category");
    foreach (FoodCategory category in Enum.GetValues(typeof(FoodCategory)))
    {
        string categoryString = CategoryToString.ToString(category);
        Console.WriteLine($"Category: {category}, ToString: {categoryString}");
    }
}
