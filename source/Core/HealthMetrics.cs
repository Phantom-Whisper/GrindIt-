namespace Core
{
    /// <summary>
    /// Contains the basic health metrics
    /// </summary>
    public class HealthMetrics(User user, Weight weight, Height height)
    {
        private double? _bmi;

        /// <summary>
        /// Calculates the user BMI
        /// </summary>
        /// <returns>A double representing the calculated BMI</returns>
        public double CalculateBmi()
        {
            _bmi = Math.Round((weight.Value / Math.Pow(height.Value, 2)) * 10000, 1);
            return _bmi.Value;
        }

        /// <summary>
        /// Calculates the user IMG
        /// </summary>
        /// <param name="isMale">A boolean telling if the user is male or female</param>
        /// <returns>A double representing the calculated IMG</returns>
        /// <exception cref="InvalidOperationException">Throws an exception if there's no calculated BMI</exception>
        public double CalculateImg(bool isMale)
        {
            if (!_bmi.HasValue)
                throw new InvalidOperationException("BMI must be calculated before IMG.");

            return (1.20 * _bmi.Value) + (0.23 * user.Age) - (isMale ? 16.2 : 5.4);
        }

        /// <summary>
        /// Returns the BMI category
        /// </summary>
        /// <returns>A string representing the BMI category the user fit in</returns>
        /// <exception cref="InvalidOperationException">Throws an exception if there's no calculated BMI</exception>
        public string GetBmiCategory()
        {
            if (!_bmi.HasValue)
                throw new InvalidOperationException("BMI must be calculated before determining category.");

            return _bmi switch
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
        /// <param name="img">A double representing the calculated IMG</param>
        /// <param name="isMale">A boolean representing the user gender</param>
        /// <returns>A string representing the IMG category</returns>
        public static string GetImgCategory(double img, bool isMale)
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

            return img switch // Different ways of calculating IMG for women
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
