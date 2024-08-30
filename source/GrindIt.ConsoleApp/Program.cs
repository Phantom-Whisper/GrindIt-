using GrindIt.NutritionLib;
using GrindIt.WorkoutLib;
using System.Runtime.InteropServices;
using System.Xml.Linq;

//SetTest();
//DisplayCategoryEnum();
//DisplayTargetedMusclesEnum();
//CreateFood();
//CreateExercise();
CreateMeal();


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
        Console.Write("Enter a name (cannot be empty): ");
        name = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(name));

    float GetValidIntInput(string prompt)
    {
        float value;
        while (true)
        {
            Console.Write(prompt);
            if (float.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer value or a use ',' as separator.");
            }
        }
    }

    float cal = GetValidIntInput("Enter the amount of calories for 100g: ");
    float carbs = GetValidIntInput("Enter the amount of carbohydrate for 100g: ");
    float fat = GetValidIntInput("Enter the amount of fat for 100g: ");
    float prot = GetValidIntInput("Enter the amount of protein for 100g: ");
    float satFat = GetValidIntInput("Enter the amount of saturated fat for 100g: ");
    float transFat = GetValidIntInput("Enter the amount of trans fat for 100g: ");
    float chol = GetValidIntInput("Enter the amount of cholesterol for 100g: ");
    float sodium = GetValidIntInput("Enter the amount of sodium for 100g: ");
    float pot = GetValidIntInput("Enter the amount of potassium for 100g: ");
    float diet = GetValidIntInput("Enter the amount of dietary fiber for 100g: ");
    float sugar = GetValidIntInput("Enter the amount of sugar for 100g: ");

    Console.Clear();
    DisplayCategoryEnum();

    FoodCategory category;
    while (true)
    {
        Console.Write("Choose a food category: ");
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

    Console.Clear();
    food.ShowFood();
}

void CreateExercise()
{
    string name;
    do
    {
        Console.Write("Enter a name (cannot be empty): ");
        name = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(name));

    bool bodyW;
    string input;
    do
    {
        Console.Write("Is it a bodyweight exercise ?(Y or N): ");
        input = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(input));
    if (input.ToUpper() == "Y")
    {
        bodyW = true;
    }
    else { bodyW = false; }

    Exercise exercise = new Exercise(name, bodyW);
    Console.Clear();
    DisplayTargetedMusclesEnum();

    while (true)
    {
        Console.Write("Choose one or more muscle groups (comma-separated): ");
        string[] inputs = Console.ReadLine().Split(',');

        List<TargetedMuscles> selectedMuscles = new List<TargetedMuscles>();
        bool allValid = true;

        foreach (string item in inputs)
        {
            if (int.TryParse(item.Trim(), out int res) && Enum.IsDefined(typeof(TargetedMuscles), res))
            {
                TargetedMuscles muscle = (TargetedMuscles)res;
                selectedMuscles.Add(muscle);
            }
            else
            {
                allValid = false;
                Console.WriteLine($"Invalid muscle group number: {item.Trim()}");
            }
        }

        if (allValid && selectedMuscles.Count > 0)
        {
            foreach (var muscle in selectedMuscles)
            {
                exercise.AddTargetedMuscles(muscle);
            }
            break;
        }
        else
        {
            Console.WriteLine("Please select at least one valid muscle group.");
        }
    }


    Console.Clear();
    exercise.ShowExercise();
}

void CreateMeal()
{
    DisplayMealTypeEnum();
    MealType mealType;

    while (true)
    {
        Console.Write("Choose a type of meal: ");
        if (int.TryParse(Console.ReadLine(), out int res) && Enum.IsDefined(typeof(MealType), res))
        {
            mealType = (MealType)res; //Convert int to FoodCategory
            break;
        }
        else
        {
            Console.WriteLine("Invalid category. Please select a valid category number.");
        }
    }

    Meal meal = new(mealType);
    Food food1 = new("Grilled Chicken Breast", 165, 0, 3.6f, 31f, 1f, 0f, 85f, 70f, 256f, 0f, 0f, FoodCategory.MEATS);
    Food food2 = new("Apple", 52f, 14f, 0.2f, 0.3f, 0f, 0f, 0f, 1f, 107f, 2.4f, 10f, FoodCategory.FRUITS);
    Food food3 = new("Avocado", 160f, 9f, 15f, 2f, 2.1f, 0f, 0f, 7f, 485f, 7f, 0.7f, FoodCategory.FRUITS);
    Food food4 = new("Chocolate Cake", 352f, 50f, 15f, 5f, 3.8f, 0.1f, 50f, 210f, 160f, 2f, 36f, FoodCategory.SUGARS);
    Food food5 = new("Salmon Fillet", 206f, 0f, 13f, 22f, 3.1f, 0f, 63f, 55f, 384f, 0f, 0f, FoodCategory.FISH);
    meal.AddFood(food1);
    meal.AddFood(food2);
    meal.AddFood(food3);
    meal.AddFood(food4);
    meal.AddFood(food5);
    Console.Clear();
    meal.ShowMeal();
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

void DisplayMealTypeEnum()
{
    Console.WriteLine("Test Enum MealType");
    foreach (MealType meal in Enum.GetValues(typeof(MealType)))
    {
        string MealString = MealTypeToString.ToString(meal);
        Console.WriteLine($"Meal type: {meal}, ToString: {MealString}");
    }
}