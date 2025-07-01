using System.Xml.Serialization;

namespace GrindIt.NutritionLib
{
    /// <summary>
    /// Represents a food item with detailed nutritional information.
    /// </summary>
    [Serializable]
    [XmlRoot("Food")]
    public class Food : IComparable<Food>
    {
        /// <summary>
        /// Default constructor used for XML serialization.
        /// </summary>
        public Food() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Food"/> class with all nutritional values and category.
        /// </summary>
        /// <param name="name">Name of the food.</param>
        /// <param name="calories">Calories per serving.</param>
        /// <param name="serving">Serving size (usually in grams or ml).</param>
        /// <param name="carbohydrate">Carbohydrate content per serving (in grams).</param>
        /// <param name="fat">Fat content per serving (in grams).</param>
        /// <param name="protein">Protein content per serving (in grams).</param>
        /// <param name="saturedFat">Saturated fat content per serving (in grams).</param>
        /// <param name="transFat">Trans fat content per serving (in grams).</param>
        /// <param name="cholesterol">Cholesterol content per serving (in milligrams).</param>
        /// <param name="sodium">Sodium content per serving (in milligrams).</param>
        /// <param name="potassium">Potassium content per serving (in milligrams).</param>
        /// <param name="dietaryFiber">Dietary fiber content per serving (in grams).</param>
        /// <param name="sugar">Sugar content per serving (in grams).</param>
        /// <param name="category">Category to which the food belongs.</param>
        public Food(string name, float calories, double serving, float carbohydrate, float fat, float protein, float saturedFat, float transFat,
            float cholesterol, float sodium, float potassium, float dietaryFiber, float sugar, FoodCategory category)
        {
            Name = name;
            Calories = calories;
            ServingSize = serving;
            Carbohydrate = carbohydrate;
            Fat = fat;
            Protein = protein;
            SaturedFat = saturedFat;
            TransFat = transFat;
            Cholesterol = cholesterol;
            Sodium = sodium;
            Potassium = potassium;
            DietaryFiber = dietaryFiber;
            Sugar = sugar;
            Category = category;
        }

        private string _name;
        /// <summary>
        /// Gets or sets the name of the food.
        /// </summary>
        [XmlElement("Name")]
        public string? Name
        {
            get => _name;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                _name = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the category of the food (e.g., Fruit, Dairy, Meat).
        /// </summary>
        [XmlElement("Category")]
        public FoodCategory? Category { get; set; }

        /// <summary>
        /// Gets or sets the serving size for the nutritional information.
        /// </summary>
        [XmlElement("ServingSize")]
        public double ServingSize { get; set; }

        /// <summary>
        /// Gets or sets the number of calories per serving.
        /// </summary>
        [XmlElement("Calories")]
        public float Calories {  get; set; }
        
        /// <summary>
        /// Gets or sets the carbohydrate content per serving (in grams).
        /// </summary>
        [XmlElement("Carbohydrate")]
        public float Carbohydrate  { get; set; }

        /// <summary>
        /// Gets or sets the fat content per serving (in grams).
        /// </summary>
        [XmlElement("Fat")]
        public float Fat { get; set; }

        /// <summary>
        /// Gets or sets the protein content per serving (in grams).
        /// </summary>
        [XmlElement("Protein")]
        public float Protein { get; set; }

        /// <summary>
        /// Gets or sets the saturated fat content per serving (in grams).
        /// </summary>
        [XmlElement("SaturedFat")]
        public float SaturedFat { get; set; }

        /// <summary>
        /// Gets or sets the trans fat content per serving (in grams).
        /// </summary>
        [XmlElement("TransFat")]
        public float TransFat { get; set; }

        /// <summary>
        /// Gets or sets the cholesterol content per serving (in milligrams).
        /// </summary>
        [XmlElement("Cholesterol")]
        public float Cholesterol { get; set; }

        /// <summary>
        /// Gets or sets the sodium content per serving (in milligrams).
        /// </summary>
        [XmlElement("Sodium")]
        public float Sodium { get; set; }

        /// <summary>
        /// Gets or sets the potassium content per serving (in milligrams).
        /// </summary>
        [XmlElement("Potassium")]
        public float Potassium { get; set; }

        /// <summary>
        /// Gets or sets the dietary fiber content per serving (in grams).
        /// </summary>
        [XmlElement("DietaryFiber")]
        public float DietaryFiber { get; set; }

        /// <summary>
        /// Gets or sets the sugar content per serving (in grams).
        /// </summary>
        [XmlElement("Sugar")]
        public float Sugar { get; set; }

        /// <summary>
        /// Compares the current <see cref="Food"/> object with another <see cref="Food"/> object based on name.
        /// </summary>
        /// <param name="other">The other food item to compare with.</param>
        /// <returns>
        /// An integer that indicates the relative order of the objects being compared. 
        /// Returns less than zero if this instance precedes <paramref name="other"/> in the sort order. 
        /// Zero if they are equal, and greater than zero if it follows <paramref name="other"/>.
        /// </returns>
        public int CompareTo(Food? other) => other == null ? 1 : string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);

        //Will be erased
        public void ShowFood()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("         Food Nutrition Chart         ");
            Console.WriteLine("======================================");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Category: {Category?.ToString() ?? "Unknown"}");
            Console.WriteLine($"Per serving of {ServingSize}");
            Console.WriteLine("======================================");
            Console.WriteLine("| Nutrient          | Amount         |");
            Console.WriteLine("|-------------------|----------------|");
            Console.WriteLine($"| Calories          | {Calories,10} kcal|");
            Console.WriteLine($"| Carbohydrate      | {Carbohydrate,13} g|");
            Console.WriteLine($"| Fat               | {Fat,13} g|");
            Console.WriteLine($"| Protein           | {Protein,13} g|");
            Console.WriteLine($"| Saturated Fat     | {SaturedFat,13} g|");
            Console.WriteLine($"| Trans Fat         | {TransFat,13} g|");
            Console.WriteLine($"| Cholesterol       | {Cholesterol,12} mg|");
            Console.WriteLine($"| Sodium            | {Sodium,12} mg|");
            Console.WriteLine($"| Potassium         | {Potassium,12} mg|");
            Console.WriteLine($"| Dietary Fiber     | {DietaryFiber,13} g|");
            Console.WriteLine($"| Sugar             | {Sugar,13} g|");
            Console.WriteLine("======================================");
        }
    }
}