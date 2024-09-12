using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindIt.NutritionLib
{
    public class BMI
    {
        public double BMIResult { get; private set; }
        public BMI(double weight, double height) 
        {
            if (weight <= 0 || height <= 0)
            {
                throw new ArgumentException("Weight and height must be greater than zero.");
            }

            BMIResult = weight / (height * height);
        }

        public double CalculateIMG(int age, bool isMale)
        {
            if (age <= 0)
            {
                throw new ArgumentException("Age must be greater than zero.");
            }

            double IMG = (1.20 * BMIResult) + (0.23 * age) - (isMale ? 16.2 : 5.4);
            return IMG;
        }

        public string GetBMICategory()
        {
            if (BMIResult < 18.5)
            {
                return "Underweight";
            }
            else if (BMIResult >= 18.5 && BMIResult < 24.9)
            {
                return "Normal weight";
            }
            else if (BMIResult >= 25 && BMIResult < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }

        public string GetIMGCategory(double IMG, bool isMale)
        {
            if (isMale)
            {
                return IMG switch
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
                return IMG switch
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
