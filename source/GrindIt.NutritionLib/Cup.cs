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
            CupSize = value;
        }

        /// <summary>
        /// Gets or sets the size of the cup.
        /// This value represents a unit of measurement for serving sizes.
        /// </summary>
        public int CupSize { get; set; }
    }
}