using Manager;

namespace Serialization
{
    public class Serialize : ISerialize
    {
        readonly static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GrindIt!\\Structures\\";
        const string xmlFile = "save.xml";
        readonly string path = Path.Combine(filePath, xmlFile);
        public Serialize() 
        {
            if(!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            if(!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        public object Load()
        {

        }

        public void Save()
        {

        }
    }
}
