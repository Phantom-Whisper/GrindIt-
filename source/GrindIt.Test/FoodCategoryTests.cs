using GrindIt.NutritionLib;

namespace GrindIt.Test
{
    public class FoodCategoryTests
    {
        [Theory]
        [InlineData("0", FoodCategory.Cereals)]
        [InlineData("1", FoodCategory.Fruits)]
        [InlineData("2", FoodCategory.Vegetables)]
        [InlineData("3", FoodCategory.Dairy)]
        [InlineData("4", FoodCategory.Meats)]
        [InlineData("5", FoodCategory.Fish)]
        [InlineData("6", FoodCategory.Fats)]
        [InlineData("7", FoodCategory.Sugars)]
        [InlineData("8", FoodCategory.Drinks)]
        public void FoodCategoryHelper_ConvertToString(string expectedString, FoodCategory input)
        {
            Assert.Equal(expectedString, FoodCategoryHelper.ConvertToString(input));
        }
    }
}

