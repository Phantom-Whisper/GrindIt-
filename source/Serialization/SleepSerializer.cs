using Manager;
using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Serialization
{
    public class SleepSerializer : ISerialize
    {
        readonly static string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GrindIt!\\Structures");
        const string xmlFile = "SleepTracking.xml";
        readonly string path = Path.Combine(filePath, xmlFile);

        public T Load<T>()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    return (T)serializer.Deserialize(fs);
                }
            }

            return default;
        }

        public void Save<T>(T data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fs, data);
            }
        }

        public void SaveSleepRecord(string date, string time, TimeSpan duration)
        {
            XDocument xmlDoc;

            if (File.Exists(path))
            {
                xmlDoc = XDocument.Load(path);
            }
            else
            {
                xmlDoc = new XDocument(new XElement("SleepData"));
            }

            XElement root = xmlDoc.Root;

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

            XElement newEntry = new XElement("Entry",
                                    new XAttribute("time", time),
                                    new XAttribute("duration", duration.ToString()));
            dayElement.Add(newEntry);

            xmlDoc.Save(path);
        }

        public TimeSpan LoadSleepDuration(string date)
        {
            if (!File.Exists(path))
                return TimeSpan.Zero;

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

            TimeSpan totalDuration = TimeSpan.Zero;
            if (dayElement != null)
            {
                foreach (XElement entry in dayElement.Elements("Entry"))
                {
                    totalDuration += TimeSpan.Parse(entry.Attribute("duration")?.Value);
                }
            }

            return totalDuration;
        }
    }
}
