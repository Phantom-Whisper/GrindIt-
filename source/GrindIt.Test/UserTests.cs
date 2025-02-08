using Core;

namespace GrindIt.Test
{
    public class UserTests
    {
        [Fact]
        public void Constructor_ValidParameters_ShouldCreateUser()
        {
            var user = new User("John", 25, 70, 175);

            Assert.Equal("John", user.Name);
            Assert.Equal(25, user.Age);
            Assert.Equal(70, user.Weight);
            Assert.Equal(175, user.Height);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Name_InvalidValues_ShouldThrowException(string invalidName)
        {
            var user = new User("John", 25, 70, 175);
            Assert.Throws<ArgumentException>(() => user.Name = invalidName);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Age_InvalidValues_ShouldThrowException(int invalidAge)
        {
            var user = new User("John", 25, 70, 175);
            Assert.Throws<ArgumentException>(() => user.Age = invalidAge);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        public void Weight_InvalidValues_ShouldThrowException(double invalidWeight)
        {
            var user = new User("John", 25, 70, 175);
            Assert.Throws<ArgumentException>(() => user.Weight = invalidWeight);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void Height_InvalidValues_ShouldThrowException(double invalidHeight)
        {
            var user = new User("John", 25, 70, 175);
            Assert.Throws<ArgumentException>(() => user.Height = invalidHeight);
        }

        [Fact]
        public void CalculateBMI_ValidValues_ShouldReturnCorrectBMI()
        {
            var user = new User("John", 25, 70, 175);
            double expectedBMI = Math.Round((70 / Math.Pow(175, 2)) * 10000, 1);

            double calculatedBMI = user.CalculateBMI();

            Assert.Equal(expectedBMI, calculatedBMI);
        }

        [Theory]
        [InlineData(0, 175)]
        [InlineData(-10, 180)]
        public void CalculateBMI_InvalidValues_ShouldThrowException(double weight, double height)
        {
            var ex = Assert.Throws<ArgumentException>(() => new User("John", 30, weight, height));

            Assert.Equal("Weight must be greater than zero.", ex.Message);
        }




        [Fact]
        public void CalculateIMG_BMINotCalculated_ShouldThrowException()
        {
            var user = new User("John", 25, 70, 175);
            Assert.Throws<InvalidOperationException>(() => user.CalculateIMG(true));
        }

        [Theory]
        [InlineData(50, 175, "Underweight")]
        [InlineData(70, 175, "Normal weight")]
        [InlineData(85, 175, "Overweight")]
        [InlineData(100, 175, "Obese")]
        public void GetBMICategory_ShouldReturnCorrectCategory(double weight, double height, string expectedCategory)
        {
            var user = new User("John", 25, weight, height);
            user.CalculateBMI(); 

            Assert.Equal(expectedCategory, user.GetBMICategory());
        }


        [Theory]
        [InlineData(4, true, "Essential Fat")]
        [InlineData(10, true, "Athletes")]
        [InlineData(15, true, "Fitness")]
        [InlineData(20, true, "Average")]
        [InlineData(25, true, "Obese")]
        [InlineData(10, false, "Essential Fat")]
        [InlineData(15, false, "Athletes")]
        [InlineData(22, false, "Fitness")]
        [InlineData(28, false, "Average")]
        [InlineData(35, false, "Obese")]
        public void GetIMGCategory_ShouldReturnCorrectCategory(double img, bool isMale, string expectedCategory)
        {
            var user = new User("John", 25, 70, 175);

            Assert.Equal(expectedCategory, user.GetIMGCategory(img, isMale));
        }
    }
}