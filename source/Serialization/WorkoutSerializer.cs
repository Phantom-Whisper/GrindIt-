using GrindIt.WorkoutLib;
using Manager;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Serialization
{
    public class WorkoutSerializer : ISerialize
    {
        readonly static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GrindIt!\\Data\\";
        const string xmlFile = "WorkoutTracking.xml";
        readonly string path = Path.Combine(filePath, xmlFile);

        public WorkoutSerializer()
        {
            try
            {
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating directory: {ex.Message}");
            }
        }

        public T Load<T>()
        {
            if (!File.Exists(path) || new FileInfo(path).Length == 0)
            {
                return default;
            }

            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
                return default;
            }
        }

        public void Save<T>(T data)
        {
            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(stream, data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving file: {ex.Message}");
            }
        }

        public void SaveWorkoutRecord(Workout workout)
        {
            XDocument xmlDoc;

            // Vérifie si le fichier existe et le charge, sinon crée un nouveau document XML
            if (File.Exists(path))
            {
                xmlDoc = XDocument.Load(path);
            }
            else
            {
                xmlDoc = new XDocument(new XElement("Workouts"));
            }

            XElement root = xmlDoc.Root;

            // Crée l'élément Workout avec des attributs pour la date, l'heure de début, l'heure de fin et la durée
            XElement workoutElement = new XElement("Workout",
                new XAttribute("date", workout.WorkoutDateTime.ToString("yyyy-MM-dd")),
                new XAttribute("startTime", workout.WorkoutDateTime.ToString("HH:mm")),
                new XAttribute("endTime", workout.EndTime.ToString("HH:mm")),
                new XAttribute("duration", workout.WorkoutDuration.ToString()));

            // Parcourt la liste des exercices dans le workout
            foreach (var exercise in workout.Exercises)
            {
                // Crée un élément pour chaque exercice
                XElement exerciseElement = new XElement("Exercise",
                    new XAttribute("name", exercise.Name),
                    new XAttribute("bodyWeight", exercise.BodyWeight));

                // Parcourt les sets associés à cet exercice
                foreach (var set in exercise.SetList)
                {
                    // Crée un élément pour chaque set
                    XElement setElement = new XElement("Set",
                        new XAttribute("reps", set.Reps),
                        new XAttribute("weight", set.Weight));

                    exerciseElement.Add(setElement);
                }

                // Ajoute l'élément de l'exercice au workout
                workoutElement.Add(exerciseElement);
            }

            // Ajoute l'élément workout à la racine du document XML
            root.Add(workoutElement);

            // Sauvegarde le document XML
            xmlDoc.Save(path);
        }

    }
}
