using System.Collections.ObjectModel;

namespace GrindIt.WorkoutLib
{
    public class Exercise
    {
        public Exercise(string name,  bool bodyWeight)
        {
            this.Name = name;
            this.targetedMuscles = new ObservableCollection<TargetedMuscles>();
            this.BodyWeight = bodyWeight;
        }

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        private string? name;

        public ReadOnlyObservableCollection<TargetedMuscles> TargetedMuscles
        {
            get { return new ReadOnlyObservableCollection<TargetedMuscles>(targetedMuscles); }
        }

        private readonly ObservableCollection<TargetedMuscles> targetedMuscles;

        public bool BodyWeight
        {
            get { return bodyWeight; }
            set { bodyWeight = value; }
        }

        private bool bodyWeight;

        public void AddTargetedMuscles(TargetedMuscles muscles)
        {
            targetedMuscles.Add(muscles);
        }

        public void ShowExercise()
        {
            Console.WriteLine("Exercise Information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Muscles targeted: " + (targetedMuscles.Count > 0
                            ? string.Join(", ", targetedMuscles)
                            : "None"));
            Console.WriteLine($"BodyWheight: {bodyWeight}");
        }
    }
}
