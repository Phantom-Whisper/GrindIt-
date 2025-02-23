using System.Xml.Serialization;
using Manager;

namespace Serialization
{
    public class FoodSerialize : ISerialize
    {
        readonly static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GrindIt!\\Structures\\";
        const string xmlFile = "foodSave.xml";
        readonly string path = Path.Combine(filePath, xmlFile);

        public FoodSerialize()
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
    }
}
