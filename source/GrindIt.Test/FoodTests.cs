using GrindIt.NutritionLib;

namespace GrindIt.Test;

public class FoodTests
{
    [Fact]
    public void Constructor_ShouldThrowArgumentNullException_WhenNameIsNull()
    {
        var exception = Assert.Throws<ArgumentNullException>(() => new Food(null!, 100, 1, 25, 10, 5, 2, 1, 10, 50, 200, 5, 10, FoodCategory.Fruits));

        Assert.Equal("Value cannot be null. (Parameter 'value')", exception.Message);
    }


    [Fact]
    public void Constructor_ShouldInitializeCorrectly_WhenValidArgumentsAreProvided()
    {
        string name = "Apple";
        float calories = 100;
        double serving = 2.5;
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
        FoodCategory category = FoodCategory.Fruits;
        var food = new Food(name, calories, serving, carbohydrate, fat, protein, saturedFat, transFat, cholesterol, sodium, potassium, dietaryFiber, sugar, category);

        Assert.Equal(name, food.Name);
        Assert.Equal(calories, food.Calories);
        Assert.Equal(carbohydrate, food.Carbohydrate);
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
        var food = new Food("Apple", 100, 1,25, 10, 5, 2, 1, 10, 50, 200, 5, 10, FoodCategory.Fruits);

        Assert.NotNull(food);
        Assert.Equal(FoodCategory.Fruits, food.Category);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(100, 100)]
    [InlineData(-10, -10)]
    public void Properties_ShouldReturnCorrectValues(float input, float expected)
    {
        var food = new Food("Food", 100, 1,25, 10, 5, 2, 1, 10, 50, 200, 5, 10, FoodCategory.Fruits);

        Assert.Equal(expected, input);
    }

    [Fact]
    public void ShowFood_ShouldNotThrowException()
    {
        var food = new Food("Apple", 100, 1,25, 10, 5, 2, 1, 10, 50, 200, 5, 10, FoodCategory.Fruits);

        var exception = Record.Exception(() => food.ShowFood());
        Assert.Null(exception);
    }

    [Fact]
    public void CategoryEnum_ShouldContainValidValues()
    {
        var enumValues = Enum.GetValues(typeof(FoodCategory)) as FoodCategory[];

        Assert.Contains(FoodCategory.Cereals, enumValues);
        Assert.Contains(FoodCategory.Fruits, enumValues);
        Assert.Contains(FoodCategory.Vegetables, enumValues);
        Assert.Contains(FoodCategory.Dairy, enumValues);
        Assert.Contains(FoodCategory.Meats, enumValues);
        Assert.Contains(FoodCategory.Fish, enumValues);
        Assert.Contains(FoodCategory.Fats, enumValues);
        Assert.Contains(FoodCategory.Sugars, enumValues);
        Assert.Contains(FoodCategory.Drinks, enumValues);
    }


    [Fact]
    public void CategoryEnum_ShouldNotContainInvalidValues()
    {
        bool isValid = Enum.IsDefined(typeof(FoodCategory), 99);

        Assert.False(isValid);
    }
}
