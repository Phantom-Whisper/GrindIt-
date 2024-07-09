using System.Collections.ObjectModel;

namespace GrindIt.WorkoutLib
{
    public class Exercices
    {
        public Exercices(string name, ObservableCollection<TargetedMuscles> muscles, bool bodyWeight)
        {
            if (muscles == null || muscles.Count == 0) throw new ArgumentNullException("The list of targeted muscles must contain at least one muscle.");
            this.name = name;
            this.targetedMuscles = muscles;
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
    }
}
