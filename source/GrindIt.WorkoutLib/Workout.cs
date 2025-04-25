using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace GrindIt.WorkoutLib
{
    /// <summary>
    /// Represents a workout session, containing a list of exercises, start and end times, and workout duration.
    /// </summary>
    [Serializable]
    [XmlRoot("Workout")]
    public class Workout
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Workout"/> class with default values.
        /// </summary>
        public Workout()
        {
            Exercises = new ObservableCollection<Exercise>(); // List of exercises in the workout
            WorkoutDateTime = DateTime.Now.AddSeconds(-DateTime.Now.Second); // Set current time without seconds
            EndTime = DateTime.Now;
        }

        private ObservableCollection<Exercise> exercises;

        /// <summary>
        /// Gets or sets the list of exercises in the workout.
        /// </summary>
        public ObservableCollection<Exercise> Exercises
        {
            get => exercises ??= new ObservableCollection<Exercise>(); // Initialize if null
            set => exercises = value ?? new ObservableCollection<Exercise>(); // Ensure non-null value
        }

        /// <summary>
        /// Gets or sets the start time of the workout session.
        /// </summary>
        public DateTime WorkoutDateTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the workout session.
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets the total duration of the workout session.
        /// </summary>
        public TimeSpan WorkoutDuration => EndTime - WorkoutDateTime;

        /// <summary>
        /// Adds an exercise to the workout session.
        /// </summary>
        /// <param name="exercise">The exercise to add.</param>
        /// <exception cref="ArgumentNullException">Thrown if the exercise is null.</exception>
        public void AddExercise(Exercise exercise)
        {
            if (exercise == null)
                throw new ArgumentNullException(nameof(exercise), "Exercise cannot be null.");
            Exercises.Add(exercise);
        }

        /// <summary>
        /// Removes an exercise from the workout session.
        /// </summary>
        /// <param name="exercise">The exercise to remove.</param>
        /// <exception cref="InvalidOperationException">Thrown if the exercise is not part of the workout.</exception>
        public void RemoveExercise(Exercise exercise)
        {
            if (exercise == null)
                throw new ArgumentNullException(nameof(exercise), "Exercise cannot be null.");

            if (!Exercises.Remove(exercise))
                throw new InvalidOperationException("Exercise is not in your workout.");
        }

        /// <summary>
        /// Ends the workout session and sets the end time to the current time.
        /// </summary>
        public void EndWorkout()
        {
            EndTime = DateTime.Now;
        }
    }
}