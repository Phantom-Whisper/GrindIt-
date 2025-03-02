using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace GrindIt.WorkoutLib
{
    [Serializable]
    [XmlRoot("Workout")]
    public class Workout
    {
        public Workout()
        {
            Exercises = new ObservableCollection<Exercise>(); // Liste des exercices
            WorkoutDateTime = DateTime.Now.AddSeconds(-DateTime.Now.Second); // Initialiser avec la date et l'heure actuelles (sans les secondes)
            EndTime = DateTime.Now;
        }

        private ObservableCollection<Exercise> exercises;

        public ObservableCollection<Exercise> Exercises
        {
            get => exercises ??= new ObservableCollection<Exercise>();
            set => exercises = value ?? new ObservableCollection<Exercise>();
        }

        public DateTime WorkoutDateTime { get; set; }

        public DateTime EndTime { get; set; }

        public TimeSpan WorkoutDuration => EndTime - WorkoutDateTime;

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }

        public void RemoveExercise(Exercise exercise)
        {
            if (!Exercises.Remove(exercise))
                throw new InvalidOperationException("Exercise is not in your workout.");
        }

        public void EndWorkout()
        {
            EndTime = DateTime.Now;
        }
    }
}
