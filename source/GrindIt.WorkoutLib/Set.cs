namespace GrindIt.WorkoutLib
{
    /// <summary>
    /// Represents a set of an exercise, which includes the weight lifted and the number of repetitions.
    /// </summary>
    public class Set
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Set"/> class with default values.
        /// </summary>
        public Set() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Set"/> class with the specified weight and repetitions.
        /// </summary>
        /// <param name="weight">The weight lifted in the set (in kilograms).</param>
        /// <param name="reps">The number of repetitions performed in the set.</param>
        public Set(int weight, int reps)
        {
            Weight = weight;
            Reps = reps;
        }

        /// <summary>
        /// Gets or sets the weight lifted in the set (in kilograms).
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Gets or sets the number of repetitions performed in the set.
        /// </summary>
        public int Reps { get; set; }

        /// <summary>
        /// Sets the number of repetitions for the set.
        /// </summary>
        /// <param name="reps">The number of repetitions to set.</param>
        public void SetReps(int reps)
        {
            Reps = reps;
        }

        /// <summary>
        /// Increases the number of repetitions by 1.
        /// </summary>
        public void AddReps()
        {
            Reps++;
        }

        /// <summary>
        /// Decreases the number of repetitions by 1, if greater than 0.
        /// </summary>
        public void RemoveReps()
        {
            if (Reps > 0)
            {
                Reps--;
            }
        }

        /// <summary>
        /// Sets the weight lifted in the set.
        /// </summary>
        /// <param name="weight">The weight to set (in kilograms).</param>
        public void SetWeight(int weight)
        {
            Weight = weight;
        }

        /// <summary>
        /// Increases the weight lifted by 1 kilogram.
        /// </summary>
        public void AddWeight()
        {
            Weight++;
        }

        /// <summary>
        /// Decreases the weight lifted by 1 kilogram, if greater than 0.
        /// </summary>
        public void RemoveWeight()
        {
            if (Weight > 0)
            {
                Weight--;
            }
        }

        /// <summary>
        /// Calculates the total weight lifted in the set, which is the product of weight and repetitions.
        /// </summary>
        /// <returns>The total weight lifted in the set (weight * reps).</returns>
        public int TotalWeight()
        {
            return Weight * Reps;
        }
    }
}