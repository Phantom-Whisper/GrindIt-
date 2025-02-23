using System.Collections.ObjectModel;

namespace GrindIt.WorkoutLib
{
    [Serializable]
    public class Exercise
    {
        public Exercise()
        {
            TargetedMuscles = new ObservableCollection<TargetedMuscles>();
        }

        public Exercise(string name, bool bodyWeight) : this()
        {
            Name = name;
            BodyWeight = bodyWeight;
        }

        public ObservableCollection<TargetedMuscles> TargetedMuscles { get; set; }

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        private string? name;

        public bool BodyWeight
        {
            get { return bodyWeight; }
            set { bodyWeight = value; }
        }

        private bool bodyWeight;

        public void AddTargetedMuscles(TargetedMuscles muscles)
        {
            TargetedMuscles.Add(muscles);
        }

        public void ShowExercise()
        {
            Console.WriteLine("Exercise Information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Muscles targeted: " + (TargetedMuscles.Count > 0
                            ? string.Join(", ", TargetedMuscles)
                            : "None"));
            Console.WriteLine($"BodyWheight: {bodyWeight}");
        }
    }
}
