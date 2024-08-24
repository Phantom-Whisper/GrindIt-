using GrindIt.NutritionLib;
using GrindIt.WorkoutLib;

//SetTest();
//DisplayCategoryEnum();
//DisplayTargetedMusclesEnum();
CreateFood();


void SetTest()
{
    Set reps1 = new Set();
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

void CreateFood()
{
    string name;
    do
    {
        Console.WriteLine("Enter a name (cannot be empty): ");
        name = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(name));

    int GetValidIntInput(string prompt)
    {
        int value;
        while (true)
        {
            Console.WriteLine(prompt);
            if (int.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
            }
        }
    }

    int cal = GetValidIntInput("Enter the amount of calories for 100g: ");
    int carbs = GetValidIntInput("Enter the amount of carbohydrate for 100g: ");
    int fat = GetValidIntInput("Enter the amount of fat for 100g: ");
    int prot = GetValidIntInput("Enter the amount of protein for 100g: ");
    int satFat = GetValidIntInput("Enter the amount of saturated fat for 100g: ");
    int transFat = GetValidIntInput("Enter the amount of trans fat for 100g: ");
    int chol = GetValidIntInput("Enter the amount of cholesterol for 100g: ");
    int sodium = GetValidIntInput("Enter the amount of sodium for 100g: ");
    int pot = GetValidIntInput("Enter the amount of potassium for 100g: ");
    int diet = GetValidIntInput("Enter the amount of dietary fiber for 100g: ");
    int sugar = GetValidIntInput("Enter the amount of sugar for 100g: ");

    Console.Clear();
    DisplayCategoryEnum();

    FoodCategory category;
    while (true)
    {
        Console.WriteLine("Choose a food category: ");
        if (int.TryParse(Console.ReadLine(), out int res) && Enum.IsDefined(typeof(FoodCategory), res))
        {
            category = (FoodCategory)res; //Convert int to FoodCategory
            break;
        }
        else
        {
            Console.WriteLine("Invalid category. Please select a valid category number.");
        }
    }

    Food food = new Food(name, cal, carbs, fat, prot, satFat, transFat, chol, sodium, pot, diet, sugar, category);

    food.ShowFood();
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
        Console.WriteLine($"Targeted muscles: {targetedMuscles}, ToString: {musclesString}");
    }
}
