using Core;

namespace GrindIt.Test
{
    public class UserTests
    {
        [Theory]
        [InlineData("John", 25)]
        [InlineData("Mohammed", 60)]
        [InlineData("Johanna", 19)]
        public void Constructor_ValidParameters_ShouldCreateUser(string name, int age)
        {
            var user = new User(name, age);

            Assert.Equal(name, user.Name);
            Assert.Equal(age, user.Age);
        }
    }
}