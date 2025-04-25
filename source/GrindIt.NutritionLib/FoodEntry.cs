using System.Xml.Serialization;

namespace GrindIt.NutritionLib
{
    /// <summary>
    /// Represents an entry that links a specific food item with its portion size.
    /// </summary>
    public class FoodEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FoodEntry"/> class.
        /// Required for XML serialization.
        /// </summary>
        public FoodEntry() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FoodEntry"/> class with a specified food item and portion size.
        /// </summary>
        /// <param name="food">The food item associated with this entry.</param>
        /// <param name="portionSize">The portion size of the food item.</param>
        public FoodEntry(Food food, float portionSize)
        {
            Food = food;
            PortionSize = portionSize;
        }

        /// <summary>
        /// Gets or sets the <see cref="Food"/> object for this entry.
        /// </summary>
        [XmlElement("Food")]
        public Food? Food { get; set; }

        /// <summary>
        /// Gets or sets the portion size of the food item.
        /// This value is used to scale the nutritional values accordingly.
        /// </summary>
        [XmlElement("PortionSize")]
        public float PortionSize { get; set; }
    }
}