using System.Collections.ObjectModel;

namespace GrindIt.WorkoutLib
{
    /// <summary>
    /// Represents an exercise in a workout routine, including the name, bodyweight status, targeted muscles, and associated sets.
    /// </summary>
    [Serializable]
    public class Exercise
    {
        private string? name;
        private bool bodyWeight;

        /// <summary>
        /// Initializes a new instance of the <see cref="Exercise"/> class with default values.
        /// This constructor initializes the <see cref="TargetedMuscles"/> and <see cref="SetList"/> collections.
        /// </summary>
        public Exercise()
        {
            TargetedMuscles = new ObservableCollection<TargetedMuscles>();
            SetList = new ObservableCollection<Set>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Exercise"/> class with the specified name and bodyweight status.
        /// This constructor also initializes the <see cref="TargetedMuscles"/> and <see cref="SetList"/> collections.
        /// </summary>
        /// <param name="name">The name of the exercise.</param>
        /// <param name="bodyWeight">Indicates whether the exercise uses bodyweight (true) or weights (false).</param>
        public Exercise(string name, bool bodyWeight) : this()
        {
            Name = name;
            BodyWeight = bodyWeight;
        }

        /// <summary>
        /// Gets or sets the collection of targeted muscles for the exercise.
        /// </summary>
        public ObservableCollection<TargetedMuscles> TargetedMuscles { get; set; }

        /// <summary>
        /// Gets or sets the name of the exercise.
        /// </summary>
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the exercise is a bodyweight exercise.
        /// </summary>
        public bool BodyWeight
        {
            get { return bodyWeight; }
            set { bodyWeight = value; }
        }

        /// <summary>
        /// Gets or sets the collection of sets associated with the exercise.
        /// </summary>
        public ObservableCollection<Set> SetList { get; set; }

        /// <summary>
        /// Adds a targeted muscle to the exercise.
        /// </summary>
        /// <param name="muscles">The <see cref="TargetedMuscles"/> object representing the targeted muscle.</param>
        public void AddTargetedMuscles(TargetedMuscles muscles)
        {
            TargetedMuscles.Add(muscles);
        }

        /// <summary>
        /// Adds a set to the exercise.
        /// </summary>
        /// <param name="set">The <see cref="Set"/> object representing the exercise set.</param>
        public void AddSet(Set set)
        {
            SetList.Add(set);
        }

        // To be deleted
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