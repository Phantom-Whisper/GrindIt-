using System;
using System.Xml.Serialization;

namespace GrindIt.NutritionLib
{
    [Serializable]
    [XmlRoot("Food")]  
    public class Food
    {
        public Food() { }

        public Food(string name, float calories, float carbohydrate, float fat, float protein, float saturedFat, float transFat,
            float cholesterol, float sodium, float potassium, float dietaryFiber, float sugar, FoodCategory category)
        {
            this.name = name;
            this.calories = calories;
            this.cabohydrate = carbohydrate;
            this.fat = fat;
            this.protein = protein;
            this.saturedFat = saturedFat;
            this.transFat = transFat;
            this.cholesterol = cholesterol;
            this.sodium = sodium;
            this.potassium = potassium;
            this.dietaryFiber = dietaryFiber;
            this.sugar = sugar;
            this.category = category;
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

        private float calories;
        [XmlElement("Calories")]  
        public float Calories
        {
            get => calories;
            set => calories = value;
        }

        private float cabohydrate;
        [XmlElement("Cabohydrate")]  
        public float Cabohydrate
        {
            get => cabohydrate;
            set => cabohydrate = value;
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

        public void ShowFood()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("         Food Nutrition Chart         ");
            Console.WriteLine("======================================");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Category: {Category?.ToString() ?? "Unknown"}");
            Console.WriteLine("======================================");
            Console.WriteLine("| Nutrient          | Amount         |");
            Console.WriteLine("|-------------------|----------------|");
            Console.WriteLine($"| Calories          | {Calories,10} kcal|");
            Console.WriteLine($"| Carbohydrate      | {Cabohydrate,13} g|");
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
