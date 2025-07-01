namespace GrindIt.NutritionLib
{
    /// <summary>
    /// Represents a measuring cup used to define portion sizes for food servings.
    /// </summary>
    public class Cup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cup"/> class with a specified cup size.
        /// </summary>
        /// <param name="value">The size of the cup, typically in milliliters or grams.</param>
        public Cup(int value)
        {
            Size = value;
        }
        
        /// <summary>
        /// Contains the size of the cup
        /// </summary>
        private readonly int _cupSize;
        
        /// <summary>
        /// Gets or sets the size of the cup.
        /// This value represents a unit of measurement for serving sizes.
        /// </summary>
        public int Size
        {
            get => _cupSize;
            private init
            {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value);
                _cupSize = value;
            }
        }
    }
}