using System.Xml.Serialization;

namespace Core
{
    [Serializable]
    [XmlRoot("UserInfo")]
    public class User
    {
        private string name;
        private int age;
        private double weight;
        private double height;
        private double bmi;

        public User(string name, int age, double weight, double height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Age must be greater than zero.");
                age = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Weight must be greater than zero.");
                weight = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Height must be greater than zero.");
                height = value;
            }
        }

        public double BMI
        {
            get { return bmi; }
        }

        public double CalculateBMI()
        {
            if (height <= 0 || weight <= 0)
            {
                throw new InvalidOperationException("Height and weight must be greater than zero to calculate BMI.");
            }

            bmi = Math.Round((weight / Math.Pow(height, 2))*10000, 1);
            return bmi;
        }

        public double CalculateIMG(bool isMale)
        {
            if (age <= 0)
            {
                throw new ArgumentException("Age must be greater than zero.");
            }

            if (bmi == 0)
            {
                throw new InvalidOperationException("BMI must be calculated before IMG.");
            }

            double img = (1.20 * bmi) + (0.23 * age) - (isMale ? 16.2 : 5.4);
            return img;
        }

        public string GetBMICategory()
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }

        public string GetIMGCategory(double img, bool isMale)
        {
            if (isMale)
            {
                return img switch
                {
                    <= 5 => "Essential Fat",
                    > 5 and <= 13 => "Athletes",
                    > 13 and <= 17 => "Fitness",
                    > 17 and <= 24 => "Average",
                    _ => "Obese"
                };
            }
            else
            {
                return img switch
                {
                    <= 13 => "Essential Fat",
                    > 13 and <= 20 => "Athletes",
                    > 20 and <= 24 => "Fitness",
                    > 24 and <= 31 => "Average",
                    _ => "Obese"
                };
            }
        }
    }
}