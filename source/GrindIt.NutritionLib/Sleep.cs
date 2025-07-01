using Serialization;

namespace GrindIt.NutritionLib
{
    /// <summary>
    /// Represents the sleep tracking system that records and calculates the total sleep duration.
    /// </summary>
    public class Sleep
    {
        private readonly SleepSerializer _sleepSerializer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleep"/> class with a specified bedtime, wake-up time, and serializer.
        /// Loads the total sleep duration for the current date from persistent storage.
        /// </summary>
        /// <param name="bedTime">The time the user went to bed.</param>
        /// <param name="wakeUpTime">The time the user woke up.</param>
        /// <param name="sleepSerializer">An instance of <see cref="SleepSerializer"/> used to persist and load sleep data.</param>
        public Sleep(DateTime bedTime, DateTime wakeUpTime, SleepSerializer sleepSerializer)
        {
            BedTime = bedTime;
            WakeUpTime = wakeUpTime;
            _sleepSerializer = sleepSerializer;

            var currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            TotalSleepDuration = _sleepSerializer.LoadSleepDuration(currentDate);
        }

        /// <summary>
        /// Gets or sets the time the user went to bed.
        /// </summary>
        public DateTime BedTime { get; }

        /// <summary>
        /// Gets or sets the time the user woke up.
        /// </summary>
        public DateTime WakeUpTime { get; }

        /// <summary>
        /// Gets the total sleep duration as a <see cref="TimeSpan"/>.
        /// </summary>
        public TimeSpan TotalSleepDuration { get; private set; }

        /// <summary>
        /// Calculates the total sleep duration by subtracting the bedtime from the wake-up time.
        /// </summary>
        public void CalculateSleepDuration()
        {
            TotalSleepDuration = WakeUpTime - BedTime;
        }

        /// <summary>
        /// Saves the sleep record, including the total sleep duration, to persistent storage.
        /// </summary>
        public void SaveSleepRecord()
        {
            var currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            var currentTime = DateTime.Now.ToString("HH:mm");

            _sleepSerializer.SaveSleepRecord(currentDate, currentTime, TotalSleepDuration);
        }

        // Wil be deleted
        public void ShowSleepDuration()
        {
            Console.WriteLine($"Total sleep duration: {TotalSleepDuration}");
        }
    }
}