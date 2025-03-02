using System.Xml.Serialization;

namespace GrindIt.NutritionLib
{
    public class FoodEntry
    {
        public FoodEntry() { }

        public FoodEntry(Food food, float portionSize)
        {
            Food = food;
            PortionSize = portionSize;
        }

        [XmlElement("Food")]
        public Food? Food { get; set; }

        [XmlElement("PortionSize")]
        public float PortionSize { get; set; }
    }
}
