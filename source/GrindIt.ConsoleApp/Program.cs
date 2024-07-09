using GrindIt.NutritionLib;
using GrindIt.WorkoutLib;


Menu();

void Menu()
{
    int choice;
    do
    {
        Console.Clear();
        Console.WriteLine("Menu: ");
        Console.WriteLine("1. GrindIt! - Nutrition");
        Console.WriteLine("2. GrindIt! - Workout");
        Console.WriteLine("9. Exit");
        Console.Write("Your choice: ");

        string? input = Console.ReadLine();

        while (!int.TryParse(input, out choice) || (choice != 1 && choice != 2 && choice != 9))
        {
            Console.Clear();
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. GrindIt! - Nutrition");
            Console.WriteLine("2. GrindIt! - Workout");
            Console.WriteLine("9. Exit");
            Console.Write("Your choice: ");
            input = Console.ReadLine();
        }

        if (choice == 1)
        {
            NutritionMenu();
        }
        else if (choice == 2)
        {
            WorkoutMenu();
        }
    }
    while (choice != 9);
}

void WorkoutMenu()
{
    int choice;
    do
    {
        Console.Clear();
        Console.WriteLine("Menu: ");
        Console.WriteLine("1. Test series");
        Console.WriteLine("2. Create exercice");
        Console.WriteLine("9. Exit");
        Console.Write("Your choice: ");

        string? input = Console.ReadLine();

        while (!int.TryParse(input, out choice) || (choice != 1 && choice != 2 && choice != 9))
        {
            Console.Clear();
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Test series");
            Console.WriteLine("2. Create exercice");
            Console.WriteLine("9. Exit");
            Console.Write("Your choice: ");
            input = Console.ReadLine();
        }

        if (choice == 1)
        {
            SeriesTest();
        }
        else if (choice == 2)
        {
            CreateExercice();
        }
    }
    while (choice != 9);
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
        Console.Write("Test total weight of the series: ");
        int test = reps1.TotalWeight();
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

void CreateExercice()
{
    Console.Clear();
    Console.Write("Enter a name: ");
    string? name = Console.ReadLine();
    bool bodyWeightBool;
    while (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("Please enter a name: ");
        name = Console.ReadLine();
    }
    Console.WriteLine("Does it's a bodyweight exercice ? YES or NO ");
    string? bodyWeight = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(bodyWeight))
    {
        while (bodyWeight.ToUpper() != "YES" ||  bodyWeight.ToUpper() != "NO")
        {
            Console.WriteLine("Please enter 'YES' or 'NO' only");
            bodyWeight = Console.ReadLine();
        }
        if (bodyWeight.ToUpper() == "YES")
        {
            bodyWeightBool = true;
        }
        else { bodyWeightBool = false; }
        
        DisplayTargetedMusclesEnum();
        Console.WriteLine("Choose a targeted muscles (enter the number)");
        string? muscles = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(muscles))
        {
            Console.WriteLine("Please select a muscle group");
            muscles = Console.ReadLine();
        }
        /*
        ObservableCollection<TargetedMuscles> musclesList = null;
        musclesList.Add(muscles);
        Exercices exercices = new Exercices(name, musclesList, bodyWeightBool);
        */
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

void DisplayTargetedMusclesEnum()
{
    foreach(TargetedMuscles targetedMuscles in Enum.GetValues(typeof(TargetedMuscles)))
    {
        string musclesString = TargetedMusclesToString.ToString(targetedMuscles);
        Console.WriteLine($"Targeted muscles: {targetedMuscles}, No.: {musclesString}");
    }
}