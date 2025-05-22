namespace Core
{
    /// <summary>
    /// Contains the basic health metrics
    /// </summary>
    public class HealthMetrics(User user, Weight weight, Height height)
    {
        private readonly User user = user;
        private readonly Weight weight = weight;
        private readonly Height height = height;

        private double? bmi;

        /// <summary>
        /// Calculates the user BMI
        /// </summary>
        /// <returns></returns>
        public double CalculateBMI()
        {
            bmi = Math.Round((weight.Value / Math.Pow(height.Value, 2)) * 10000, 1);
            return bmi.Value;
        }

        /// <summary>
        /// Calculates the user IMG
        /// </summary>
        /// <param name="isMale"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public double CalculateIMG(bool isMale)
        {
            if (!bmi.HasValue)
                throw new InvalidOperationException("BMI must be calculated before IMG.");

            return (1.20 * bmi.Value) + (0.23 * user.Age) - (isMale ? 16.2 : 5.4);
        }

        /// <summary>
        /// Returns the BMI category
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
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

        /// <summary>
        /// Returns the IMG category
        /// </summary>
        /// <param name="img"></param>
        /// <param name="isMale"></param>
        /// <returns></returns>
        public static string GetIMGCategory(double img, bool isMale)
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
