using System.Collections.ObjectModel;

namespace GrindIt.WorkoutLib
{
    public class Exercices
    {
        private string? name;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        private readonly ObservableCollection<TargetedMuscles>? targetedMuscles;

        public ReadOnlyObservableCollection<TargetedMuscles> TargetedMuscles
        {
            get { return new ReadOnlyObservableCollection<TargetedMuscles>(targetedMuscles); }
        }

        private bool bodyWeight;

        public bool BodyWeight
        {
            get { return bodyWeight; }
            set { bodyWeight = value; }
        }

        public Exercices(string name, ObservableCollection<TargetedMuscles> muscles, bool bodyWeight)
        {
            if (muscles == null || muscles.Count == 0) throw new ArgumentNullException("The list of targeted muscles must contain at least one muscle.");
            this.name = name;
            this.targetedMuscles = muscles;
            this.BodyWeight = bodyWeight;
        }
    }
}
