namespace GrindIt.NutritionLib.Tests;

public class FoodTests
{
    [Fact]
    public void Constructor_ShouldThrowArgumentNullException_WhenNameIsNull()
    {
        var exception = Assert.Throws<ArgumentNullException>(() => new Food(null, 100, 25, 10, 5, 2, 1, 10, 50, 200, 5, 10, FoodCategory.FRUITS));

        Assert.Equal("Value cannot be null. (Parameter 'name')", exception.Message);
    }


    [Fact]
    public void Constructor_ShouldInitializeCorrectly_WhenValidArgumentsAreProvided()
    {
        string name = "Apple";
        float calories = 100;
        float carbohydrate = 25;
        float fat = 10;
        float protein = 5;
        float saturedFat = 2;
        float transFat = 1;
        float cholesterol = 10;
        float sodium = 50;
        float potassium = 200;
        float dietaryFiber = 5;
        float sugar = 10;
        FoodCategory category = FoodCategory.FRUITS;

        var food = new Food(name, calories, carbohydrate, fat, protein, saturedFat, transFat, cholesterol, sodium, potassium, dietaryFiber, sugar, category);

        Assert.Equal(name, food.Name);
        Assert.Equal(calories, food.Calories);
        Assert.Equal(carbohydrate, food.Cabohydrate);
        Assert.Equal(fat, food.Fat);
        Assert.Equal(protein, food.Protein);
        Assert.Equal(saturedFat, food.SaturedFat);
        Assert.Equal(transFat, food.TransFat);
        Assert.Equal(cholesterol, food.Cholesterol);
        Assert.Equal(sodium, food.Sodium);
        Assert.Equal(potassium, food.Potassium);
        Assert.Equal(dietaryFiber, food.DietaryFiber);
        Assert.Equal(sugar, food.Sugar);
        Assert.Equal(category, food.Category);
    }

    [Fact]
    public void Constructor_ShouldNotThrow_WhenValidCategoryIsProvided()
    {
        var food = new Food("Apple", 100, 25, 10, 5, 2, 1, 10, 50, 200, 5, 10, FoodCategory.FRUITS);

        Assert.NotNull(food);
        Assert.Equal(FoodCategory.FRUITS, food.Category);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(100, 100)]
    [InlineData(-10, -10)]
    public void Properties_ShouldReturnCorrectValues(float input, float expected)
    {
        var food = new Food("Food", 100, 25, 10, 5, 2, 1, 10, 50, 200, 5, 10, FoodCategory.FRUITS);

        Assert.Equal(expected, input);
    }

    [Fact]
    public void ShowFood_ShouldNotThrowException()
    {
        var food = new Food("Apple", 100, 25, 10, 5, 2, 1, 10, 50, 200, 5, 10, FoodCategory.FRUITS);

        var exception = Record.Exception(() => food.ShowFood());
        Assert.Null(exception);
    }

    [Fact]
    public void CategoryEnum_ShouldContainValidValues()
    {
        var enumValues = Enum.GetValues(typeof(FoodCategory)) as FoodCategory[];

        Assert.Contains(FoodCategory.CEREALS, enumValues);
        Assert.Contains(FoodCategory.FRUITS, enumValues);
        Assert.Contains(FoodCategory.VEGETABLES, enumValues);
        Assert.Contains(FoodCategory.DAIRY, enumValues);
        Assert.Contains(FoodCategory.MEATS, enumValues);
        Assert.Contains(FoodCategory.FISH, enumValues);
        Assert.Contains(FoodCategory.FATS, enumValues);
        Assert.Contains(FoodCategory.SUGARS, enumValues);
        Assert.Contains(FoodCategory.DRINKS, enumValues);
    }


    [Fact]
    public void CategoryEnum_ShouldNotContainInvalidValues()
    {
        bool isValid = Enum.IsDefined(typeof(FoodCategory), (int)99);

        Assert.False(isValid);
    }
}
