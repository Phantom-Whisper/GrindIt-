namespace GrindIt.WorkoutLib
{
    public class Set
    {
        public Set() { }

        public Set(int weight, int reps)
        {
            Weight = weight;
            Reps = reps;
        }

        public int Weight { get; set; }
        public int Reps { get; set; }

        public void SetReps(int reps)
        {
            Reps = reps;
        }

        public void AddReps()
        {
            Reps++;
        }

        public void RemoveReps()
        {
            if (Reps > 0)
            {
                Reps--;
            }
        }

        public void SetWeight(int weight)
        {
            Weight = weight;
        }

        public void AddWeight()
        {
            Weight++;
        }

        public void RemoveWeight()
        {
            if (Weight > 0)
            {
                Weight--;
            }
        }

        public int TotalWeight()
        {
            return Weight * Reps;
        }
    }
}
