namespace Core
{
    public class HealthMetrics
    {
        private readonly User user;
        private readonly Weight weight;
        private readonly Height height;

        private double? bmi;

        public HealthMetrics(User user, Weight weight, Height height)
        {
            this.user = user;
            this.weight = weight;
            this.height = height;
        }

        public double CalculateBMI()
        {
            bmi = Math.Round((weight.Value / Math.Pow(height.Value, 2)) * 10000, 1);
            return bmi.Value;
        }

        public double CalculateIMG(bool isMale)
        {
            if (!bmi.HasValue)
                throw new InvalidOperationException("BMI must be calculated before IMG.");

            return (1.20 * bmi.Value) + (0.23 * user.Age) - (isMale ? 16.2 : 5.4);
        }

        public string GetBMICategory()
        {
            if (!bmi.HasValue)
                throw new InvalidOperationException("BMI must be calculated before determining category.");

            return bmi switch
            {
                < 18.5 => "Underweight",
                >= 18.5 and < 24.9 => "Normal weight",
                >= 25 and < 29.9 => "Overweight",
                _ => "Obese"
            };
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
