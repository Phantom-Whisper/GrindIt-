using Serialization;

namespace GrindIt.NutritionLib
{
    /// <summary>
    /// Represents the water intake tracker for a specific day, including target and consumed amount.
    /// </summary>
    public class Water
    {
        private readonly WaterSerializer _waterSerializer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Water"/> class with a specified target and serializer.
        /// Loads the current day's water consumption data from persistent storage.
        /// </summary>
        /// <param name="target">The target amount of water to be consumed (in milliliters).</param>
        /// <param name="waterSerializer">An instance of <see cref="WaterSerializer"/> used to persist and load water consumption data.</param>
        public Water(int target, WaterSerializer waterSerializer)
        {
            WaterTarget = target;
            _waterSerializer = waterSerializer;

            // Load existing water consumption from the file
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            WaterDrank = _waterSerializer.LoadWaterDrank(currentDate);
        }

        /// <summary>
        /// Gets or sets the target water consumption (in milliliters).
        /// </summary>
        public int WaterTarget
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the amount of water consumed (in milliliters).
        /// </summary>
        public int WaterDrank
        {
            get;
            set;
        }

        /// <summary>
        /// Adds the specified amount of water to the current water consumption total.
        /// Also saves the consumption event with the current date and time.
        /// </summary>
        /// <param name="water">The amount of water to add (in milliliters).</param>
        /// <exception cref="ArgumentException">Thrown when the provided water amount is negative.</exception>
        public void AddWater(int water)
        {
            if (water < 0)
                throw new ArgumentException("Water amount cannot be negative.");

            WaterDrank += water;

            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string currentTime = DateTime.Now.ToString("HH:mm");

            // Save water consumption to file
            _waterSerializer.SaveWaterConsumption(currentDate, currentTime, water);
        }

        /// <summary>
        /// Removes the specified amount of water from the current water consumption total.
        /// </summary>
        /// <param name="water">The amount of water to remove (in milliliters).</param>
        /// <exception cref="ArgumentException">Thrown when the provided water amount is negative.</exception>
        /// <exception cref="InvalidOperationException">Thrown when trying to remove more water than has been consumed.</exception>
        public void RemoveWater(int water)
        {
            if (water < 0)
                throw new ArgumentException("Water amount cannot be negative.");

            if (WaterDrank >= water)
                WaterDrank -= water;
            else
                throw new InvalidOperationException("Not enough water to remove.");
        }

        // Will be deleted
        public void ShowWater()
        {
            Console.WriteLine($"{WaterDrank}/{WaterTarget} ml");
        }
    }
}