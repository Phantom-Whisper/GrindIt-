namespace GrindIt.NutritionLib
{
    [Serializable]
    public class Food
    {
        public Food(string name, float calories, float carbohydrate, float fat, float protein, float saturedFat, float transFat, 
            float cholesterol, float sodium, float potassium, float dietaryFiber, float sugar, FoodCategory category)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

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

        public string? Name 
        { 
            get 
            { 
                return name; 
            }
        }

        private FoodCategory? category;

        public FoodCategory? Category
        {
            get
            {
                return category;
            }
        }

        private float calories;
        public float Calories
        {
            get
            {
                return calories;
            }
        }

        private float cabohydrate;
        public float Cabohydrate
        {
            get
            {
                return cabohydrate;
            }
        }

        private float fat;

        public float Fat
        {
            get
            {
                return fat;
            }
        }

        private float protein;

        public float Protein
        {
            get
            {
                return protein;
            }
        }

        private float saturedFat;

        public float SaturedFat
        {
            get
            {
                return saturedFat;
            }
        }

        private float transFat;
        public float TransFat
        {
            get
            {
                return transFat;
            }
        }

        private float cholesterol;
        public float Cholesterol
        {
            get
            {
                return cholesterol;
            }
        }

        private float sodium;
        public float Sodium
        {
            get
            {
                return sodium;
            }
        }

        private float potassium;
        public float Potassium
        {
            get
            {
                return potassium;
            }
        }

        private float dietaryFiber;
        public float DietaryFiber
        {
            get
            {
                return dietaryFiber;
            }
        }

        private float sugar;

        public float Sugar
        {
            get
            {
                return sugar;
            }
        }

        public void ShowFood()
        {
            Console.WriteLine("Food Information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Category: {Category?.ToString() ?? "Unknown"}");
            Console.WriteLine($"Calories: {Calories} kcal");
            Console.WriteLine($"Carbohydrate: {Cabohydrate} g");
            Console.WriteLine($"Fat: {Fat} g");
            Console.WriteLine($"Protein: {Protein} g");
            Console.WriteLine($"Saturated Fat: {SaturedFat} g");
            Console.WriteLine($"Trans Fat: {TransFat} g");
            Console.WriteLine($"Cholesterol: {Cholesterol} mg");
            Console.WriteLine($"Sodium: {Sodium} mg");
            Console.WriteLine($"Potassium: {Potassium} mg");
            Console.WriteLine($"Dietary Fiber: {DietaryFiber} g");
            Console.WriteLine($"Sugar: {Sugar} g");
        }
    }
}
