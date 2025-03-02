using System;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GrindIt.NutritionLib
{
    [Serializable]
    [XmlRoot("Food")]  
    public class Food : IComparable<Food>
    {
        public Food() { }

        public Food(string name, float calories, int serving, float carbohydrate, float fat, float protein, float saturedFat, float transFat,
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

        private string? name;
        [XmlElement("Name")]  
        public string? Name
        {
            get => name;
            set => name = value;
        }

        private FoodCategory? category;
        [XmlElement("Category")]  
        public FoodCategory? Category
        {
            get => category;
            set => category = value;
        }

        private int servingSize;
        [XmlElement("ServingSize")]
        public int ServingSize
        {
            get => servingSize;
            set => servingSize = value;
        }

        private float calories;
        [XmlElement("Calories")]  
        public float Calories
        {
            get => calories;
            set => calories = value;
        }

        private float carbohydrate;
        [XmlElement("Carbohydrate")]  
        public float Carbohydrate
        {
            get => carbohydrate;
            set => carbohydrate = value;
        }

        private float fat;
        [XmlElement("Fat")]  
        public float Fat
        {
            get => fat;
            set => fat = value;
        }

        private float protein;
        [XmlElement("Protein")]  
        public float Protein
        {
            get => protein;
            set => protein = value;
        }

        private float saturedFat;
        [XmlElement("SaturedFat")]  
        public float SaturedFat
        {
            get => saturedFat;
            set => saturedFat = value;
        }

        private float transFat;
        [XmlElement("TransFat")]  
        public float TransFat
        {
            get => transFat;
            set => transFat = value;
        }

        private float cholesterol;
        [XmlElement("Cholesterol")]  
        public float Cholesterol
        {
            get => cholesterol;
            set => cholesterol = value;
        }

        private float sodium;
        [XmlElement("Sodium")]  
        public float Sodium
        {
            get => sodium;
            set => sodium = value;
        }

        private float potassium;
        [XmlElement("Potassium")]  
        public float Potassium
        {
            get => potassium;
            set => potassium = value;
        }

        private float dietaryFiber;
        [XmlElement("DietaryFiber")]  
        public float DietaryFiber
        {
            get => dietaryFiber;
            set => dietaryFiber = value;
        }

        private float sugar;
        [XmlElement("Sugar")]  
        public float Sugar
        {
            get => sugar;
            set => sugar = value;
        }

        public int CompareTo(Food other)
        {
            return other == null ? 1 : string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }

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
