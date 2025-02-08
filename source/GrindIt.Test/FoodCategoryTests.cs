namespace GrindIt.NutritionLib.Tests;

public class FoodCategoryTests
{
    [Fact]
    public void CategoryToString_ShouldReturnCorrectStringRepresentation()
    {
        // Arrange & Act
        string cerealsString = CategoryToString.ToString(FoodCategory.CEREALS);
        string fruitsString = CategoryToString.ToString(FoodCategory.FRUITS);
        string vegetablesString = CategoryToString.ToString(FoodCategory.VEGETABLES);
        string dairyString = CategoryToString.ToString(FoodCategory.DAIRY);

        // Assert
        Assert.Equal("0", cerealsString);
        Assert.Equal("1", fruitsString);
        Assert.Equal("2", vegetablesString);
        Assert.Equal("3", dairyString);
    }

    [Fact]
    public void StringToCategory_ShouldReturnValidCategoryForValidInteger()
    {
        // Arrange & Act
        FoodCategory? cerealsCategory = StringToCategory.FromInt(0);
        FoodCategory? fruitsCategory = StringToCategory.FromInt(1);
        FoodCategory? vegetablesCategory = StringToCategory.FromInt(2);
        FoodCategory? dairyCategory = StringToCategory.FromInt(3);

        // Assert
        Assert.Equal(FoodCategory.CEREALS, cerealsCategory);
        Assert.Equal(FoodCategory.FRUITS, fruitsCategory);
        Assert.Equal(FoodCategory.VEGETABLES, vegetablesCategory);
        Assert.Equal(FoodCategory.DAIRY, dairyCategory);
    }

    [Fact]
    public void StringToCategory_ShouldReturnNullForInvalidInteger()
    {
        // Arrange & Act
        FoodCategory? invalidCategory1 = StringToCategory.FromInt(-1);
        FoodCategory? invalidCategory2 = StringToCategory.FromInt(10);

        // Assert
        Assert.Null(invalidCategory1); // -1 is an invalid value
        Assert.Null(invalidCategory2); // 10 is out of the range of FoodCategory enum
    }

    [Fact]
    public void StringToCategory_ShouldReturnNullForInvalidCategoryValue()
    {
        // Arrange & Act
        FoodCategory? invalidCategory = StringToCategory.FromInt(999); // 999 is an invalid value

        // Assert
        Assert.Null(invalidCategory);
    }
}
