using Serialization;
using System;

namespace GrindIt.NutritionLib
{
    public class Sleep
    {
        private readonly SleepSerializer _sleepSerializer;

        public Sleep(DateTime bedTime, DateTime wakeUpTime, SleepSerializer sleepSerializer)
        {
            BedTime = bedTime;
            WakeUpTime = wakeUpTime;
            _sleepSerializer = sleepSerializer;

            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            TotalSleepDuration = _sleepSerializer.LoadSleepDuration(currentDate);
        }

        public DateTime BedTime { get; set; }
        public DateTime WakeUpTime { get; set; }

        public TimeSpan TotalSleepDuration { get; private set; }

        public void CalculateSleepDuration()
        {
            TotalSleepDuration = WakeUpTime - BedTime;
        }

        public void SaveSleepRecord()
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string currentTime = DateTime.Now.ToString("HH:mm");

            _sleepSerializer.SaveSleepRecord(currentDate, currentTime, TotalSleepDuration);
        }

        public void ShowSleepDuration()
        {
            Console.WriteLine($"Total sleep duration: {TotalSleepDuration}");
        }
    }
}
