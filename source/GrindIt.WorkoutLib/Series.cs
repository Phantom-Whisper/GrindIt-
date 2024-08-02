namespace GrindIt.WorkoutLib
{
    public class Series
    {
        public Series() { }

        /*
        public Series(int weight, int nbReps)
        { 
            this.weight = weight;
            this.reps = nbReps;
        }
        */

        public int Weight
        {
            get { return weight; }
        }

        private int weight;

        public int Reps
        {
            get { return reps; }
        }

        private int reps;

        public void AddReps(int reps)
        {
            this.reps = reps;
        }

        public void AddReps()
        {
            reps++;
        }

        public void RemoveReps()
        {
            if (reps > 0)
            {
                reps--;
            }
        }

        public void AddWeight(int weight)
        {
            this.weight = weight;
        }

        public void AddWeight()
        {
            weight++;
        }

        public void RemoveWeigth()
        {
            if (weight > 0)
            {
                weight--;
            }
        }

        public int TotalWeight()
        {
            return weight * reps;
        }
    }
}
