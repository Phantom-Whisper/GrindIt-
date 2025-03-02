using Manager;
using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Serialization
{
    public class WaterSerializer : ISerialize
    {
        // Correct path initialization
        readonly static string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GrindIt!\\Structures");
        const string xmlFile = "WaterTracking.xml";
        readonly string path = Path.Combine(filePath, xmlFile);

        // Load method to deserialize XML into object
        public T Load<T>()
        {
            // Create an XmlSerializer for the desired type
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            // Check if the file exists, then load it
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    return (T)serializer.Deserialize(fs);
                }
            }

            // If the file doesn't exist, return the default value of the type
            return default;
        }

        // Save method to serialize object into XML
        public void Save<T>(T data)
        {
            // Create an XmlSerializer for the desired type
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            // Ensure the directory exists before saving
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            // Open the file for saving
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fs, data);
            }
        }

        // Save water consumption to XML (non-static method)
        public void SaveWaterConsumption(string date, string time, int amount)
        {
            XDocument xmlDoc;

            // Load or create the XML file
            if (File.Exists(path))
            {
                xmlDoc = XDocument.Load(path);
            }
            else
            {
                xmlDoc = new XDocument(new XElement("Consumption"));
            }

            XElement root = xmlDoc.Root;

            // Find or create the day entry
            XElement dayElement = null;
            foreach (XElement day in root.Elements("Day"))
            {
                if (day.Attribute("date")?.Value == date)
                {
                    dayElement = day;
                    break;
                }
            }

            if (dayElement == null)
            {
                dayElement = new XElement("Day", new XAttribute("date", date));
                root.Add(dayElement);
            }

            // Add a new entry
            XElement newEntry = new XElement("Entry",
                                    new XAttribute("time", time),
                                    amount);
            dayElement.Add(newEntry);

            // Save to file
            xmlDoc.Save(path);
        }

        // Load water consumption for a given date
        public int LoadWaterDrank(string date)
        {
            if (!File.Exists(path))
                return 0;

            XDocument xmlDoc = XDocument.Load(path);

            XElement dayElement = null;
            foreach (XElement day in xmlDoc.Root.Elements("Day"))
            {
                if (day.Attribute("date")?.Value == date)
                {
                    dayElement = day;
                    break;
                }
            }

            int totalWater = 0;
            if (dayElement != null)
            {
                foreach (XElement entry in dayElement.Elements("Entry"))
                {
                    totalWater += int.Parse(entry.Value);
                }
            }

            return totalWater;
        }
    }
}
