using Serialization;
using System;

namespace GrindIt.NutritionLib
{
    public class Water
    {
        private readonly WaterSerializer _waterSerializer;

        public Water(int target, WaterSerializer waterSerializer)
        {
            WaterTarget = target;
            _waterSerializer = waterSerializer;

            // Load existing water consumption from the file
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            WaterDrank = _waterSerializer.LoadWaterDrank(currentDate);
        }

        private int waterTarget;

        public int WaterTarget
        {
            get => waterTarget;
            set => waterTarget = value;
        }

        private int waterDrank;

        public int WaterDrank
        {
            get => waterDrank;
            set => waterDrank = value;
        }

        // Method to add water consumption
        public void AddWater(int water)
        {
            if (water < 0)
                throw new ArgumentException("Water amount cannot be negative.");

            waterDrank += water;

            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string currentTime = DateTime.Now.ToString("HH:mm");

            // Save water consumption to file
            _waterSerializer.SaveWaterConsumption(currentDate, currentTime, water);
        }

        // Method to remove water consumption
        public void RemoveWater(int water)
        {
            if (water < 0)
                throw new ArgumentException("Water amount cannot be negative.");

            if (WaterDrank >= water)
                WaterDrank -= water;
            else
                throw new InvalidOperationException("Not enough water to remove.");
        }

        // Method to display the current water consumption
        public void ShowWater()
        {
            Console.WriteLine($"{waterDrank}/{WaterTarget} ml");
        }
    }
}
