namespace Core
{
    /// <summary>
    /// Represents the user's legal identity
    /// </summary>
    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// 
        /// </summary>
        public int Age { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <exception cref="ArgumentException"></exception>
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