namespace Core
{
    public class User
    {
        public string Name { get; }
        public int Age { get; }

        public User(string name, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");
            if (age <= 0)
                throw new ArgumentException("Age must be greater than zero.");

            Name = name;
            Age = age;
        }
    }
}