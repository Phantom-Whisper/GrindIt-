using System;
using System.Collections.ObjectModel;

namespace GrindIt.WorkoutLib
{
    [Serializable]
    public class Exercise
    {
        public Exercise()
        {
            TargetedMuscles = new ObservableCollection<TargetedMuscles>();
            SetList = new ObservableCollection<Set>();
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

        public ObservableCollection<Set> SetList { get; set; }

        public void AddTargetedMuscles(TargetedMuscles muscles)
        {
            TargetedMuscles.Add(muscles);
        }

        public void AddSet(Set set)
        {
            SetList.Add(set);
        }

        public void ShowExercise()
        {
            Console.WriteLine("Exercise Information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Muscles targeted: " + (TargetedMuscles.Count > 0
                            ? string.Join(", ", TargetedMuscles)
                            : "None"));
            Console.WriteLine($"BodyWeight: {bodyWeight}");

            if (SetList.Count > 0)
            {
                Console.WriteLine("Sets:");
                foreach (var set in SetList)
                {
                    Console.WriteLine($"  - {set.Reps} reps at {set.Weight}kg");
                }
            }
            else
            {
                Console.WriteLine("No sets available for this exercise.");
            }
        }
    }
}
