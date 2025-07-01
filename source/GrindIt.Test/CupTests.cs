using GrindIt.NutritionLib;

namespace GrindIt.Test;

public class CupTests
{
    [Theory]
    [InlineData(150, 150)]
    [InlineData(25, 25)]
    public void Size_ShouldReturnExpectedValue(int cupSize, int expectedValue)
    {
        Cup testCup = new Cup(cupSize);
        Assert.Equal(expectedValue, testCup.Size);
    }

    [Theory]
    [InlineData(-15)]
    [InlineData(0)]
    public void Size_ShouldThrowExceptionWhenValueIsNegativeOrZero(int value)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Cup(value));
    }
}