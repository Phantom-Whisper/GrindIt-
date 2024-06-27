namespace GrindIt.NutritionLib
{
    public class Food
    {
        public Food(string name, int calories, int carbohydrate, int fat, int protein, int saturedFat, int transFat, int cholesterol, int sodium, int potassium, int dietaryFiber, int sugar)
        {
            if (name == null)
            {
                throw new ArgumentNullException("You have to provide a name");
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

        private int calories;
        public int Calories
        {
            get
            {
                return calories;
            }
        }

        private int cabohydrate;
        public int Cabohydrate
        {
            get
            {
                return cabohydrate;
            }
        }

        private int fat;

        public int Fat
        {
            get
            {
                return fat;
            }
        }

        private int protein;

        public int Protein
        {
            get
            {
                return protein;
            }
        }

        private int saturedFat;

        public int SaturedFat
        {
            get
            {
                return saturedFat;
            }
        }

        private int transFat;
        public int TransFat
        {
            get
            {
                return transFat;
            }
        }

        private int cholesterol;
        public int Cholesterol
        {
            get
            {
                return cholesterol;
            }
        }

        private int sodium;
        public int Sodium
        {
            get
            {
                return sodium;
            }
        }

        private int potassium;
        public int Potassium
        {
            get
            {
                return potassium;
            }
        }

        private int dietaryFiber;
        public int DietaryFiber
        {
            get
            {
                return dietaryFiber;
            }
        }

        private int sugar;

        public int Sugar
        {
            get
            {
                return sugar;
            }
        }
    }
}
