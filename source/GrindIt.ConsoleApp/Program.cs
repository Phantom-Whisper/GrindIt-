using Core;
using GrindIt.NutritionLib;
using GrindIt.WorkoutLib;
using Serialization;
using System.Globalization;

List<Food> list = new List<Food>
{
    new Food("Grilled Chicken Breast", 165, 100, 0, 3.6f, 31f, 1f, 0f, 85f, 70f, 256f, 0f, 0f, FoodCategory.MEATS),
    new Food("Apple", 52f, 100, 14f, 0.2f, 0.3f, 0f, 0f, 0f, 1f, 107f, 2.4f, 10f, FoodCategory.FRUITS),
    new Food("Avocado", 160f, 100, 9f, 15f, 2f, 2.1f, 0f, 0f, 7f, 485f, 7f, 0.7f, FoodCategory.FRUITS),
    new Food("Chocolate Cake", 352f, 100, 50f, 15f, 5f, 3.8f, 0.1f, 50f, 210f, 160f, 2f, 36f, FoodCategory.SUGARS),
    new Food("Salmon Fillet", 206f, 100, 0f, 13f, 22f, 3.1f, 0f, 63f, 55f, 384f, 0f, 0f, FoodCategory.FISH),
    new Food("Broccoli", 55f, 100, 11.2f, 0.6f, 3.7f, 0f, 0f, 0f, 33f, 316f, 2.4f, 2.2f, FoodCategory.VEGETABLES),
    new Food("Banana", 89f, 100, 22.8f, 0.3f, 1.1f, 0.1f, 0f, 0f, 1f, 358f, 2.6f, 12.2f, FoodCategory.FRUITS),
    new Food("Oatmeal", 158f, 100, 27f, 3.2f, 6f, 0.5f, 0f, 0f, 2f, 164f, 4f, 1f, FoodCategory.CEREALS),
    new Food("Almonds", 576f, 100, 21.6f, 49.4f, 21.2f, 3.7f, 0f, 0f, 1f, 705f, 12.5f, 4.8f, FoodCategory.CEREALS),
    new Food("Greek Yogurt", 59f, 100, 3.6f, 0.4f, 10f, 0.1f, 0f, 5f, 36f, 141f, 0f, 3.2f, FoodCategory.DAIRY),
    new Food("Sweet Potato", 86f, 100, 20.1f, 0.1f, 1.6f, 0f, 0f, 0f, 55f, 337f, 3f, 4.2f, FoodCategory.VEGETABLES),
    new Food("Peanut Butter", 588f, 100, 20f, 50f, 25f, 10f, 0f, 0f, 17f, 649f, 6f, 9f, FoodCategory.FATS),
    new Food("Cheddar Cheese", 402f, 100, 1.3f, 33.1f, 24.9f, 19f, 1f, 105f, 621f, 98f, 0f, 0.5f, FoodCategory.DAIRY),
    new Food("Brown Rice", 123f, 100, 25.6f, 1f, 2.7f, 0.2f, 0f, 0f, 5f, 86f, 1.8f, 0.4f, FoodCategory.CEREALS),
    new Food("Eggs", 155f, 100, 1.1f, 11f, 13f, 3.3f, 1.6f, 373f, 124f, 126f, 0f, 1.1f, FoodCategory.MEATS),
};

list.Sort();



//SetTest();
//DisplayCategoryEnum();
//DisplayTargetedMusclesEnum();
//CreateFood();
//CreateExercise();
//CreateMeal();
//WaterManagement();
//CreateUser();
ExercicesSave();
//RecordMeal();
//RecordSleep();
//RecordWorkout();

void RecordWorkout()
{
    WorkoutSerializer workoutSerializer = new WorkoutSerializer();

    var workout = new Workout();

    var exercise1 = new Exercise("Assisted Dips", false);
    exercise1.AddSet(new Set(50, 10));  
    exercise1.AddSet(new Set(60, 8));   

    var exercise2 = new Exercise("Band-Assisted Bench Press", false);
    exercise2.AddSet(new Set(40, 12));
    exercise2.AddSet(new Set(45, 10));

    var exercise3 = new Exercise("Bar Dips", true);
    exercise3.AddSet(new Set(0, 15)); 
    exercise3.AddSet(new Set(0, 12)); 

    var exercise4 = new Exercise("Barbell Bench Press", false);
    exercise4.AddSet(new Set(70, 10));  
    exercise4.AddSet(new Set(80, 8));  

    var exercise5 = new Exercise("Barbell Board Press", false);
    exercise5.AddSet(new Set(60, 6));   
    exercise5.AddSet(new Set(65, 5));   

    workout.AddExercise(exercise1);
    workout.AddExercise(exercise2);
    workout.AddExercise(exercise3);
    workout.AddExercise(exercise4);
    workout.AddExercise(exercise5);

    Console.WriteLine($"Workout Date: {workout.WorkoutDateTime}");
    foreach (var exercise in workout.Exercises)
    {
        Console.WriteLine($"Exercise: {exercise.Name} (Bodyweight: {exercise.BodyWeight})");
        foreach (var set in exercise.SetList)
        {
            Console.WriteLine($"  - {set.Reps} reps at {set.Weight}kg");
        }
    }

    // End the workout
    workout.EndWorkout();
    workoutSerializer.SaveWorkoutRecord(workout);
    Console.WriteLine($"Workout Duration: {workout.WorkoutDuration}");
}

void RecordSleep()
{
    DateTime bedTime = new DateTime(2025, 3, 1, 22, 35, 0);
    DateTime wakeUpTime = new DateTime(2025, 3, 2, 8, 5, 0);

    SleepSerializer sleepSerializer = new SleepSerializer();

    Sleep newSleep = new Sleep(bedTime, wakeUpTime, sleepSerializer);

    newSleep.CalculateSleepDuration();

    newSleep.SaveSleepRecord();

    newSleep.ShowSleepDuration();
}

void RecordMeal()
{
    Meal userMeal = CreateMeal();

    Console.WriteLine($"Default meal date & time: {userMeal.MealDateTime:yyyy-MM-dd HH:mm}");
    Console.WriteLine("Do you want to change it? (yes/no): ");
    string changeInput = Console.ReadLine()?.Trim().ToLower();

    if (changeInput == "yes")
    {
        Console.WriteLine("Enter new meal date (yyyy-MM-dd): ");
        string dateInput = Console.ReadLine();
        Console.WriteLine("Enter new meal time (HH:mm): ");
        string timeInput = Console.ReadLine();

        userMeal.MealDateTime = DateTime.Parse($"{dateInput} {timeInput}");
    }

    userMeal.ShowMeal();

    var mealSerialize = new MealSerializer();

    mealSerialize.Save(userMeal);

    var loadedMeal = mealSerialize.Load<Meal>();

    if (loadedMeal != null)
    {
        Console.WriteLine("----------------Loading test-----------------------");
        loadedMeal.ShowMeal();
    }
    else Console.WriteLine("No data found.");
}

void ExercicesSave()
{
    ExerciseSerializer serializer = new();

    List<Exercise> exercicesList = serializer.Load<List<Exercise>>();

    if (exercicesList != null)
    {
        foreach (var exercise in exercicesList)
        {
            exercise.ShowExercise();
        }
    }
    else
    {
        Console.WriteLine("No data found.");
    }
}

void FoodSave()
{
    FoodSerializer foodSerialize = new();

    foodSerialize.Save(list);

    List<Food> loadedFood = foodSerialize.Load<List<Food>>();

    if (loadedFood != null)
    {
        foreach (Food food in loadedFood)
        {
            food.ShowFood();
        }
    }
    else
    {
        Console.WriteLine("No data found.");
    }
}

void CreateUser()
{
    string? name;
    do
    {
        Console.Write("Enter your name (cannot be empty): ");
        name = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(name));

    Console.Write("Enter your age: ");
    int.TryParse(Console.ReadLine(), out int age);

    Console.Write("Enter your weight (kg): ");
    double.TryParse(Console.ReadLine(), out double weight);

    Console.Write("Enter your height (cm): ");
    double.TryParse(Console.ReadLine(), out double height);

    User user = new(name, age);
    Height userHeight = new(height);
    Weight userWeight = new(weight);
    HealthMetrics healthMetrics = new(user, userWeight, userHeight);


    Console.Clear();
    Console.WriteLine($"BMI: {healthMetrics.CalculateBMI()}");
    Console.WriteLine($"You are {healthMetrics.GetBMICategory()}.");
}

void ShowKnownFood()
{
    int count = 1;
    foreach (Food food in list)
    {
        Console.WriteLine($"{count}. " + food.Name);
        count++;
    }
}

Set SetTest()
{
    Set set = new Set();
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
        Console.WriteLine(set.Weight);
        Console.Write("Reps: ");
        Console.WriteLine(set.Reps);
        Console.Write("Test total weight of the series: ");
        int test = set.TotalWeight();
        Console.WriteLine(test);

        Console.Write("Your choice: ");
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                set.AddWeight();
                break;
            case "2":
                set.RemoveWeight();
                break;
            case "3":
                set.AddReps();
                break;
            case "4":
                set.RemoveReps();
                break;
            case "5":
                int weight;
                Console.WriteLine("Enter the weight: ");
                string? input2 = Console.ReadLine();
                int.TryParse(input2, out weight);
                set.SetWeight(weight);
                break;
            case "6":
                int reps;
                Console.WriteLine("Enter the reps: ");
                string? input3 = Console.ReadLine();
                int.TryParse(input3, out reps);
                set.SetReps(reps);
                break;
            case "9":
                exit = true;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again");
                break;
        }
    }

    return set;
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
    int serving = (int)GetValidIntInput("Enter the size of one serving: ");
    float cal = GetValidIntInput($"Enter the amount of calories for {serving}: ");
    float carbs = GetValidIntInput($"Enter the amount of carbohydrate for {serving}: ");
    float fat = GetValidIntInput($"Enter the amount of fat for {serving}: ");
    float prot = GetValidIntInput($"Enter the amount of protein for {serving}: ");
    float satFat = GetValidIntInput($"Enter the amount of carbohydrate for  {serving}: ");
    float transFat = GetValidIntInput($"Enter the amount of carbohydrate for  {serving}:  ");
    float chol = GetValidIntInput($"Enter the amount of protein for  {serving}: ");
    float sodium = GetValidIntInput($"Enter the amount of sodium for {serving}: ");
    float pot = GetValidIntInput($"Enter the amount of potassium for {serving}: ");
    float diet = GetValidIntInput($"Enter the amount of dietary fiber for {serving}: ");
    float sugar = GetValidIntInput($"Enter the amount of sugar for {serving}: ");

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

    Food food = new Food(name, cal, serving, carbs, fat, prot, satFat, transFat, chol, sodium, pot, diet, sugar, category);

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

        List<TargetedMuscles> selectedMuscles = new();
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

Meal CreateMeal()
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
    Console.Clear();
    ShowKnownFood();

    while (true)
    {
        Console.Write("Enter the number of the food you want to add to the meal (or type 0 to finish): ");
        if (int.TryParse(Console.ReadLine(), out int foodNumber) && foodNumber >= 0 && foodNumber <= list.Count)
        {
            if (foodNumber == 0) break;
            Console.Write("Enter the serving portion of the food you to add (separate with ',': ");
            float.TryParse(Console.ReadLine(), out float serving);
            meal.AddFood(list[foodNumber - 1], serving);
        }
        else
        {
            Console.WriteLine("Invalid selection. Please choose a valid food number.");
        }
        Console.Clear();
        ShowKnownFood();
    }

    Console.Clear();
    meal.ShowMeal();

    return meal;
}

void WaterManagement()
{
    WaterSerializer waterSerializer = new WaterSerializer();
    bool exit = false;

    Console.Write("Enter a cup size (it will be used to add a certain quantity of water to your daily track): ");
    int.TryParse(Console.ReadLine(), out int cupSize);
    Cup cup = new(cupSize);

    Console.Clear();

    Console.Write("Enter a daily target: ");
    int.TryParse(Console.ReadLine(), out int dailyTarget);
    Water water = new(dailyTarget, waterSerializer);

    while (!exit)
    {
        Console.Clear();
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Remove");
        Console.WriteLine("3. Exit");
        water.ShowWater();

        int.TryParse(Console.ReadLine(), out int choice);

        if (choice == 1)
        {
            Console.Clear();
            water.AddWater(cup.CupSize);
        }
        else if (choice == 2)
        {
            Console.Clear();
            water.RemoveWater(cup.CupSize);
        }
        else if (choice == 3)
        {
            exit = true;
        }
        else
        {
            Console.WriteLine("Invalid option. Please try again.");
        }

    }
}

void DisplayCategoryEnum()
{
    Console.WriteLine("Test Enum food category");
    foreach (FoodCategory category in Enum.GetValues(typeof(FoodCategory)))
    {
        string categoryString = FoodCategoryHelper.ConvertToString(category);
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